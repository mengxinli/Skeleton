
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(CustomerMember);
        }

        [TestMethod]
        public void RegistStatusOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            CustomerMember.RegistStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(CustomerMember.RegistStatus, TestData);
        }

        [TestMethod]
        public void UserIdOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //create some test data
            Int32 TestData = 123456;
            //assign the data to the property
            CustomerMember.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(CustomerMember.UserId, TestData);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //create some test data
            Int32 TestData = 123456;
            //assign the data to the property
            CustomerMember.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(CustomerMember.PhoneNumber, TestData);
        }

        [TestMethod]
        public void PassWordOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //create some test data
            Int32 TestData = 123456;
            //assign the data to the property
            CustomerMember.PassWord = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(CustomerMember.PassWord, TestData);
        }

        [TestMethod]
        public void UserNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //create some test data
            string TestData = "Michael Jordan";
            //assign the data to the property
            CustomerMember.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(CustomerMember.UserName, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            CustomerMember.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(CustomerMember.DateAdded, TestData);
        }

        //---------------------------------------------------------------------------------------FindMethod
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 UserId = 21;
            //invoke the method
            Found = CustomerMember.Find(UserId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 21;
            //invoke the method
            Found = CustomerMember.Find(UserId);
            //check the address no
            if (CustomerMember.UserId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 21;
            //invoke the method
            Found = CustomerMember.Find(UserId);
            //check the property
            if (CustomerMember.PhoneNumber != 185884)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPassWordFound()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 21;
            //invoke the method
            Found = CustomerMember.Find(UserId);
            //check the property
            if (CustomerMember.PassWord != 63101)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 21;
            //invoke the method
            Found = CustomerMember.Find(UserId);
            //check the property
            if (CustomerMember.UserName != "XXX XXX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRegistStatus()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 21;
            //invoke the method
            Found = CustomerMember.Find(UserId);
            //check the property
            if (CustomerMember.RegistStatus != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 21;
            //invoke the method
            Found = CustomerMember.Find(UserId);
            //check the property
            if (CustomerMember.DateAdded != Convert.ToDateTime("2004/4/4"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //-------------------------------------------------------------------------------------------DateAddedValid

        string UserName = "aaa aaa";
        string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = CustomerMember.Valid(UserName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = CustomerMember.Valid(UserName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = CustomerMember.Valid(UserName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = CustomerMember.Valid(UserName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = CustomerMember.Valid(UserName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //----------------------------------------------------------------------------------------------------UserNameValid

        [TestMethod]
        public void UserNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string UserName = "";
            //invoke the method
            Error = CustomerMember.Valid(UserName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string UserName = "a";
            //invoke the method
            Error = CustomerMember.Valid(UserName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string UserName = "aa";
            //invoke the method
            Error = CustomerMember.Valid(UserName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void UserNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string UserName = "";
            UserName = UserName.PadRight(49, 'a');
            //invoke the method
            Error = CustomerMember.Valid(UserName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string UserName = "";
            UserName = UserName.PadRight(50, 'a');
            //invoke the method
            Error = CustomerMember.Valid(UserName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string UserName = "";
            UserName = UserName.PadRight(51, 'a');
            //invoke the method
            Error = CustomerMember.Valid(UserName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void UserNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string UserName = "";
            UserName = UserName.PadRight(25, 'a');
            //invoke the method
            Error = CustomerMember.Valid(UserName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



    }
}