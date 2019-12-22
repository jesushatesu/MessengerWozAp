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
        private dynamic db;

        public MSSQL(dynamic db1)
        {
            Console.WriteLine("Trying to connect BD with ConnectionString...");

            db = db1;

            Console.WriteLine("BD is connected\n");
        }

        public void AddMsg(string from, string to, string msg)
        {
            //WozapDatabaseDataContext db = new WozapDatabaseDataContext();
            
            Message user = new Message();
            user.Id1 = GetId(from);
            user.Id2 = GetId(to);
            user.Msg = msg;

            db.GetTable<Message>().InsertOnSubmit(user);

            db.SubmitChanges();
        }

        public void AddUser(string user)
        {
            //WozapDatabaseDataContext db = new WozapDatabaseDataContext();
            User user1 = new User { name = user };

            db.GetTable<User>().InsertOnSubmit(user1);
            db.SubmitChanges();
        }

        public void DeleteMsg(string fromUser, string toUser)
        {
            int a = GetId(fromUser);
            int b = GetId(toUser);

            //WozapDatabaseDataContext db2 = new WozapDatabaseDataContext();
            foreach (var user in db.GetTable<Message>())
            {
                if (user.Id1 == a && user.Id2 == b && user.Msg != null)
                    db.GetTable<Message>().DeleteOnSubmit(user);
            }

            db.SubmitChanges();
        }

        public int GetId(string username)
        {
            int iden = 0;
            string name = username;

            //WozapDatabaseDataContext db = new WozapDatabaseDataContext();

            foreach (var user in db.GetTable<User>())
            {
                if (user.name == name)
                {
                    iden = user.Id;
                }
            }
            return iden;
        }

        public string[] GetMsg(string userNameFrom, string userNameTo)
        {
            //WozapDatabaseDataContext db = new WozapDatabaseDataContext();

            int a = GetId(userNameFrom);
            int b = GetId(userNameTo);

            int count = 1;
            foreach (var user in db.GetTable<Message>())
            {
                if (user.Id2 == b && user.Id1 == a)
                {
                    count++;
                }
            }
            string[] str = new string[count];
            int i = 0;

            foreach (var user in db.GetTable<Message>())
            {
                if (user.Id2 == b && user.Id1 == a)
                {
                    if (i >= count)
                    {
                        string[] new_str = new string[count + 10];

                        for (int j = 0; j < count; j++)
                            new_str[j] = str[j];

                        count += 10;
                        str = new_str;
                    }
                    str[i++] = user.Msg;
                }
            }

            DeleteMsg(userNameFrom, userNameTo);

            return str;
        }

        public string[] GetUsers()
        {
            //WozapDatabaseDataContext db = new WozapDatabaseDataContext();

            Table<User> users = db.GetTable<User>();
            int max_id = 1;
            int i = 0;
            string[] str = new string[max_id];
            foreach (var user in users)
            {
                if (i >= max_id)
                {
                    string[] new_str = new string[max_id + 1];

                    for (int j = 0; j < max_id; j++)
                        new_str[j] = str[j];

                    max_id += 1;
                    str = new_str;
                }

                str[i++] = user.name;
            }
            return str;
        }

        public bool HaveMsg(string fromUser, string toUser)
        {
            int b = GetId(toUser);
            int a = GetId(fromUser);

            //WozapDatabaseDataContext db2 = new WozapDatabaseDataContext();
            foreach (var user in db.GetTable<Message>())
            {
                if (user.Id2 == b && user.Id1 == a)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
