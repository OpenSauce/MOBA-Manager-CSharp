using System.Windows.Controls;

namespace MOBA_Manager.UI
{
    public static class Switcher
    {
        public static MainWindow pageSwitcher;

        public static void Switch(Page newPage)
        {
            pageSwitcher.Navigate(newPage);
        }

        public static Frame GetMainFrame()
        {
            return pageSwitcher.MainWindowFrame;
        }
    }
}