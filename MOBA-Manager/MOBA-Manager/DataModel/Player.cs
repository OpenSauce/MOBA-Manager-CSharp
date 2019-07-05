using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.DataModel
{
    public class Player : BaseEntity
    {
        public Player(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
