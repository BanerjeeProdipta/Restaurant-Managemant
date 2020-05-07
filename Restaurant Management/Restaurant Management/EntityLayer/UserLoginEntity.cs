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
    class UserLoginEntity
    {
        private string userId;
        private string userPassword;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        
        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }
        


    }
}

