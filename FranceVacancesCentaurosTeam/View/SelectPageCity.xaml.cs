using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using FranceVacancesCentaurosTeam.Model;
using FranceVacancesCentaurosTeam.View;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FranceVacancesCentaurosTeam.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SelectPageCity : Page
    {
        private List<Apartment> Apartments;
        public SelectPageCity()
        {
            Apartments = ApartmentManager.GetApartment();
            this.InitializeComponent();
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        string selectitem = null;
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
            this.Frame.Navigate(typeof(MainPage));
        }

    }
}
