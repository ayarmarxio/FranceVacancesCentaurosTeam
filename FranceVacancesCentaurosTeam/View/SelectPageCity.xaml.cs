using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FranceVacancesCentaurosTeam.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SelectPageCity : Page
    {
        //private List<Accommodation> Apartments;
        //public SelectPageCity()
        //{
        //    Apartments = ApartmentManager.GetApartment();
        //    this.InitializeComponent();
        //}

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        public SelectPageCity()
        {

            InitializeComponent();
        }

        string selectitem;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                string getdata = e.Parameter.ToString();
                selectitem = getdata;
            }

            if (selectitem.Equals("Cannes"))
            {
                pivotcontrol.SelectedIndex = 1;
            }
            else if (selectitem.Equals("Chamonix"))
            {
                pivotcontrol.SelectedIndex = 2;
            }
            else if (selectitem.Equals("Lyon"))
            {
                pivotcontrol.SelectedIndex = 3;
            }
            else if (selectitem.Equals("Nice"))
            {
                pivotcontrol.SelectedIndex = 4;
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}

