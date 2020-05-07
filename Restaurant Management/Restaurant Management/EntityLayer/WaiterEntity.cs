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
    class WaiterEntity
    {
        private string waiterId;
        private string waiterName;
        private string wPost;
        private string waiterAddress;
        private string waiterEmail;
        private string waiterPhone;
        private string waiterGender;
        private string waiterDateOfBirth;
        private string waiterJoiningDate;
        private string waiterMaritalStatus;
        private string waiterBloodGroup;
        private string waiterSalary;
        private string waiterIdGenerate;

        public string WaiterId
        {
            get { return waiterId; }
            set { waiterId = value; }
        }
        public string WaiterIdGenerate
        {
            get { return waiterIdGenerate; }
            set { waiterIdGenerate = "W-" + value.PadLeft(3, '0'); }
        }

        public string WPost
        {
            get { return wPost; }
            set { wPost = value; }
        }

        public string WaiterAddress
        {
            get { return waiterAddress; }
            set { waiterAddress = value; }
        }

        public string WaiterDateOfBirth
        {
            get { return waiterDateOfBirth; }
            set { waiterDateOfBirth = value; }
        }
        public string WaiterJoiningDate
        {
            get { return waiterJoiningDate; }
            set { waiterJoiningDate = value; }
        }

        public string WaiterMaritalStatus
        {
            get { return waiterMaritalStatus; }
            set { waiterMaritalStatus = value; }
        }
        public string WaiterBloodGroup
        {
            get { return waiterBloodGroup; }
            set { waiterBloodGroup = value; }
        }
        public string WaiterName
        {
            get { return waiterName; }
            set { waiterName = value; }
        }
        public string WaiterGender
        {
            get { return waiterGender; }
            set { waiterGender = value; }
        }

        public string WaiterPhone
        {
            get { return waiterPhone; }
            set { waiterPhone = value; }
        }
        public string WaiterEmail
        {
            get { return waiterEmail; }
            set { waiterEmail = value; }
        }

        public string WaiterSalary
        {
            get { return waiterSalary; }
            set { waiterSalary = value; }
        }
       
    }
}

