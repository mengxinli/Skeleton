using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //
            }
        }

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffUsername", mThisStaff.StaffUsername);
            DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@StaffDateAdded", mThisStaff.StaffDateAdded);
            DB.AddParameter("@StaffMngr", mThisStaff.StaffMngr);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffUsername", mThisStaff.StaffUsername);
            DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@StaffDateAdded", mThisStaff.StaffDateAdded);
            DB.AddParameter("@StaffMngr", mThisStaff.StaffMngr);

            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByStaffUsername(string StaffUsername)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffUsername", StaffUsername);
            DB.Execute("sproc_tblStaff_FilterByStaffUsername");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff staffMember = new clsStaff();

                staffMember.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                staffMember.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                staffMember.StaffUsername = Convert.ToString(DB.DataTable.Rows[Index]["StaffUsername"]);
                staffMember.StaffPassword = Convert.ToString(DB.DataTable.Rows[Index]["StaffPassword"]);
                staffMember.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                staffMember.StaffSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffSalary"]);
                staffMember.StaffDateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDateAdded"]);
                staffMember.StaffMngr = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffMngr"]);

                mStaffList.Add(staffMember);
                Index++;
            }
        }
    }
}