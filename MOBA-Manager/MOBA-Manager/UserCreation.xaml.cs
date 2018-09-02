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
    /// Interaction logic for UserCreation.xaml
    /// </summary>
    public partial class UserCreation : Page
    {
        User _player;
        MainWindow _window;

        public UserCreation(MainWindow window)
        {
            InitializeComponent();
            this._window = window;
        }

        private void userNextButton_Click(object sender, RoutedEventArgs e)
        {
            _player = new User(NameField.GetLineText(0), (int)AgeInteger.Value, true);
            _window.CreateTeam(_player);
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
    }
}
