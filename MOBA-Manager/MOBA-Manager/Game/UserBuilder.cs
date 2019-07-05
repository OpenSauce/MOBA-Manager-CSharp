using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOBA_Manager.DataModel;

namespace MOBA_Manager.Game
{
    static class UserBuilder
    {
        //Singleton?
        private static User onlyUser = null;

        public static User CreateUser()
        {
            if(onlyUser == null)
            {
                onlyUser = new User();
                return onlyUser;
            } else
            {
                throw new Exception();
            }
        }

        public static User GetInstance()
        {
            return onlyUser;
        }

        public static User WithName(string firstName, string lastName)
        {
            onlyUser.SetFullName(firstName, lastName);
            return onlyUser;
        }
    }
}
