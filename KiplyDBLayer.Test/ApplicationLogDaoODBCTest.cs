﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KiplyDBLayer;

namespace KiplyDBLayer.Test
{
    [TestClass]
    public class ApplicationLogDaoODBCTest
    {
       // [TestMethod]
       /* public void getAllTest()
        {
            IApplicationLogDao _applicationLogDao = DaoFactory.getApplicationLogDao();
            _applicationLogDao.getAll();
            Assert.IsTrue(true);
        }*/
        [TestMethod]
        public void getByUuid()
        {
            String uuid = "e2883be7-cebd-48fe-9ed0-ebc8ace06682";
            IApplicationLogDao _applicationLogDao = DaoFactory.getApplicationLogDao();
            ApplicationLog applicationLog = _applicationLogDao.getByUuid("e2883be7-cebd-48fe-9ed0-ebc8ace06682");
            Assert.AreEqual(applicationLog.uuid,uuid);
        }   
    }
}
