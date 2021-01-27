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
            UserBuilder.CreateUser();
        }

        private void BeginButton_Click(object sender, RoutedEventArgs e)
        {
            BuildUser();
            Session newSession = this.sessionBuilder.SetSessionUser(UserBuilder.GetInstance());
            newSession.Start();
        }

        private void BuildUser()
        {
            UserBuilder.WithName(FirstNameBox.Text, LastNameBox.Text);
        }
    }
}