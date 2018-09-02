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
            this._window = window;
            this._player = player;
        }

        private void NameField_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(NameField.Text))
            {
                userNextButton.IsEnabled = true;
            }
            else
            {
                userNextButton.IsEnabled = false;
            }
        }

        private void userNextButton_Click(object sender, RoutedEventArgs e)
        {
            _player.SetTeam(new Team("Example United"));
            Console.WriteLine("Name: " + _player.GetName());
            Console.WriteLine("Age " + _player.GetAge());
            Console.WriteLine("Team: " + _player.GetTeamName());
            _window.BeginGame();
        }
    }
}
