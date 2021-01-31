using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MOBA_Manager.UI
{
    /// <summary>
    /// Interaction logic for IntoScreen.xaml
    /// </summary>
    public partial class IntroScreen : Page
    {
        public IntroScreen()
        {
            InitializeComponent();
        }

        public IntroScreen(MainWindow window)
        {
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MOBA_Manager.Game.SessionBuilder();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            BeginButton.Content = "Ooo";
        }

        private void BeginButton_MouseLeave(object sender, MouseEventArgs e)
        {
            BeginButton.Content = "Begin";
        }
    }
}