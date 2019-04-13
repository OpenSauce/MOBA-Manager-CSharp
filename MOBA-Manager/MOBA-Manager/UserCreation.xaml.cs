namespace MOBA_Manager
{
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for UserCreation.xaml
    /// </summary>
    public partial class UserCreation : Page
    {
        private User _player;
        private MainWindow _window;

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
            if (!string.IsNullOrEmpty(NameField.Text))
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
