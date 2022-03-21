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

        public bool Find(int staffId)
        {
            //ERRORS HERE

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", StaffId);
            DB.Execute("sproc_tblStaff_FilterByAddressNo");
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

        public string Valid(string staffName, object staffUsername, object staffPassword, object staffSalary, object staffRole, object staffDateAdded)
        {
            String Error = "";
            if (staffName.Length == 0)
            {
                Error = Error + "The Staff Name may not be blank : ";
            }

            return Error;
        }

    }
}