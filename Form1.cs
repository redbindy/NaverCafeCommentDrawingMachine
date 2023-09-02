using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DrawMachine
{
    public partial class Form1 : Form
    {
        const int WAITING_SECOND = 1;
        const int CAPACITY = 1024;

        private ChromeDriverService mDriverService;
        private ChromeOptions mOptions;
        private ChromeDriver mDriver;

        private string mSavePath = "./save.txt";

        public Form1()
        {
            InitializeComponent();

            mDriverService = ChromeDriverService.CreateDefaultService();
            mDriverService.HideCommandPromptWindow = true;

            mOptions = new ChromeOptions();
            mOptions.AddArgument("disable-gpu");
            // mOptions.AddArgument("headless");

            mDriverService.HideCommandPromptWindow = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(mSavePath))
            {
                return;
            }

            using (StreamReader sr = new StreamReader(mSavePath))
            {
                if (sr.EndOfStream)
                {
                    return;
                }

                DialogResult dr = MessageBox.Show("자동저장된 데이터가 있습니다. 복구하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (dr == DialogResult.No)
                {
                    return;
                }

                Dictionary<string, List<User>> userData = DrawManager.Instance.SelectedUserSet;

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string[] data = line.Trim().Split('|');

                    string prize = data[0];
                    string name = data[1];
                    string comment = data[2];

                    if (!userData.ContainsKey(prize))
                    {
                        userData[prize] = new List<User>(CAPACITY);
                    }

                    User user = new User(name, comment);

                    userData[prize].Add(user);

                    ListViewItem item = new ListViewItem(name);
                    item.SubItems.Add(comment);
                    item.SubItems.Add(prize);

                    AllUserList.Items.Add(item);
                }

                autoResizeListView(AllUserList);
            }
        }

        private void LinkButton_Click(object sender, EventArgs e)
        {
            if (mDriver == null)
            {
                return;
            }

            try
            {
                progressBar1.Value = progressBar1.Minimum;

                progressBar1.PerformStep();

                mDriver.Navigate().GoToUrl(LinkBox.Text);
                mDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(WAITING_SECOND);
                mDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(3);

                string winHandleBefore = mDriver.CurrentWindowHandle;

                WebDriverWait wait = new WebDriverWait(mDriver, TimeSpan.FromSeconds(WAITING_SECOND));

                IWebElement iFrame
                    = wait
                    .Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"cafe_main\"]")));

                mDriver.SwitchTo().Frame(iFrame);
                {
                    progressBar1.PerformStep();

                    DrawManager.Instance.CurrPrize
                        = wait
                        .Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[1]/div[1]/div/h3")))
                        .Text;

                    List<User> userList = new List<User>(CAPACITY);

                    bool isPagenatePresent = mDriver.FindElements(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[2]/div[4]/div[2]")).Count > 0;

                    int buttonCount = 0;
                    if (isPagenatePresent)
                    {
                        IWebElement buttons = mDriver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[2]/div[4]/div[2]"));
                        string buttonSources = buttons.GetAttribute("outerText");

                        if (buttonSources.IndexOf("페이징 이동") != -1)
                        {
                            string[] buttonOuterText = buttonSources.Split(new String[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                            buttonCount = buttonOuterText[1].Length;
                        }
                    }

                    progressBar1.PerformStep();

                    getComments(userList, wait);
                    for (int i = 2; i <= buttonCount; ++i)
                    {
                        IWebElement button
                            = wait
                            .Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//*[@id=\"app\"]/div/div/div[2]/div[2]/div[4]/div[2]/button[{i}]")));
                        button.Click();

                        getComments(userList, wait);

                        progressBar1.PerformStep();
                    }

                    IWebElement totalCount
                        = wait
                        .Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[1]/div[3]/a[1]/strong")));

                    progressBar1.PerformStep();

                    int commentCount = int.Parse(totalCount.Text);

                    if (commentCount != userList.Count)
                    {
                        notifyMessage("동기화 오류! 다시 시도해주세요.");

                        progressBar1.Value = progressBar1.Minimum;

                        return;
                    }

                    progressBar1.Value = progressBar1.Maximum;

                    DrawManager.Instance.LoadUserList(userList);

                    PeopleCounter.Text = $"{userList.Count}";
                    ShowUsers(Users, userList);
                }
                mDriver.SwitchTo().Window(winHandleBefore);
            }
            catch (Exception ex)
            {
                if (ex is NoSuchElementException
                    || ex is StaleElementReferenceException
                    || ex is TimeoutException)
                {
                    notifyMessage("동기화 오류! 다시 시도해주세요.");

                    progressBar1.Value = progressBar1.Minimum;

                    return;
                }

                saveData();

                MessageBox.Show(ex.Message);

                using (StreamWriter sw = new StreamWriter("./exception_log.txt"))
                {
                    sw.WriteLine(ex.Message);
                    sw.WriteLine();
                    sw.WriteLine(ex.StackTrace);
                }

                this.Dispose();

                return;
            }

            saveData();
        }

        private void getComments(List<User> userList, WebDriverWait wait)
        {
            StringBuilder sb = new StringBuilder(CAPACITY);

            Thread.Sleep(300);

            IWebElement source
                        = wait
                        .Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[2]/div[4]/ul")));
            string innerText = source.GetAttribute("innerText");

            string[] commentData = innerText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < commentData.Length; ++i)
            {
                DateTime dateTime;
                if (DateTime.TryParse(commentData[i], out dateTime))
                {
                    continue;
                }

                string name = commentData[i++];

                while (!DateTime.TryParse(commentData[i], out dateTime))
                {
                    sb.Append($"{commentData[i++]}/");
                }

                userList.Add(new User(name, sb.ToString()));
                sb.Clear();
            }
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            uint count;
            uint.TryParse(Count.Text, out count);

            List<User> userList = DrawManager.Instance.DrawUsers(count);

            if (!DelayShowing.Checked)
            {
                ShowUsers(SelectedUserList, userList);
            }
            else
            {
                SlowShowUsers(userList);
            }

            AllUserList.Items.Clear();

            foreach (var keyValuePair in DrawManager.Instance.SelectedUserSet)
            {
                foreach (User user in keyValuePair.Value)
                {
                    ListViewItem item = new ListViewItem(user.Name);
                    item.SubItems.Add(user.Comment);
                    item.SubItems.Add(keyValuePair.Key);

                    AllUserList.Items.Add(item);
                }
            }

            autoResizeListView(AllUserList);
        }

        private void ShowUsers(System.Windows.Forms.ListView listView, List<User> userList)
        {
            listView.Items.Clear();

            foreach (User user in userList)
            {
                addUserToView(listView, user);
            }

            autoResizeListView(listView);
        }

        private void SlowShowUsers(List<User> userList)
        {
            SelectedUserList.Items.Clear();

            foreach (User user in userList)
            {
                progressBar1.Value = progressBar1.Minimum;

                while (progressBar1.Value < progressBar1.Maximum)
                {
                    progressBar1.PerformStep();
                    Thread.Sleep(80);
                }

                addUserToView(SelectedUserList, user);

                autoResizeListView(SelectedUserList);
            }
        }

        private void addUserToView(System.Windows.Forms.ListView listView, User user)
        {
            ListViewItem item = new ListViewItem(user.Name);
            item.SubItems.Add(user.Comment);

            listView.Items.Add(item);
        }

        private void tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MakePost_Click(object sender, EventArgs e)
        {
            DrawManager.Instance.MakePost();
        }

        private void OTPButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(OTPBox.Text))
            {
                notifyMessage("OTP를 입력 후 다시 시도해주세요.");

                return;
            }

            if (mDriver != null)
            {
                return;
            }

            progressBar1.Minimum = progressBar1.Minimum;

            try
            {
                mDriver = new ChromeDriver(mDriverService, mOptions);

                mDriver.Navigate().GoToUrl("https://nid.naver.com/nidlogin.login?mode=form&url=https://www.naver.com/");
                mDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(WAITING_SECOND);

                progressBar1.PerformStep();

                WebDriverWait wait = new WebDriverWait(mDriver, TimeSpan.FromSeconds(WAITING_SECOND));

                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ones\"]")));
                element.Click();

                progressBar1.PerformStep();

                element = wait.Until(ExpectedConditions.ElementIsVisible((By.XPath("//*[@id=\"disposable\"]"))));
                element.SendKeys(OTPBox.Text);

                element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"otnlog.login\"]")));
                element.Click();

                progressBar1.PerformStep();

                OTPBox.Text = "";

                if (mDriver.Url != "https://www.naver.com/")
                {
                    notifyMessage("다시 시도해주세요.");

                    progressBar1.Value = progressBar1.Minimum;

                    mDriver.Dispose();
                    mDriver = null;

                    return;
                }
            }
            catch (Exception ex)
            {
                notifyMessage("동기화 오류! 다시 시도해주세요.");
                return;
            }

            progressBar1.Value = progressBar1.Maximum;
        }

        private void autoResizeListView(ListView listView)
        {
            Debug.Assert(listView != null);

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void saveData()
        {
            using (StreamWriter sw = new StreamWriter(mSavePath))
            {
                foreach (var keyValuePair in DrawManager.Instance.SelectedUserSet)
                {
                    foreach (User user in keyValuePair.Value)
                    {
                        sw.WriteLine($"{keyValuePair.Key} | {user.Name} | {user.Comment.Trim()}");
                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S))
            {
                saveData();

                notifyMessage("완료됐습니다.");

                return true;
            }

            return false;
        }

        private void ManualSave_Click(object sender, EventArgs e)
        {
            saveData();

            notifyMessage("완료됐습니다.");
        }

        private void notifyMessage(string message)
        {
            Debug.Assert(message != null);

            MessageBox.Show(message, "알림");
        }
    }
}
