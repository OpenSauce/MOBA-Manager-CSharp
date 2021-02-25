using MOBA_Manager.DataModel;
using MOBA_Manager.Game;
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
            foreach (Player p in playerSession.MainPlayer.Team.Roster)
            {
                Console.Write(p.GetFullName());
                PlayerTrainingControl playerTrainingControl = new PlayerTrainingControl(p);
                playerTrainingControl.trainPlayer += playerSelected_Click;
                TrainingPlayers.Children.Add(playerTrainingControl);
            }
        }
    }
}