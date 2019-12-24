using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceWCF;
using MSSQLBase;
using System.ServiceModel;


namespace Sevice.TEST
{
    [TestClass]
    public class TestConnect
    {
        public MockDataBase db;
        public Service testService;

        private void InitializationsTest()
        {
            db = new MockDataBase();
            testService = new Service(db);
        }

        [TestMethod]
        public void TestConstructorMethod()
        {
            InitializationsTest();
        }

        [TestMethod]
        public void TestGetUsrMethod()
        {
            InitializationsTest();

            Assert.AreEqual(testService.GetUsr().ToArray()[0].Name, "vadik");
        }

        [TestMethod]
        public void TestConnectExistUserMethod()
        {
            InitializationsTest();

            testService.Connect("roma");
            var user = testService.GetUsr().ToArray()[0];

            Assert.AreEqual(user.isConnected, true);
            Assert.AreEqual(user.Name, "roma");
        }

        [TestMethod]
        public void TestConnectNewUserMethod()
        {
            InitializationsTest();

            testService.Connect("snus");

            Assert.AreEqual(testService.GetUsr().ToArray()[0].Name, "snus");
            Assert.AreEqual(testService.GetUsr().ToArray()[0].isConnected, true);
            Assert.AreEqual(db.users.ToArray()[0], "snus");
        }

        [TestMethod]
        public void TestDisconnectMethod()
        {
            InitializationsTest();

            testService.Disconnect("vadik");

            Assert.AreEqual(testService.GetUsr().ToArray()[0].isConnected, false);
        }

        [TestMethod]
        public void TestSendMsgMethod()
        {
            InitializationsTest();

            testService.SendMsg("vadik", "tema","hello");

            Assert.AreEqual(db.messeges.ToArray()[0], "hello");
        }

        [TestMethod]
        public void TestGetMsgMethod()
        {
            InitializationsTest();

            testService.SendMsg("vadik", "tema","hello");
            testService.SendMsg("vadik", "tema","hi");
            testService.SendMsg("vadik", "tema","wozap");

            var str = testService.GetUnsentMsg("vadik", "tema");

            Assert.AreEqual(db.messeges.ToArray()[0], str[0]);
            Assert.AreEqual(db.messeges.ToArray()[1], str[1]);
            Assert.AreEqual(db.messeges.ToArray()[2], str[2]);
        }
    }
}
