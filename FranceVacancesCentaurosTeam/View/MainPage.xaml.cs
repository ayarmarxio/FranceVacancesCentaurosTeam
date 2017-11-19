﻿using System;
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
using FranceVacancesCentaurosTeam.ViewModel;
using FranceVacancesCentaurosTeam.Model;


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
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            //Frame.Navigate(typeof(SelectPageAccommodation));
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MyApartmentSplitView.IsPaneOpen = !MyApartmentSplitView.IsPaneOpen;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SelectPageCity), "Cannes");
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SelectPageCity), "Chamonix");
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SelectPageCity), "Lyon");
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SelectPageCity), "Nice");
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SelectPageAccommodation), "Cottage");
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SelectPageAccommodation), "Flat");
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SelectPageAccommodation), "Villa");
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SelectPageAccommodation), "Bungalow");
        }

        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HostPage));
        }



        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DisplayLogin.IsPaneOpen = !DisplayLogin.IsPaneOpen;
            if (DisplayLogin.IsPaneOpen)
            {
                Arrow.Content = "6";
            }
        }

        private void DisplayLogin_PaneClosed(SplitView sender, object args)
        {
            Arrow.Content = "5";
        }
    }
}
