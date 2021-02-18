using System.Windows.Controls;

namespace MOBA_Manager.UI
{
    public static class Switcher
    {
        public static MainWindow pageSwitcher;
        public static Frame ingameFrame;
        private static Page previousMainPage;
        private static Page previousIngamePage;

        public static void Switch(Page newPage)
        {
            previousMainPage = pageSwitcher.MainWindowFrame.Content != null ? pageSwitcher.MainWindowFrame.Content as Page : newPage;
            pageSwitcher.Navigate(newPage);
        }

        public static void SwitchIngame(Page newPage)
        {
            previousIngamePage = ingameFrame.Content != null ? ingameFrame.Content as Page : newPage;
            ingameFrame.Navigate(newPage);
        }

        public static Frame GetMainFrame()
        {
            return pageSwitcher.MainWindowFrame;
        }

        public static Frame GetMainIngameFrame()
        {
            return ingameFrame;
        }

        public static void NavigatePreviousIngame()
        {
            ingameFrame.Navigate(previousIngamePage);
        }

        public static void NavigatePrevious()
        {
            pageSwitcher.Navigate(previousMainPage);
        }
    }
}