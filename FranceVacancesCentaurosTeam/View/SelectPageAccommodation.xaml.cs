
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FranceVacancesCentaurosTeam.View

{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SelectPageAccommodation : Page
    {
        //private List<Accommodation> Accommodations;
        //private List<Options> accommodation;


        //public SelectPageAccommodation()
        //{
        //    //accommodation = ApartmentManager.GetAccommodation();
        //    Apartments = ApartmentManager.GetApartment();
        //    this.InitializeComponent();
        //    //this.InitializeComponent();


        //}


        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public SelectPageAccommodation()
        {
            
            InitializeComponent();
        }
        //private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        // }
        string selectitem;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                string getdata = e.Parameter.ToString();
                selectitem = getdata;
            }

            if (selectitem.Equals("Cottage"))
            {
                pivotcontrol.SelectedIndex = 1;
            }
            else if (selectitem.Equals("Flat"))
            {
                pivotcontrol.SelectedIndex = 2;
            }
            else if (selectitem.Equals("Villa"))
            {
                pivotcontrol.SelectedIndex = 3;
            }
            else if (selectitem.Equals("Bungalow"))
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
