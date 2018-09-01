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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void userNextButton_Click(object sender, RoutedEventArgs e)
        {
            User player = new User(NameField.GetLineText(0), Int32.Parse(AgeField.GetLineText(0)), true);
            Console.WriteLine("Name: " + player.GetName());
            Console.WriteLine("Age " + player.GetAge());
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
