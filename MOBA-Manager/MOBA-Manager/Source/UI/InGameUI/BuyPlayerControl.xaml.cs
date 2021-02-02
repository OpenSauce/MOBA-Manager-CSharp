using MOBA_Manager.DataModel;
using System.Windows.Controls;

namespace MOBA_Manager.Source.UI.InGameUI
{
    /// <summary>
    /// Interaction logic for BuyPlayerControl.xaml
    /// </summary>
    public partial class BuyPlayerControl : UserControl
    {
        public BuyPlayerControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public Player ControlPlayer { get; set; }
    }
}