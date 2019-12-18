using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQLBase
{
    public interface IDataBase
    {
        int GetId(string username);
        void AddUser(string user);

        void AddMsg(string from, string to, string msg);

        string[] GetMsg(string userNameFrom, string userNameTo);

        string[] GetUsers();

        bool HaveMsg(string fromUser, string toUser);

        void DeleteMsg(string fromUser, string toUser);
    }
}
