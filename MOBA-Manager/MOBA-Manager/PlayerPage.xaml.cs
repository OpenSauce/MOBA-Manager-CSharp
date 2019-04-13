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
        private Page _parent;

        private PlayerPage()
        {
            InitializeComponent();
        }

        public PlayerPage(Page parent, MOBAPlayer player)
        {
            InitializeComponent();
            this._parent = parent;
            this._player = player;
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
            if(_parent is SquadPage)
            {
                ((SquadPage) _parent).ReturnPage();
            } else
            {
                ((PlayerSearchPage) _parent).ReturnPage();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((SquadPage)_parent).Window.SetSquadFrame(new PlayerOptionsPage(_player));
        }
    }
}
