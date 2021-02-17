using System.Windows.Controls;

namespace MOBA_Manager.UI
{
    public static class Switcher
    {
        public static MainWindow pageSwitcher;
        public static Frame ingameFrame;

        public static void Switch(Page newPage)
        {
            pageSwitcher.Navigate(newPage);
        }

        public static Frame GetMainFrame()
        {
            return pageSwitcher.MainWindowFrame;
        }

        public static void SwitchIngame(Page newPage)
        {
            ingameFrame.Navigate(newPage);
        }

        public static Frame GetMainIngameFrame()
        {
            return ingameFrame;
        }
    }
}