using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class MOBAPlayerSkill
    {
        private int currentSkill;
        private int potentialSkill;
        private int mentalSkill;
        private int technique;
        private int supportSkill;
        private int carrySkill;
        private int midSkill;
        private int offlaneSkill;

        public MOBAPlayerSkill()
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

    public MOBAPlayerSkill PopulateSkills(int weight)
        {
            Random number = new Random();
            currentSkill = number.Next(weight, 100) * 2;
            potentialSkill = number.Next(weight, 100) * 2;
            mentalSkill = number.Next(weight, 100) / 5;
            technique = number.Next(weight, 100) / 5;
            supportSkill = number.Next(weight, 100) / 5;
            carrySkill = number.Next(weight, 100) / 5;
            midSkill = number.Next(weight, 100) / 5;
            offlaneSkill = number.Next(weight, 100) / 5;
            return this;
        }

    }
