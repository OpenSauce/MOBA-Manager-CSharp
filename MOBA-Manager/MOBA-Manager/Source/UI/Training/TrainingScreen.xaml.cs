using MOBA_Manager.DataModel;
using MOBA_Manager.Game;
using MOBA_Manager.Source.Game;
using System;
using System.Windows.Controls;

namespace MOBA_Manager.Source.UI.Training
{
    /// <summary>
    /// Interaction logic for TrainingScreen.xaml
    /// </summary>
    public partial class TrainingScreen : Page
    {
        public TrainingScreen()
        {
            InitializeComponent();
            SetupUI();
        }

        private void playerSelected_Click(Player p)
        {
        }

        private void SetupUI()
        {
            Session playerSession = SessionDirector.GetSession();
            TrainingPlayers.Children.Clear();
            foreach (Player p in playerSession.MainPlayer.Team.Roster)
            {
                Console.Write(p.GetFullName());
                PlayerTrainingControl playerTrainingControl = new PlayerTrainingControl(p);
                playerTrainingControl.trainPlayer += playerSelected_Click;
                TrainingPlayers.Children.Add(playerTrainingControl);
            }
        }

        private void TrainButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            new PlayerTraining().AdvanceStats(SessionDirector.GetSession().MainPlayer.Team.Roster);
            SetupUI();
        }

        private void ReturnButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SessionDirector.GetSession().Start();
        }
    }
}