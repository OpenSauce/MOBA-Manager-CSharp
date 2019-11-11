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
        private int playerRating;
        public int CurrentSkill { get => currentSkill; set => currentSkill = value; }
        public int PotentialSkill { get => potentialSkill; set => potentialSkill = value; }
        public int MentalSkill { get => mentalSkill; set => mentalSkill = value; }
        public int Technique { get => technique; set => technique = value; }
        public int SupportSkill { get => supportSkill; set => supportSkill = value; }
        public int CarrySkill { get => carrySkill; set => carrySkill = value; }
        public int MidSkill { get => midSkill; set => midSkill = value; }
        public int OfflaneSkill { get => offlaneSkill; set => offlaneSkill = value; }
        public int PlayerRating { get => playerRating; set => playerRating = value; }

        public Player(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Player(string firstName, string middleName, string lastName)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        public void PopulateSkills(int weight)
        {
            currentSkill = ControlledRandom.RandomNumber(0, weight);
            potentialSkill = weight;


            mentalSkill = ControlledRandom.RandomNumber((currentSkill /2), (weight / 2)) /5;
            technique = ControlledRandom.RandomNumber((currentSkill / 2), (weight / 2)) / 5;
            supportSkill = ControlledRandom.RandomNumber((currentSkill / 2), (weight / 2)) / 5;
            carrySkill = ControlledRandom.RandomNumber((currentSkill / 2), (weight / 2)) / 5;
            midSkill = ControlledRandom.RandomNumber((currentSkill / 2), (weight / 2)) / 5;
            offlaneSkill = ControlledRandom.RandomNumber((currentSkill / 2), (weight / 2)) / 5;
            this.playerRating = GetPlayerRating();
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
