using FranceVacancesCentaurosTeam.Model;
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
using FranceVacancesCentaurosTeam.View;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FranceVacancesCentaurosTeam
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //private List<apartments> ApartmentList;

        private List<Apartment> Apartments;

        public MainPage()
        {
            this.InitializeComponent();
            Apartments = ApartmentManager.GetApartment();
        }


        
        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CustomerPage));
        }
        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HostPage));
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonBase_OnClick_(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
