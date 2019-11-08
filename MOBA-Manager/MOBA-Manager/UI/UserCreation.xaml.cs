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
using MOBA_Manager.DataModel;
using MOBA_Manager.Game;

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
