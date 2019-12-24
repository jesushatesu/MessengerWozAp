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
        private MockDataBase db;
        private Service testService;

        [TestInitialize]
        public void InitializationsTest()
        {
            db = new MockDataBase();
            testService = new Service(db);
        }

        [TestMethod]
        public void TestConstructorMethod()
        {
            //не пустой, тут запускается конструктор из метода InitializationsTest()
        }

        [TestMethod]
        public void TestGetUsrMethod()
        {
            Assert.AreEqual(testService.GetUsr().ToArray()[0].Name, "vadik");
        }

        [TestMethod]
        public void TestConnectExistUserMethod()
        {
            testService.Connect("roma");
            var user = testService.GetUsr().ToArray()[0];

            Assert.AreEqual(user.isConnected, true);
            Assert.AreEqual(user.Name, "roma");
        }

        [TestMethod]
        public void TestConnectNewUserMethod()
        {
            testService.Connect("snus");

            Assert.AreEqual(testService.GetUsr().ToArray()[0].Name, "snus");
            Assert.AreEqual(testService.GetUsr().ToArray()[0].isConnected, true);
            Assert.AreEqual(db.users.ToArray()[0], "snus");
        }

        [TestMethod]
        public void TestDisconnectMethod()
        {
            testService.Disconnect("vadik");

            Assert.AreEqual(testService.GetUsr().ToArray()[0].isConnected, false);
        }

        [TestMethod]
        public void TestSendMsgMethod()
        {
            testService.SendMsg("vadik", "tema","hello");

            Assert.AreEqual(db.messeges.ToArray()[0], "hello");
        }

        [TestMethod]
        public void TestGetMsgMethod()
        {
            testService.SendMsg("vadik", "tema","hello");

            var str = testService.GetUnsentMsg("vadik", "tema");

            Assert.AreEqual(db.messeges.ToArray()[0], str[0]);
        }
    }
}
