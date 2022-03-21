using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff

    {
        //Good Test Data
        string StaffName = "John Stone";
        string staffUsername = "johnstone3";
        string staffPassword = "password123";
        string staffSalary = "13000";
        string staffRole = "Chef";
        string staffDateAdded = DateTime.Now.Date.ToString();
        
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff staffMember = new clsStaff();
            Assert.IsNotNull(staffMember);

        }

        //Properties

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            Int32 TestData = 442135;
            staffMember.StaffId = TestData;
            Assert.AreEqual(staffMember.StaffId, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            String TestData = "John Stone";
            staffMember.StaffName = TestData;
            Assert.AreEqual(staffMember.StaffName, TestData);
        }

        [TestMethod]
        public void StaffDateAddedPropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            staffMember.StaffDateAdded = TestData;
            Assert.AreEqual(staffMember.StaffDateAdded, TestData);
        }

        [TestMethod]
        public void StaffUsernamePropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            String TestData = "J.Stone23";
            staffMember.StaffUsername = TestData;
            Assert.AreEqual(staffMember.StaffUsername, TestData);
        }

        [TestMethod]
        public void StaffPasswordPropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            String TestData = "password123";
            staffMember.StaffPassword = TestData;
            Assert.AreEqual(staffMember.StaffPassword, TestData);
        }

        [TestMethod]
        public void StaffSalaryPropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            Int32 TestData = 10000;
            staffMember.StaffSalary = TestData;
            Assert.AreEqual(staffMember.StaffSalary, TestData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            String TestData = "Chef";
            staffMember.StaffRole = TestData;
            Assert.AreEqual(staffMember.StaffRole, TestData);
        }

        [TestMethod]
        public void StaffMngrPropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            Boolean TestData = true;
            staffMember.StaffMngr = TestData;
            Assert.AreEqual(staffMember.StaffMngr, TestData);
        }

        //Find Methods

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff staffMember = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 1;
            Found = staffMember.Find(StaffId);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            clsStaff staffMember = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 1;
            Found = staffMember.Find(StaffId);
            if (staffMember.StaffId != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffDateAddedFound()
        {
            clsStaff staffMember = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 3;
            Found = staffMember.Find(StaffId);
            if (staffMember.StaffDateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            clsStaff staffMember = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 1;
            Found = staffMember.Find(StaffId);
            if (staffMember.StaffName != "Test Name")
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffUsernameFound()
        {
            clsStaff staffMember = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 3;
            Found = staffMember.Find(StaffId);
            if (staffMember.StaffUsername != "Test Username")
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffPasswordFound()
        {
            clsStaff staffMember = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 4;
            Found = staffMember.Find(StaffId);
            if (staffMember.StaffPassword != "Test Password")
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffSalaryFound()
        {
            clsStaff staffMember = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 5;
            Found = staffMember.Find(StaffId);
            if (staffMember.StaffSalary != 00000)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffRoleFound()
        {
            clsStaff staffMember = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;
            Found = staffMember.Find(StaffId);
            if (staffMember.StaffRole != "Test Role")
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffMngrFound()
        {
            clsStaff staffMember = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 4;
            Found = staffMember.Find(StaffId);
            if (staffMember.StaffMngr != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffName = "";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");

        }

        public void StaffNameMin()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffName = "a";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffName = "aa";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffName = "aaaaa";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMax()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffName = "aaaaaa";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffName = "aaa"; 
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }

    }
}
