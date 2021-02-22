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
        private SessionDirector SessionDirector;

        public UserCreation(SessionDirector SessionDirector)
        {
            this.SessionDirector = SessionDirector;
            InitializeComponent();
            //teamCombo.ItemsSource = SessionDirector.GetSession().GetTeamList();
            TeamListBox.ItemsSource = SessionDirector.GetSession().GetTeamList();
            UserBuilder.CreateUser();
        }

        private void BeginButton_Click(object sender, RoutedEventArgs e)
        {
            User gameUser = BuildUser();
            Session newSession = this.SessionDirector.SetSessionUser(gameUser);
            newSession.Start();
        }

        private User BuildUser()
        {
            UserBuilder.WithName(FirstNameBox.Text, LastNameBox.Text);
            UserBuilder.WithTeam((Team)TeamListBox.SelectedItem);
            return UserBuilder.GetInstance();
        }

        private void TeamListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TeamUserControl.SetTeam((Team)TeamListBox.SelectedItem);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new IntroScreen());
        }
    }
}