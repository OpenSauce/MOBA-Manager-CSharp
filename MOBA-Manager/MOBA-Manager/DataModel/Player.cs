using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.DataModel
{
    public class Player : BaseEntity
    {
        private PlayerSkill skillset;

        public Player(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void SetSkillset(PlayerSkill skillset)
        {
            this.skillset = skillset;
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
