using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    class tstStock
    {

        [TestMethod]
        public void FindStockOK()
        {
            clsStock clsStock = new clsStock();
            Boolean Found = false;
            Int32 StockID = 1;
            Found = clsStock.Find(StockID);
            Assert.IsTrue(Found);
        }
    }
    
}
