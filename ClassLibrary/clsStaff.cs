using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffId;
        public Int32 StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }

        private string mStaffName;
        public string StaffName
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }

        private DateTime mStaffDateAdded;
        public DateTime StaffDateAdded
        {
            get
            {
                return mStaffDateAdded;
            }
            set
            {
                mStaffDateAdded = value;
            }
        }

        private string mStaffUsername;
        public string StaffUsername
        {
            get
            {
                return mStaffUsername;
            }
            set
            {
                mStaffUsername = value;
            }
        }

        private string mStaffPassword;
        public string StaffPassword
        {
            get
            {
                return mStaffPassword;
            }
            set
            {
                mStaffPassword = value;
            }
        }

        private Int32 mStaffSalary;
        public int StaffSalary
        {
            get
            {
                return mStaffSalary;
            }
            set
            {
                mStaffSalary = value;
            }
        }

        private string mStaffRole;
        public string StaffRole
        {
            get
            {
                return mStaffRole;
            }
            set
            {
                mStaffRole = value;
            }
        }

        private Boolean mStaffMngr;
        public bool StaffMngr
        {
            get
            {
                return mStaffMngr;
            }
            set
            {
                mStaffMngr = value;
            }
        }

        public bool Find(int StaffId)
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", StaffId);
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            if (DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffUsername = Convert.ToString(DB.DataTable.Rows[0]["StaffUsername"]);
                mStaffPassword = Convert.ToString(DB.DataTable.Rows[0]["StaffPassword"]);
                mStaffRole = Convert.ToString(DB.DataTable.Rows[0]["StaffRole"]);
                mStaffSalary = Convert.ToInt32(DB.DataTable.Rows[0]["StaffSalary"]);
                mStaffDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDateAdded"]);
                mStaffMngr = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffMngr"]);

                return true;
            }

            else
            {

                return false;
            }
        }

        public string Valid(string staffName, 
                            string staffUsername, 
                            string staffPassword,  
                            string staffSalary,    
                            string staffRole, 
                            string staffDateAdded)
        {
            String Error = "";
            DateTime DateTemp;

            if (staffName.Length == 0)
            {
                Error = Error + "The Staff Name may not be blank : ";
            }

            if (staffName.Length >= 50)
            {
                Error = Error + "The Staff Name must be less than 50 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(staffDateAdded);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            
            if (staffUsername.Length >= 20)
            {
                Error = Error + "Your username must be less than 20 characters : ";
            }

            if (staffUsername.Length == 0)
            {
                Error = Error + "Your username may not be blank : ";
            }

            if (staffPassword.Length == 0)
            {
                Error = Error + "Your password may not be blank : ";
            }
            
            if (staffPassword.Length >= 50)
            {
                Error = Error + "Your password must be less than 50 characters : ";
            }

            if (staffSalary.Length == 0)
            {
                Error = Error + "The Staff Salary may not be blank : ";
            }

            if (staffSalary.Length >= 100)
            {
                Error = Error + "The Staff Salary must be less than 100 digits: ";
            }

            if (staffRole.Length == 0)
            {
                Error = Error + "The Staff Role may not be blank : ";
            }

            if (staffRole.Length >= 20)
            {
                Error = Error + "The Staff Role is too long; must be less than 20 characters: ";
            }

            return Error;
        }

    }
}