using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Linq;
using System.Data.SqlClient;

namespace MSSQLBase
{
    public class MSSQL : IDataBase
    {
        private DataContext db;

        public MSSQL(DataContext _db)
        {
            db = _db;
        }

        public void AddMsg(string from, string to, string msg)
        {
            db.GetTable<Message>().InsertOnSubmit(new Message() { Id1 = GetId(from), Id2 = GetId(to), Msg = msg });

            db.SubmitChanges();
        }

        public void AddUser(string userName)
        {
            User user = new User { name = userName };

            db.GetTable<User>().InsertOnSubmit(user);
            db.SubmitChanges();
        }

        public void DeleteMsg(string fromUser, string toUser)
        {
            int idFrom = GetId(fromUser);
            int idTo = GetId(toUser);
            
            foreach (var user in db.GetTable<Message>())
            {
                if (user.Id1 == idFrom && user.Id2 == idTo && user.Msg != null)
                    db.GetTable<Message>().DeleteOnSubmit(user);
            }

            db.SubmitChanges();
        }

        public int GetId(string userName)
        {
            int id = 0;

            foreach (var user in db.GetTable<User>())
            {
                if (user.name == userName)
                    id = user.Id;
            }

            return id;
        }

        public string[] GetMsg(string userNameFrom, string userNameTo)
        {
            int idFrom = GetId(userNameFrom);
            int idTo = GetId(userNameTo);

            List<string> lst = new List<string>();

            foreach (var user in db.GetTable<Message>())
            {
                if (user.Id2 == idTo && user.Id1 == idFrom)
                {
                    lst.Add(user.Msg);
                }
            }
            
            DeleteMsg(userNameFrom, userNameTo);

            return lst.ToArray();
        }

        public string[] GetUsers()
        {
            Table<User> users = db.GetTable<User>();

            return users.Select( u => u.name).ToArray();
        }

        public bool HaveMsg(string fromUser, string toUser)
        {
            int idTo = GetId(toUser);
            int idFrom = GetId(fromUser);
            
            foreach (var user in db.GetTable<Message>())
            {
                if (user.Id2 == idTo && user.Id1 == idFrom)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
