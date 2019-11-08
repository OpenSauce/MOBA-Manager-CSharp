using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.DataModel
{
    public class PlayerSkill
    {
        private int currentSkill;
        private int potentialSkill;
        private int mentalSkill;
        private int technique;
        private int supportSkill;
        private int carrySkill;
        private int midSkill;
        private int offlaneSkill;

        public PlayerSkill()
        {
            currentSkill = 0;
            potentialSkill = 0;
            mentalSkill = 0;
            technique = 0;
            supportSkill = 0;
            carrySkill = 0;
            midSkill = 0;
            offlaneSkill = 0;
        }

        public int CurrentSkill { get => currentSkill; set => currentSkill = value; }
        public int PotentialSkill { get => potentialSkill; set => potentialSkill = value; }
        public int MentalSkill { get => mentalSkill; set => mentalSkill = value; }
        public int Technique { get => technique; set => technique = value; }
        public int SupportSkill { get => supportSkill; set => supportSkill = value; }
        public int CarrySkill { get => carrySkill; set => carrySkill = value; }
        public int MidSkill { get => midSkill; set => midSkill = value; }
        public int OfflaneSkill { get => offlaneSkill; set => offlaneSkill = value; }

        public PlayerSkill PopulateSkills(int weight)
        { 
            currentSkill = ControlledRandom.RandomNumber(weight, 100) * 2;
            potentialSkill = ControlledRandom.RandomNumber(weight, 100) * 2;
            mentalSkill = ControlledRandom.RandomNumber(weight, 100) / 5;
            technique = ControlledRandom.RandomNumber(weight, 100) / 5;
            supportSkill = ControlledRandom.RandomNumber(weight, 100) / 5;
            carrySkill = ControlledRandom.RandomNumber(weight, 100) / 5;
            midSkill = ControlledRandom.RandomNumber(weight, 100) / 5;
            offlaneSkill = ControlledRandom.RandomNumber(weight, 100) / 5;
            return this;
        }
    }
}
