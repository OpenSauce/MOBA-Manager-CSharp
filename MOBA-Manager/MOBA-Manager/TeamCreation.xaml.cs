using MOBA_Manager.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MOBA_Manager
{
    /// <summary>
    /// Interaction logic for TeamCreation.xaml
    /// </summary>
    public partial class TeamCreation : Page
    {
        MainWindow _window;
        User _player;

        public TeamCreation(MainWindow window, User player)
        {
            InitializeComponent();
            //Hardcode some teams
            TeamComboBox.Items.Add("Create Team");
            TeamComboBox.Items.Add("OG");
            TeamComboBox.SelectedIndex = 0;
            this._window = window;
            this._player = player;
        }

        private void userNextButton_Click(object sender, RoutedEventArgs e)
        {
            String teamName;
            if(TeamComboBox.SelectedIndex == 0)
            {
                teamName = TeamNameField.Text;
            }
            else
            {
                teamName = TeamComboBox.Text;
            }
            _player.SetTeam(new Team(teamName));
            SetupTeam(_player);
            GeneratePlayers(_player);
            _window.BeginGame();
        }

        private void GeneratePlayers(User player)
        {

        }

        private void SetupTeam(User player)
        {
            //Hardcode Team
            Team playerTeam = player.GetTeam();
            if(playerTeam.GetTeamName().Equals("OG"))
            {
                Console.WriteLine("Hi2");
                playerTeam.AddPlayer(new MOBAPlayer("N0Tail", playerTeam, 25, "Support", 20000));
                playerTeam.AddPlayer(new MOBAPlayer("Ceb", playerTeam, 25, "Offlane", 20000));
                playerTeam.AddPlayer(new MOBAPlayer("Klaxon", playerTeam, 24, "Mid", 20000));
                playerTeam.AddPlayer(new MOBAPlayer("Jerax", playerTeam, 23, "Support", 20000));
                playerTeam.AddPlayer(new MOBAPlayer("Ana", playerTeam, 24, "Carry", 20000));
            }
        }

        private void TeamComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(TeamComboBox.SelectedIndex != 0)
            {
                NewTeamGrid.Visibility = Visibility.Collapsed;
            } 
            else
            {
                NewTeamGrid.Visibility = Visibility.Visible;
            }
        }
    }
}