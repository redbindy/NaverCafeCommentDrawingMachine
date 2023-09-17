using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace NaverCafeCommentDrawingMachine
{
    public partial class Form1 : Form
    {
        private readonly string NOTIFICATION = "알림";
        private readonly string AUTO_SAVE_PATH = "./AutoSave.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(AUTO_SAVE_PATH))
            {
                return;
            }

            using (StreamReader sr = new StreamReader(AUTO_SAVE_PATH))
            {
                if (sr.EndOfStream)
                {
                    return;
                }

                DialogResult yesOrNo = MessageBox.Show(
                "이전에 저장된 전체 당첨자 목록이 있습니다. 불러오시겠습니까?",
                NOTIFICATION,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

                if (yesOrNo == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void LoginNumbersBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.Handled)
            {
                const int DURATION = 1000;

                LoginNumbersToolTip.Show("숫자만 입력해주세요.", LoginNumbersBox, DURATION);
            }
        }

        private void LoginNumbersButton_Click(object sender, EventArgs e)
        {
            var i = DrawingManager.Instance.login(LoginNumbersBox.Text);
        }
    }
}
