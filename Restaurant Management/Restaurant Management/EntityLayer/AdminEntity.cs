using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Restaurant_Management.DataLayer;
//using Restaurant_Management.ApplicationLayer;
using Restaurant_Management.RepositoryLayer;

namespace Restaurant_Management.EntityLayer
{
    class AdminEntity
    {
        private string adminId;
        private string adminIdGenerate;
        private string adminName;
        private string adminAddress;
        private string adminEmail;
        private string adminPhone;
        private string adminGender;
        private string adminDateOfBirth;
        private string adminJoiningDate;
        private string adminMaritalStatus;
        private string adminBloodGroup;
        private string adminSalary;
        


        public string AdminId
        {
            get { return adminId; }
            set { adminId = value; }
        }

        public string AdminIdGenerate
        {
            get { return adminIdGenerate; }
            set { adminIdGenerate = "A-" + value.PadLeft(2, '0'); }
        }

        public string AdminAddress
        {
            get { return adminAddress; }
            set { adminAddress = value; }
        }

        public string AdminDateOfBirth
        {
            get { return adminDateOfBirth; }
            set { adminDateOfBirth = value; }
        }
        public string AdminJoiningDate
        {
            get { return adminJoiningDate; }
            set { adminJoiningDate = value; }
        }

        public string AdminMaritalStatus
        {
            get { return adminMaritalStatus; }
            set { adminMaritalStatus = value; }
        }
        public string AdminBloodGroup
        {
            get { return adminBloodGroup; }
            set { adminBloodGroup = value; }
        }
        public string AdminName
        {
            get { return adminName; }
            set { adminName = value; }
        }
        public string AdminGender
        {
            get { return adminGender; }
            set { adminGender = value; }
        }

        public string AdminPhone
        {
            get { return adminPhone; }
            set { adminPhone = value; }
        }
        public string AdminEmail
        {
            get { return adminEmail; }
            set { adminEmail = value; }
        }
        public string AdminSalary
        {
            get { return adminSalary; }
            set { adminSalary = value; }
        }



    }
}

