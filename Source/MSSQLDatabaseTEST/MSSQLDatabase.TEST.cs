using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSSQLDatabaseTEST
{
    [TestClass]
    public class MSSQLDatabaseTEST
    {
        public class EqualString
        {
            private string str;

            public EqualString(string _str)
            {
                str = _str;
            }

            public bool AreEqual(string _str)
            {
                return Equals(str, _str);
            }
        }

        private MSSQLDatabaseTESTDataContext db;

        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        private void InitializationTest()
        {
            db = new MSSQLDatabaseTESTDataContext();
        }

        [TestMethod]
        public void GetId()
        {
            InitializationTest();
            MSSQLBase.MSSQL db1 = new MSSQLBase.MSSQL(db);
            int a = db1.GetId("vadik");

            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void GetMsg()
        {
            InitializationTest();
            MSSQLBase.MSSQL db1 = new MSSQLBase.MSSQL(db);
            string msg1 = RandomString(7);
            string msg2 = RandomString(7);

            //db1.AddMsg("egor", "nikita", msg1);
            //db1.AddMsg("egor", "nikita", msg2);

            string[] str = db1.GetMsg("egor", "nikita");

            List<string> lst = new List<string>();
            foreach (var st in str)
            {
                lst.Add(st);
            }

            EqualString prEqualString = new EqualString(msg1);
            int index = lst.FindIndex(prEqualString.AreEqual);
            int index1 = 0;
            Assert.IsTrue(index1 != -1);
        }


        [TestMethod]
        public void AddUser()
        {
            InitializationTest();
            MSSQLBase.MSSQL db1 = new MSSQLBase.MSSQL(db);
            string str = RandomString(7);

            db1.AddUser(str);
            int a = db1.GetId(str);

            Assert.IsTrue(db1.GetId(str) != 0);
        }


        [TestMethod]
        public void HaveMessage()
        {
            InitializationTest();
            MSSQLBase.MSSQL db1 = new MSSQLBase.MSSQL(db);
            bool a = db1.HaveMsg("vadik", "tema");

            Assert.IsTrue(a);
        }


        [TestMethod]
        public void AddMessage()
        {
            InitializationTest();
            MSSQLBase.MSSQL db1 = new MSSQLBase.MSSQL(db);
            string str = RandomString(7);

            db1.AddMsg("vadik", "ilya", str);
            bool a = db1.HaveMsg("vadik", "ilya");

            Assert.IsTrue(a);
        }


        [TestMethod]
        public void DeleteMessage()
        {
            InitializationTest();
            MSSQLBase.MSSQL db1 = new MSSQLBase.MSSQL(db);
            string str = RandomString(7);

            db1.AddMsg("tema", "ilya", str);
            bool a = db1.HaveMsg("tema", "ilya");
            Assert.IsTrue(a);

            db1.DeleteMsg("tema", "ilya");
            bool b = db1.HaveMsg("tema", "ilya");
            Assert.IsFalse(b);
        }
    }
}