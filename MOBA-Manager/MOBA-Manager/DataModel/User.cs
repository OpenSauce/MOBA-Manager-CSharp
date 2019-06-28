using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.DataModel
{
    public class User : IBaseEntity
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public User()
        {

        }

        public User WithName(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            return this;
        }
    }
}
