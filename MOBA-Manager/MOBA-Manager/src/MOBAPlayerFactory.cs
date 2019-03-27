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

        public MOBAPlayer generateRandomPlayer()
        {
            iteration += 1;
            return generateRandomPlayer("PlayerName" + iteration);
        }

        public MOBAPlayer generateRandomPlayer(String name)
        {
            int weight = new Random().Next(0, 100);
            return generateRandomPlayer(name, weight);
        }

        public MOBAPlayer generateRandomPlayer(String name, int weight)
        {
            MOBAPlayer player = new MOBAPlayer(name);
            return null;
        }
    }
}
