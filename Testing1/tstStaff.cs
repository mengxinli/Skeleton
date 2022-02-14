using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff

    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff staffMember = new clsStaff();
            Assert.IsNotNull(staffMember);

        }
    }
}
