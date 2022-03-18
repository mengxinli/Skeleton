using System;


namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for active
        private Boolean mRegistStatus;
        //public property for active
        public bool RegistStatus
        {
            get
            {
                //return the private data
                return mRegistStatus;
            }
            set
            {
                //set the private data
                mRegistStatus = value;
            }
        }

        //private date added data member
        private Int32 mUserId;
        //public property for date added
        public int UserId
        {
            get
            {
                //return the private data
                return mUserId;
            }
            set
            {
                //set the private data
                mUserId = value;
            }
        }

        //private data member for the AddressNo property
        private Int32 mPhoneNumber;
        //public property for the address number
        public int PhoneNumber
        {
            get
            {
                //return the private data
                return mPhoneNumber;
            }
            set
            {
                //set the value of the private data member
                mPhoneNumber = value;
            }
        }

        //private data member for county no
        private Int32 mPassWord;
        //public property for county no
        public int PassWord
        {
            get
            {
                //return the private data
                return mPassWord;
            }
            set
            {
                //set the private data
                mPassWord = value;
            }
        }

        //private data member for HouseNo
        private string mUserName;
        //public property for house no
        public string UserName
        {
            get
            {
                //return private data
                return mUserName;
            }
            set
            {
                //set the private data
                mUserName = value;
            }
        }

        //private date added data member
        private DateTime mDateAdded;
        //public property for date added
        public DateTime DateAdded 
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        public bool Find(int UserId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserId", UserId);
            DB.Execute("sproc_tblCustomer_FilterByUserId");
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNumber"]);
                mPassWord = Convert.ToInt32(DB.DataTable.Rows[0]["PassWord"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mRegistStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["RegistStatus"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string userName, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //copy the dateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(dateAdded);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the past : ";
            }
            //check to see if the date is greater than today's date
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future : ";
            }
            //is the town blank
            if (userName.Length == 0)
            {
                //record the error
                Error = Error + "The userName may not be blank : ";
            }
            //if the town is too long
            if (userName.Length > 50)
            {
                //record the error
                Error = Error + "The userName must be less than 50 characters : ";
            }
            //return any error messages
            return Error;

        }

    }
}

