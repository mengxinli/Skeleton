using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();

            TestItem.StaffMngr = true;
            TestItem.StaffId = 1;
            TestItem.StaffName = "Tyreece Allman";
            TestItem.StaffUsername = "tyreecemngr01";
            TestItem.StaffPassword = "tmngr1234";
            TestItem.StaffSalary = 17000;
            TestItem.StaffRole = "Manager";
            TestItem.StaffDateAdded = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();

            TestStaff.StaffMngr = true;
            TestStaff.StaffId = 1;
            TestStaff.StaffName = "Tyreece Allman";
            TestStaff.StaffUsername = "tyreecemngr01";
            TestStaff.StaffPassword = "tmngr1234";
            TestStaff.StaffSalary = 17000;
            TestStaff.StaffRole = "Manager";
            TestStaff.StaffDateAdded = DateTime.Now.Date;

            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            
            TestItem.StaffMngr = true;
            TestItem.StaffId = 1;
            TestItem.StaffName = "Tyreece Allman";
            TestItem.StaffUsername = "tyreecemngr01";
            TestItem.StaffPassword = "tmngr1234";
            TestItem.StaffSalary = 17000;
            TestItem.StaffRole = "Manager";
            TestItem.StaffDateAdded = DateTime.Now.Date;
            
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
           
            TestItem.StaffMngr = true;
            TestItem.StaffId = 4;
            TestItem.StaffName = "Tyreece Allman";
            TestItem.StaffUsername = "tyreecemngr01";
            TestItem.StaffPassword = "tmngr1234";
            TestItem.StaffSalary = 17000;
            TestItem.StaffRole = "Manager";
            TestItem.StaffDateAdded = DateTime.Now.Date;
           
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.StaffMngr = true;
            TestItem.StaffId = 1;
            TestItem.StaffName = "Tyreece Allman";
            TestItem.StaffUsername = "tyreecemngr01";
            TestItem.StaffPassword = "tmngr1234";
            TestItem.StaffSalary = 17000;
            TestItem.StaffRole = "Manager";
            TestItem.StaffDateAdded = DateTime.Now.Date;

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;

            TestItem.StaffMngr = false;
            TestItem.StaffId = 3;
            TestItem.StaffName = "Lukaku Lakaka";
            TestItem.StaffUsername = "lakakatopstriker";
            TestItem.StaffPassword = "chelsstriker";
            TestItem.StaffSalary = 11000;
            TestItem.StaffRole = "Chef";
            TestItem.StaffDateAdded = DateTime.Now.Date;

            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.StaffMngr = true;
            TestItem.StaffId = 1;
            TestItem.StaffName = "Tyreece Allman";
            TestItem.StaffUsername = "tyreecemngr01";
            TestItem.StaffPassword = "tmngr1234";
            TestItem.StaffSalary = 17000;
            TestItem.StaffRole = "Manager";
            TestItem.StaffDateAdded = DateTime.Now.Date;

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByStaffUsernameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByStaffUsername("");
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByStaffUsername("xxxxxxxxx");
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffUsernameTestDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaff.ReportByStaffUsername("yyyyyyyyy");
            if (FilteredStaff.Count == 2)
            {
                if (FilteredStaff.StaffList[0].StaffId != 5)
                {
                    OK = false;
                }
                if (FilteredStaff.StaffList[1].StaffId != 6)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
