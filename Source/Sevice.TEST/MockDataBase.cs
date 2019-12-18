using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSSQLBase;

namespace Sevice.TEST
{
    public class MockDataBase : IDataBase
    {
        public List<string> users;
        public List<string> messeges;

        public MockDataBase()
        {
            messeges = new List<string>();
            users = new List<string>();
            users.Add("vadik");
            users.Add("iluxa");
            users.Add("tema");
            users.Add("roma");
            users.Add("solyzra");
            users.Add("ridux");
            users.Add("dima");
            users.Add("maks");
        }

        public void AddMsg(string msg)
        {
            users.Insert(0, msg);
        }

        public void AddUser(string userName)
        {
            users.Insert(0, userName);
        }

        public string GetMsg(string UserName)
        {
            return messeges.ToArray()[0];
        }

        public string[] GetUsers()
        {
            string[] str = new string[users.Count()];
            int i = 0;

            foreach (var usr in users)
            {
                str[i++] = usr;
            }

            return str;
        }

        public string ModificationMsgDB(int idMsg, string newMsg)
        {
            string str = " ";
            return str;
        }

        public string[] GetMsg(string userNameFrom, string userNameTo)
        {
            string[] str = new string[messeges.Count()];
            int i = 0;

            foreach (var msg in messeges)
            {
                str[i++] = msg;
            }

            return str;
        }

        public int GetId(string username)
        {
            return 0;
        }

        public void AddMsg(string from, string to, string msg)
        {
            messeges.Insert(0, msg);
        }

        public bool HaveMsg(string usr, string userName)
        {
            return false;
        }

        public void DeleteMsg(string fromUser, string toUser)
        {
            return;
        }
    }
}
