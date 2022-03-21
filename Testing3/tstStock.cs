using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        public tstStock()
        {
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock clsStock = new clsStock();
            String Error = "";
            Error = clsStock.Valid("", "", "", "", "", "");
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FindStockOK() // dummy
        {
            clsStock clsStock = new clsStock();
            Boolean Found = false;
            Int32 StockID = 1;
            Found = clsStock.Find(StockID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void StockNamePropertyOK()
        {
            clsStock clsStock = new clsStock();
            Int32 TestData = 123;
            clsStock.Id = TestData;
            Assert.AreEqual(clsStock.Id, TestData);

        }


    }
}
