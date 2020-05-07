using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DataLayer;
using Restaurant_Management.EntityLayer;
using Restaurant_Management.ApplicationLayer;

namespace Restaurant_Management.RepositoryLayer
{
    interface IUserLoginRepository
    {
        bool UserLoginValidation(UserLoginEntity u);
    }
}
