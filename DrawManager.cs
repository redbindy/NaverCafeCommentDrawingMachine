using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DrawMachine
{
    public class DrawManager
    {
        const int CAPACITY = 1024;

        private static DrawManager mInstance;

        public Dictionary<string, List<User>> SelectedUserSet { get; }
        public List<User> UserList { get; private set; }

        public string CurrPrize { set; get; }

        public static DrawManager Instance
        {
            get
            {
                if (mInstance == null)
                {
                    mInstance = new DrawManager();
                }

                return mInstance;
            }
        }

        private DrawManager()
        {
            SelectedUserSet = new Dictionary<string, List<User>>(CAPACITY);
            UserList = new List<User>(CAPACITY);
        }

        public List<User> LoadUserList(List<User> userList)
        {
            UserList = userList;

            return UserList;
        }

        public List<User> DrawUsers(uint count)
        {
            List<User> selectedUserList = new List<User>(CAPACITY);

            SelectedUserSet[CurrPrize] = selectedUserList;

            long overlapCount = 0;

            Random random = new Random();

            while (selectedUserList.Count < count && overlapCount < UserList.Count)
            {
                User user = UserList[random.Next(UserList.Count)];

                foreach (List<User> list in SelectedUserSet.Values)
                {
                    if (list.Contains(user))
                    {
                        goto next;
                    }
                }

                selectedUserList.Add(user);

            next:;
            }

            return selectedUserList;
        }

        public void MakePost()
        {
            // 경우에 따라 다름
        }
    }
}
