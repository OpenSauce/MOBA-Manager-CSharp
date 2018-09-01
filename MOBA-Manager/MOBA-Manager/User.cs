using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager
{

    class User
    {
        private bool created = false;
        private String name;
        private int age;

        public User(String name, int age, bool created)
        {
            this.name = name;
            this.age = age;
            this.created = created;
        }

        public void setName(String name)
        {
            this.name = name;
        }
    }
}
