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
    /// Interaction logic for SquadPage.xaml
    /// </summary>
    public partial class SquadPage : Page
    {
        public SquadPage()
        {
            InitializeComponent();
        }

        public void PopulateSquadBox(Team team)
        {
            foreach (var MOBAPlayer in team.GetSquad())
            {
                var row = new {Name = MOBAPlayer.Nickname, Age = MOBAPlayer.Age, Role = MOBAPlayer.Role, Salary = MOBAPlayer.Salary};
                SquadListView.Items.Add(row);
            }
        }

        private void SquadListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
