using MOBA_Manager.DataModel;
using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Media.Imaging;

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
            generatedPlayer.IconIndex = GetPlayerPortrait(true);
            return generatedPlayer;
        }

        public static BitmapImage GetPlayerPortrait(bool male)
        {
            BitmapImage bi = new BitmapImage();
            // BitmapImage.UriSource must be in a BeginInit/EndInit block.
            bi.BeginInit();
            bi.UriSource = new Uri(@"\Assets\Pixel Portraits\male_01.png", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            return bi;
        }
    }
}