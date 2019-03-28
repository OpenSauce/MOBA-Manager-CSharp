using MOBA_Manager.src;
using MOBA_Manager.src.Settings;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        private PlaySession _session;
        private GameEngine _engine;
        private List<Manager> _managerList;
        private PlayerSearchPage _playerSearchPage;
        private SquadPage _squadPage;
        private ClubPage _clubPage;
        private NewsPage _newsPage;
        private Settings _gameSettings;
        private DateTime _date;

        public DateTime Date { get => _date; set => _date = value; }

        public MainGame(MainWindow window, User player, PlaySession session)
        {
            InitializeComponent();
            this._window = window;
            this._player = player;
            this._session = session;
            SetupGame();
        }

        private void SetupGame()
        {
            this._gameSettings = new Settings().LoadSettings();
            _managerList = CreateManagerList();
            this._engine = new GameEngine(this);
            _engine.SetManagerList(_managerList);
            _engine.SetUser(_player);
            //_engine.SetSession(_session);
            _date = DateTime.Parse("7 June 2019", new CultureInfo("en-GB"));
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
            DateLabel.Content = _date.ToString("dddd\ndd/MM/yy");
        }

        private void GenerateNews()
        {
            _player.AddNews(new NewsPost("Title", "This is the content of the news post"));
        }

        private List<NewsPost> GetNewsPosts()
        {
            return _player.NewsPosts;
        }

        public void SetSquadFrame(Page page)
        {
            SquadFrame.Content = page;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _squadPage = new SquadPage(this);
            _squadPage.PopulateSquadBox(_player.GetTeam());
            SetSquadFrame(_squadPage);
        }

        public PlaySession GetSession()
        {
            return _session;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _newsPage = new NewsPage();
            _newsPage.PopulatePosts(GetNewsPosts());
            SetSquadFrame(_newsPage);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _clubPage = new ClubPage();
            SetSquadFrame(_clubPage);
        }

        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        {
            SettingsPage settings = new SettingsPage(_gameSettings);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _playerSearchPage = new PlayerSearchPage(this);
            _playerSearchPage.PopulateSquadBox(_session.GetPlayerList());
            SetSquadFrame(_playerSearchPage);
        }
    }
}
