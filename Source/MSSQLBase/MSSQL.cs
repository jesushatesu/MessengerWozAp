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
        private readonly string _connectionString;

        public MSSQL()
        {
            Console.WriteLine("Trying to connect BD with ConnectionString...");

            _connectionString = ConfigurationManager.ConnectionStrings["DatabaseMSSQL"].ConnectionString;
            // _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JesusHatesU\Desktop\MessengerWozAp\Build\DatabaseMSSQL.mdf;Integrated Security=True";

            var connection = new SqlConnection(_connectionString);
            connection.Open();

            Console.WriteLine("BD is connected\n");
        }

        public void AddMsg(string from, string to, string msg)
        {
            DatabaseMSSQLDataContext db = new DatabaseMSSQLDataContext(_connectionString);

            int ida = GetId(from);
            int idb = GetId(to);
            Message user12 = new Message { Id1 = ida, Id2 = idb, Msg = msg };
            Console.WriteLine("Сообщение сформировано в структуру для отправления в БД!!!!");
            db.GetTable<Message>().InsertOnSubmit(user12);
            Console.WriteLine("Структура улетела в БД!!!!");
            db.SubmitChanges();
            Console.WriteLine("Изменения в БД подтверждены!!!!");
        }

        public void AddUser(string user)
        {
            DatabaseMSSQLDataContext db = new DatabaseMSSQLDataContext(_connectionString);
            User user1 = new User { name = user };

            db.GetTable<User>().InsertOnSubmit(user1);
            db.SubmitChanges();
        }

        public void DeleteMsg(string fromUser, string toUser)
        {
            int a = GetId(fromUser);
            int b = GetId(toUser);

            DatabaseMSSQLDataContext db2 = new DatabaseMSSQLDataContext(_connectionString);
            foreach (var user in db2.GetTable<Message>())
            {
                if (user.Id1 == a && user.Id2 == b && user.Msg != null)
                    db2.GetTable<Message>().DeleteOnSubmit(user);

                db2.SubmitChanges();
            }
        }

        public int GetId(string username)
        {
            int iden = 0;
            string name = username;

            DatabaseMSSQLDataContext db = new DatabaseMSSQLDataContext(_connectionString);

            foreach (var user in db.GetTable<User>().OrderByDescending(u => u.Id))
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
            DatabaseMSSQLDataContext db = new DatabaseMSSQLDataContext(_connectionString);

            int a = GetId(userNameFrom);
            int b = GetId(userNameTo);

            int count = 0;
            foreach (var user in db.GetTable<Message>().OrderByDescending(u => u.Id2))
            {
                if (user.Id2 == b && user.Id1 == a)
                {
                    count++;
                }
            }
            string[] str = new string[count];
            int i = 0;

            foreach (var user in db.GetTable<Message>().OrderByDescending(u => u.Id1))
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
            DatabaseMSSQLDataContext db = new DatabaseMSSQLDataContext(_connectionString);

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

            DatabaseMSSQLDataContext db2 = new DatabaseMSSQLDataContext(_connectionString);
            foreach (var user in db2.GetTable<Message>().OrderByDescending(u => u.Id2))
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
