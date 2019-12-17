using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceWCF;
using DataBase;
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
        public void TestGetUsrMethod()
        {
            InitializationsTest();
        }

        [TestMethod]
        public void TestConnectMethod()
        {
            InitializationsTest();
        }

        [TestMethod]
        public void TestConstructMethod()
        {
            InitializationsTest();
        }
    }
}
