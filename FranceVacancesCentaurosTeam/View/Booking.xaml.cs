﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FranceVacancesCentaurosTeam.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Booking : Page
    {
        public Booking()
        {
            this.InitializeComponent();
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(Invoice), "Invoice");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), "Home");
        }


    }
}
