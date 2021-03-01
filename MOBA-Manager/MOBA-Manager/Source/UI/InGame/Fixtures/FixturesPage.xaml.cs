using MOBA_Manager.Source.DataModel;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MOBA_Manager.Source.UI.InGame.Fixtures
{
    /// <summary>
    /// Interaction logic for FixturesPage.xaml
    /// </summary>
    public partial class FixturesPage : Page
    {
        private List<Fixture> fixturesList;

        public FixturesPage(List<Fixture> fixturesList)
        {
            InitializeComponent();
            this.fixturesList = fixturesList;
            Display();
        }

        private void Display()
        {
            BuyPlayerStackPanel.Children.Clear();
            foreach (Fixture f in fixturesList)
            {
                Console.Write(f);
                FixtureControl buyPlayerControl = new FixtureControl(f);
                BuyPlayerStackPanel.Children.Add(buyPlayerControl);
            }
        }
    }
}