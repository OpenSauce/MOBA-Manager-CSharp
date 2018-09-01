using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager
{

    class User
    {
        private bool _created = false;
        private String _name;
        private int _age;

        public User(String name, int age, bool created)
        {
            this._name = name;
            this._age = age;
            this._created = created;
        }

        public void SetName(String name)
        {
            this._name = name;
        }

        public String GetName()
        {
            return this._name;
        }

        public int GetAge()
        {
            return this._age;
        }
    }
}
