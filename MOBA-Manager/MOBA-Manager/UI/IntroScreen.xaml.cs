﻿using System;
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