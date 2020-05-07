using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Restaurant_Management.DataLayer;
//using Restaurant_Management.ApplicationLayer;
using Restaurant_Management.RepositoryLayer;
using Restaurant_Management.EntityLayer;

namespace Restaurant_Management.EntityLayer
{
    class ManagerEntity
    {
        private string managerId;
        private string managerName;
        private string mPost;
        private string managerAddress;
        private string managerEmail;
        private string managerPhone;
        private string managerGender;
        private string managerDateOfBirth;
        private string managerJoiningDate;
        private string managerMaritalStatus;
        private string managerBloodGroup;
        private string managerSalary;
        private string managerIdGenerate;

        public string ManagerId
        {
            get { return managerId; }
            set { managerId = value; }
        }
        public string ManagerIdGenerate
        {
            get { return managerIdGenerate; }
            set { managerIdGenerate = "M-" + value.PadLeft(3, '0'); }
        }

        public string MPost
        {
            get { return mPost; }
            set { mPost = value; }
        }

        public string ManagerAddress
        {
            get { return managerAddress; }
            set { managerAddress = value; }
        }

        public string ManagerDateOfBirth
        {
            get { return managerDateOfBirth; }
            set { managerDateOfBirth = value; }
        }
        public string ManagerJoiningDate
        {
            get { return managerJoiningDate; }
            set { managerJoiningDate = value; }
        }

        public string ManagerMaritalStatus
        {
            get { return managerMaritalStatus; }
            set { managerMaritalStatus = value; }
        }
        public string ManagerBloodGroup
        {
            get { return managerBloodGroup; }
            set { managerBloodGroup = value; }
        }
        public string ManagerName
        {
            get { return managerName; }
            set { managerName = value; }
        }
        public string ManagerGender
        {
            get { return managerGender; }
            set { managerGender = value; }
        }

        public string ManagerPhone
        {
            get { return managerPhone; }
            set { managerPhone = value; }
        }
        public string ManagerEmail
        {
            get { return managerEmail; }
            set { managerEmail = value; }
        }

        public string ManagerSalary
        {
            get { return managerSalary; }
            set { managerSalary = value; }
        }

    }
}

