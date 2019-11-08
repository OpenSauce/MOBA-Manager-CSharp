using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.DataModel
{
    public class Player : BaseEntity
    {
        private int currentSkill;
        private int potentialSkill;
        private int mentalSkill;
        private int technique;
        private int supportSkill;
        private int carrySkill;
        private int midSkill;
        private int offlaneSkill;
        public int CurrentSkill { get => currentSkill; set => currentSkill = value; }
        public int PotentialSkill { get => potentialSkill; set => potentialSkill = value; }
        public int MentalSkill { get => mentalSkill; set => mentalSkill = value; }
        public int Technique { get => technique; set => technique = value; }
        public int SupportSkill { get => supportSkill; set => supportSkill = value; }
        public int CarrySkill { get => carrySkill; set => carrySkill = value; }
        public int MidSkill { get => midSkill; set => midSkill = value; }
        public int OfflaneSkill { get => offlaneSkill; set => offlaneSkill = value; }

        public Player(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void PopulateSkills(int weight)
        {
            currentSkill = ControlledRandom.RandomNumber(0, weight);
            potentialSkill = ControlledRandom.RandomNumber(0, weight) - (currentSkill / 2);


            mentalSkill = ControlledRandom.RandomNumber(0, currentSkill / 2) /5;
            technique = ControlledRandom.RandomNumber(0, currentSkill / 2) / 5;
            supportSkill = ControlledRandom.RandomNumber(0, currentSkill / 2) / 5;
            carrySkill = ControlledRandom.RandomNumber(0, currentSkill / 2) / 5;
            midSkill = ControlledRandom.RandomNumber(0, currentSkill / 2) / 5;
            offlaneSkill = ControlledRandom.RandomNumber(0, currentSkill / 2) / 5;
        }

        public int GetPlayerRating()
        {
            return Math.Abs(CurrentSkill / 40);
        }


        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
