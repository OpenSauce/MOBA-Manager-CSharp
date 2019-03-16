using MOBA_Manager.src.Settings;
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
using System.Windows.Shapes;

namespace MOBA_Manager
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Window
    {
        private Settings _settings;

        public SettingsPage(Settings _gameSettings)
        {
            this._settings = _gameSettings;
            InitializeComponent();
            SetupWindow(_settings);
        }

        private void SetupWindow(Settings _settings)
        {
            this.Show();
            DisplaySettings(_settings);
        }

        private void DisplaySettings(Settings _settings)
        {

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this._settings.SaveSettings(_settings);
        }
    }
}
