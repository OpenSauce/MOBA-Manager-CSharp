using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOBA_Manager.DataModel;

namespace MOBA_Manager.Game
{
    class UserBuilder
    {

        public User CreateUser(string firstName, string lastName)
        {
            return new User().WithName(firstName, lastName);
        }
    }
}
