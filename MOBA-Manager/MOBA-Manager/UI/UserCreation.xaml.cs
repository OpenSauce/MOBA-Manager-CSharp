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
        public UserCreation()
        {
            InitializeComponent();
        }

        public UserCreation(SessionBuilder sessionBuilder)
        {
            this.sessionBuilder = sessionBuilder;
        }

        private void BeginButton_Click(object sender, RoutedEventArgs e)
        {
            Session newSession = this.sessionBuilder.SetSessionUser(CreateUser());
            newSession.Start();
        }

        private User CreateUser()
        {
            //Check if the user is okay and create the user
            return new User();
        }
    }
}
