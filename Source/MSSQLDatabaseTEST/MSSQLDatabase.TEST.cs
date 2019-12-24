﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSSQLBase;

namespace MSSQLDatabaseTEST
{
    [TestClass]
    public class MSSQLDatabaseTEST
    {
        private class EqualString
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
        
        private MSSQL db;
        
        private void InitializationTest()
        {
            db = new MSSQL(new MSSQLDatabaseTESTDataContext());
        }

        [TestMethod]
        public void GetIdTest()
        {
            InitializationTest();

            Assert.AreEqual(1, db.GetId("vadik"));
        }

        [TestMethod]
        public void GetMsgTest()
        {
            InitializationTest();

            db.AddMsg("egor", "nikita", "hello");

            Assert.AreNotEqual(-1, db.GetMsg("egor", "nikita").ToList().FindIndex(new EqualString("hello").AreEqual));
        }
        
        [TestMethod]
        public void AddUserTest()
        {
            InitializationTest();

            db.AddUser("anyUser");

            Assert.IsTrue(db.GetId("anyUser") != 0);
        }

        [TestMethod]
        public void HaveMessageTest()
        {
            InitializationTest();

            Assert.IsTrue(db.HaveMsg("vadik", "tema"));
        }

        [TestMethod]
        public void AddMessageTest()
        {
            InitializationTest();

            db.AddMsg("vadik", "ilya", "hello1");

            Assert.IsTrue(db.HaveMsg("vadik", "ilya"));
            db.GetMsg("vadik", "ilya");
        }

        [TestMethod]
        public void DeleteMessageTest()
        {
            InitializationTest();
            db.AddMsg("tema", "ilya", "hello2");

            db.DeleteMsg("tema", "ilya");

            Assert.IsFalse(db.HaveMsg("tema", "ilya"));
        }
    }
}