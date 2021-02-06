using MOBA_Manager.DataModel;
using MOBA_Manager.Game;
using System.Windows;
using System.Windows.Controls;

namespace MOBA_Manager.UI
{
    /// <summary>
    /// Interaction logic for UserCreation.xaml
    /// </summary>
    public partial class UserCreation : Page
    {
        private SessionBuilder sessionBuilder;

        public UserCreation(SessionBuilder sessionBuilder)
        {
            this.sessionBuilder = sessionBuilder;
            InitializeComponent();
            teamCombo.ItemsSource = sessionBuilder.GetSession().GetTeamList();
            UserBuilder.CreateUser();
        }

        private void BeginButton_Click(object sender, RoutedEventArgs e)
        {
            User gameUser = BuildUser();
            Session newSession = this.sessionBuilder.SetSessionUser(gameUser);
            newSession.Start();
        }

        private User BuildUser()
        {
            UserBuilder.WithName(FirstNameBox.Text, LastNameBox.Text);
            //UserBuilder.WithTeam();
            return UserBuilder.GetInstance();
        }
    }
}