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
        public string playerRating { get; set; }
        public string role { get; set; }
        public int midSkill { get; set; }
        public int supportSkill { get; set; }
        public int offlaneSkill { get; set; }
        public int carrySkill { get; set; }

        public Player(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public String GetPlayerRating()
        {
            return Math.Abs(skillset.CurrentSkill / 40).ToString();
        }

        public void SetSkillset(PlayerSkill skillset)
        {
            this.skillset = skillset;
            this.playerRating = GetPlayerRating();
            this.midSkill = skillset.MidSkill;
            this.supportSkill = skillset.SupportSkill;
            this.carrySkill = skillset.CarrySkill;
            this.offlaneSkill = skillset.OfflaneSkill;
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.GetPlayerRating();
        }
    }
}
