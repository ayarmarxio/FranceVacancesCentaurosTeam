using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using FranceVacancesCentaurosTeam.View;
using FranceVacancesCentaurosTeam.ViewModel;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FranceVacancesCentaurosTeam
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            InitializeComponent();
        }
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            //Frame.Navigate(typeof(SelectPageAccommodation));
        }

       
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SelectPageAccommodation), parameter: "Cannes");
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SelectPageAccommodation), "Chamonix");
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SelectPageAccommodation), "Lyon");
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SelectPageAccommodation), "Nice");
        }
        
       


        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HostPage), "Host");
        }
    }
}
