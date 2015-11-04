using System;
using KnowMyCar_POC.Pages.SearchResults;
using Windows.UI.Xaml.Controls;

namespace KnowMyCar_POC.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WelcomePage : Page
    {
        public WelcomePage()
        {
            this.InitializeComponent();
            this.btnSearchCar.Focus(Windows.UI.Xaml.FocusState.Keyboard);
        }

        private void btnSearchCar_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Uri uri = new Uri(@"SearchResults\MainSearchResults.xaml", UriKind.Relative);
            this.Frame.Navigate(typeof(MainSearchResults));
        }

        private void txtCarSearchInput_GotFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            txtCarSearchInput.Text = string.Empty;
            txtCarSearchInput.GotFocus -= txtCarSearchInput_GotFocus;
        }
    }
}
