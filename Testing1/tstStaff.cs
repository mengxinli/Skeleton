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
        string StaffUsername = "johnstone3";
        string StaffPassword = "password123";
        string StaffSalary = "13000";
        string StaffRole = "Chef";
        string StaffDateAdded = DateTime.Now.Date.ToString();
        
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
            Int32 StaffId = 2;
            Found = staffMember.Find(StaffId);
            if (staffMember.StaffDateAdded != Convert.ToDateTime("01/03/2022"))
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
            Int32 StaffId = 2;
            Found = staffMember.Find(StaffId);
            if (staffMember.StaffName != "Anne Vaughn")
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
            Int32 StaffId = 1;
            Found = staffMember.Find(StaffId);
            if (staffMember.StaffUsername != "johnstones1")
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
            Int32 StaffId = 2;
            Found = staffMember.Find(StaffId);
            if (staffMember.StaffPassword != "pssword135")
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
            if (staffMember.StaffSalary != 14000)
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
            Int32 StaffId = 5;
            Found = staffMember.Find(StaffId);
            if (staffMember.StaffRole != "Chef")
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

        
        [TestMethod]
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
            StaffName = StaffName.PadRight(49, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }
        
       
        [TestMethod]
        public void StaffNameMax()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffName = StaffName.PadRight(50, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffName = StaffName.PadRight(51, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffName = StaffName.PadRight(25, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffDateAddedExtremeMin()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string StaffDateAdded = TestDate.ToString();
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateAddedMinLessOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string StaffDateAdded = TestDate.ToString();
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateAddedMin()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-16);
            string StaffDateAdded = TestDate.ToString();
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateAddedMinPlusOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string StaffDateAdded = TestDate.ToString();
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateAddedExtremeMax()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string StaffDateAdded = TestDate.ToString();
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateAddedInvalidData()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffDateAdded = "This is not a date!";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffUsernameMinLessOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffUsername = "";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");

        }

        
        [TestMethod]
        public void StaffUsernameMin()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffUsername = "a";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }
        

        
        [TestMethod]
        public void StaffUsernameMinPlusOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffUsername = "aa";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }
        

        
        [TestMethod]
        public void StaffUsernameMaxLessOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffUsername = StaffName.PadRight(49, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }
        

        [TestMethod]
        public void StaffUsernameMax()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffUsername = StaffUsername.PadRight(20, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffUsernameMaxPlusOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffUsername = StaffUsername.PadRight(21, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffUsernameMid()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffUsername = StaffUsername.PadRight(10, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMinLessOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffPassword = "";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");

        }

        
        [TestMethod]
        public void StaffPasswordMin()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffPassword = "a";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }
        

        
        [TestMethod]
        public void StaffPasswordMinPlusOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffPassword = "aa";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }
        

        
        [TestMethod]
        public void StaffPasswordMaxLessOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffPassword = StaffPassword.PadRight(49, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }
        

        [TestMethod]
        public void StaffPasswordMax()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffPassword = StaffPassword.PadRight(50, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxPlusOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffPassword = StaffPassword.PadRight(51, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMid()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffPassword = StaffPassword.PadRight(25, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMinLessOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffSalary = "";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StaffSalaryMin()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffSalary = "a";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffSalaryMinPlusOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffSalary = "aa";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryExtremeMax()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffSalary = StaffSalary.PadRight(100, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffRoleMinLessOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffRole = "";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StaffRoleMin()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffRole = "a";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void StaffRoleMinPlusOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            string StaffRole = "aa";
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void StaffRoleMaxLessOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffRole = StaffRole.PadRight(19, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffRoleMax()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffRole = StaffRole.PadRight(20, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxPlusOne()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffRole = StaffRole.PadRight(21, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMid()
        {
            clsStaff staffMember = new clsStaff();
            String Error = "";
            StaffRole = StaffRole.PadRight(10, 'a');
            Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);
            Assert.AreEqual(Error, "");
        }


    }
}
