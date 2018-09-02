using MOBA_Manager.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager
{

    public class User : Manager
    {
        private bool _created = false;

        public User(String name, int age, bool created)
        {
            this._name = name;
            this._age = age;
            this._created = created;
        }

        public Boolean IsCreated()
        {
            return _created;
        }

    }
}
