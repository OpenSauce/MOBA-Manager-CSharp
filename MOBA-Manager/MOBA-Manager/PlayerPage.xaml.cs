using MOBA_Manager.src;
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
    /// Interaction logic for PlayerPage.xaml
    /// </summary>
    public partial class PlayerPage : Page
    {
        private MOBAPlayer _player;
        private SquadPage _squadParent;
        private PlayerSearchPage _searchParent;

        private PlayerPage()
        {
            InitializeComponent();
        }

        public PlayerPage(SquadPage parent, MOBAPlayer player)
        {
            InitializeComponent();
            this._squadParent = parent;
            this._searchParent = null;
            this._player = player;
            LoadPlayerDetails(_player);
        }

        public PlayerPage(PlayerSearchPage parent, MOBAPlayer player)
        {
            InitializeComponent();
            this._player = player;
            this._searchParent = parent;
            this._squadParent = null;
            LoadPlayerDetails(_player);
        }

        private void LoadPlayerDetails(MOBAPlayer player)
        {
            playerNameLabel.Content = _player.Nickname;
            CurrentSkillLabel.Content = player.PlayerSkill.CurrentSkill;
            PotentialSkillLabel.Content = player.PlayerSkill.PotentialSkill;
            MentalSkillLabel.Content = player.PlayerSkill.MentalSkill;
            TechniqueLabel.Content = player.PlayerSkill.Technique;
            SupportSkillLabel.Content = player.PlayerSkill.SupportSkill;
            CarrySkillLabel.Content = player.PlayerSkill.CarrySkill;
            MidSkillLevel.Content = player.PlayerSkill.MidSkill;
            OfflaneSkillLabel.Content = player.PlayerSkill.OfflaneSkill;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if(_searchParent != null)
            {
                _searchParent.ReturnPage();
            } else
            {
                _squadParent.ReturnPage();
            }
        }
    }
}
