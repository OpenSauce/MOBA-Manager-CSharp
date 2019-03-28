using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.src
{
    class MOBAPlayerFactory
    {
        int iteration;

        public MOBAPlayerFactory()
        {
            iteration = 0;
        }

        public List<MOBAPlayer> GenerateRandomPlayers(int number)
        {
            List<MOBAPlayer> list = new List<MOBAPlayer>();
            Random rnd = new Random();
            for (int i = 0; i < number; i++)
            {
                iteration += 1;
                list.Add(GenerateRandomPlayer("PlayerName" + iteration, rnd.Next(0, 100)));
            }
            return list;
        }

        public MOBAPlayer GenerateRandomPlayer()
        {
            iteration += 1;
            return GenerateRandomPlayer("PlayerName" + iteration);
        }

        public MOBAPlayer GenerateRandomPlayer(String name)
        {
            int weight = new Random().Next(0, 100);
            return GenerateRandomPlayer(name, weight);
        }

        public MOBAPlayer GenerateRandomPlayer(String name, int weight)
        {
            MOBAPlayer player = new MOBAPlayer(name)
            {
                PlayerSkill = new MOBAPlayerSkill().PopulateSkills(weight)
            };
            return player;
        }
    }
}
