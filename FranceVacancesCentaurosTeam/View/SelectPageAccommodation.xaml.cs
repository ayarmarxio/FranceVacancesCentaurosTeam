
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
    public sealed partial class SelectPageAccommodation : Page
    {
        private List<Apartment> Apartments;
        private List<Options> accommodation;


        public SelectPageAccommodation()
        {
            //accommodation = ApartmentManager.GetAccommodation();
            Apartments = ApartmentManager.GetApartment();
            this.InitializeComponent();
            //this.InitializeComponent();
            

        }
       

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
