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
    /// Interaction logic for MainGame.xaml
    /// </summary>
    public partial class MainGame : Page
    {
        private User _player;
        private MainWindow _window;
        private GameEngine _engine;
        private List<Manager> _managerList;
        private SquadPage _squadPage;
        private NewsPage _newsPage;

        public MainGame(MainWindow window, User player)
        {
            InitializeComponent();
            this._window = window;
            this._player = player;
            _managerList = CreateManagerList();
            this._engine = new GameEngine(this);
            _engine.SetManagerList(_managerList);
            _engine.SetUser(_player);
            Refresh();
        }

        private List<Manager> CreateManagerList()
        {
            List<Manager> list = new List<Manager>();
            return list;
        }

        private void ProceedButton_Click(object sender, RoutedEventArgs e)
        {
            _engine.Proceed();
            Refresh();
        }

        private void Refresh()
        {
            UpdateHeader();
            _newsPage = new NewsPage();
            SquadFrame.Content = _newsPage;
            GenerateNews();
            _newsPage.PopulatePosts(GetNewsPosts());
        }

        private void UpdateHeader()
        {
            NameLabel.Content = "Name: " + _player.GetName();
            TeamLabel.Content = "Team: " + _player.GetTeamName();
            CashLabel.Content = "Cash: " + _player.GetCashString();
        }

        private void GenerateNews()
        {
            _player.AddNews(new NewsPost("Title", "This is the content of the news post"));
        }

        private List<NewsPost> GetNewsPosts()
        {
            return _player.NewsPosts;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _squadPage = new SquadPage();
            _squadPage.PopulateSquadBox(_player.GetTeam());
            SquadFrame.Content = _squadPage;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _newsPage = new NewsPage();
            _newsPage.PopulatePosts(GetNewsPosts());
            SquadFrame.Content = _newsPage;
        }
    }
}
