using MOBA_Manager.DataModel;
using System;
using System.Collections.Generic;

namespace MOBA_Manager.Source.Game
{
    public class PlayerTraining
    {
        private float trainingModifier = 1.02F;

        public PlayerTraining()
        {
        }

        public void AdvanceStats(List<Player> playerList)
        {
            foreach (Player p in playerList)
            {
                int training = (int)Math.Floor(RunTraining(p));
                if (p.CurrentSkill + training > p.PotentialSkill)
                {
                    p.CurrentSkill = p.PotentialSkill;
                }
                else
                {
                    p.CurrentSkill = p.CurrentSkill + training;
                }
            }
        }

        private Double RunTraining(Player p)
        {
            int ageValue = p.Age < 28 && p.Age > 20 ? 2 : -1;
            return 1 + trainingModifier + ageValue + ControlledRandom.RandomNumber(1, 3);
        }
    }
}