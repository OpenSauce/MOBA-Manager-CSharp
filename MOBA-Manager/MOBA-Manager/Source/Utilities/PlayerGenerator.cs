using MOBA_Manager.DataModel;
using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;

namespace MOBA_Manager.Game
{
    internal class PlayerGenerator : IPlayerFactory
    {
        private const int MAX_PLAYERS = 100;

        public List<Player> LoadPlayers()
        {
            return GenerateListOfPlayers(new List<Player>());
        }

        private List<Player> GenerateListOfPlayers(List<Player> listOfPlayers)
        {
            PersonNameGenerator _g = new PersonNameGenerator();
            for (int i = 0; i < MAX_PLAYERS; i++)
            {
                listOfPlayers.Add(GenerateNewPlayer(_g.GenerateRandomMaleFirstName(), _g.GenerateRandomMaleFirstName(), _g.GenerateRandomLastName()));
            }
            return listOfPlayers;
        }

        private Player GenerateNewPlayer(String firstName, String lastName)
        {
            return GenerateNewPlayer(firstName, "", lastName);
        }

        private Player GenerateNewPlayer(String firstName, String middleName, String lastName)
        {
            Player generatedPlayer = new Player(firstName, middleName, lastName);
            generatedPlayer.Age = ControlledRandom.RandomNumber(16, 26);
            generatedPlayer.PopulateSkills(ControlledRandom.RandomNumber(1, 200));
            return generatedPlayer;
        }
    }
}