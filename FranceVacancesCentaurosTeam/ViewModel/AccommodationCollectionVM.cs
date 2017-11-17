using FranceVacancesCentaurosTeam.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FranceVacancesCentaurosTeam.View;


namespace FranceVacancesCentaurosTeam.ViewModel
{
    class AccommodationCollectionVM
    {
        private Accommodation _selectedItem;
                
        public ObservableCollection<Accommodation> Accommodation { get; set; }
        public ObservableCollection<Accommodation> filteredCottages { get; set; }

        public ObservableCollection<Accommodation> filteredFlat { get; set; }
        public ObservableCollection<Accommodation> filteredBungalow { get; set; }
        public ObservableCollection<Accommodation> filteredVilla { get; set; }

        public Accommodation SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
            }
        }
        

        public AccommodationCollectionVM()
        {
            Accommodation = new ObservableCollection<Accommodation>
            {
                 new Accommodation ("Flat", "$350", "ms-appx:///Assets/Apartment/cannes1aMain.jpg","Cannes", "Beautiful house description", "1" ),
                 new Accommodation("Flat", "$360", "ms-appx:///Assets/Apartment/cannes2aMain.jpg", "Cannes", "Beautiful house description", "2"),
                 new Accommodation ("Cottage", "$455", "ms-appx:///Assets/Apartment/chamonix1aMain.jpg","Chamonix", "Beautiful house description", "3"),
                 new Accommodation ("Cottage", "$550", "ms-appx:///Assets/Apartment/chamonix2aMain.jpg","Chamonix", "Beautiful house description", "4"),
                 new Accommodation ("Flat", "$450", "ms-appx:///Assets/Apartment/lyon1aMain.jpg","Lyon", "Beautiful house description", "5"),
                 new Accommodation ("Flat", "$570", "ms-appx:///Assets/Apartment/lyon2a.jpg","Lyon", "Beautiful house description", "6"),
                 new Accommodation ("Flat", "$380", "ms-appx:///Assets/Apartment/nice1Main.jpg","Nice", "Beautiful house description", "7"),
                 new Accommodation ("Flat", "$420", "ms-appx:///Assets/Apartment/nice2aMain.jpg","Nice", "Beautiful house description", "8"),
            };

            SelectedItem = new Accommodation();

            filteredCottages = new ObservableCollection<Accommodation>();
            FilterCottage();

           

           //filteredFlat = new ObservableCollection<Accommodation>();
           //FilterFlat();

            //filteredVilla = new ObservableCollection<Accommodation>();
            //FilterVilla();

            //filteredBungalow = new ObservableCollection<Accommodation>();
            //FilterBungalow();
        }

        //public void FilterCottage()
        //{

        //    var filteredCottages = from Cottages in Accommodation
        //                           where Cottages.Style == "Cottage"
        //                           select Cottages;
        //    foreach (Accommodation Cottage in Accommodation)
        //    {
        //        filteredCottages = filteredCottages.Concat(new ObservableCollection<Accommodation> {Cottage});
        //    }
        //}

        public void FilterCottage()
        {
            foreach (Accommodation Cottage in Accommodation)
            {
                if (Cottage.Style == "Cottage")
                {
                    filteredCottages.Add(Cottage);
                }
            }
        }





        //public void FilterFlat()
        //{
        //    foreach (Accommodation Flat in Accommodation)
        //    {
        //        if (Flat.Style == "Flat")
        //        {
        //            filteredCottages.Add(Flat);
        //        }
        //    }
        //}

        //public void FilterVilla()
        //{
        //    foreach (Accommodation Villa in Accommodation)
        //    {
        //        if (Villa.Style == "Villa")
        //        {
        //            filteredVilla.Add(Villa);
        //        }
        //    }
        //}

        //public void FilterBungalow()
        //{
        //    foreach (Accommodation Bungalow in Accommodation)
        //    {
        //        if (Bungalow.Style == "Bungalow")
        //        {
        //            filteredBungalow.Add(Bungalow);
        //        }
        //    }
        //}

        //var filteredCottages = from Cottages in Accommodation
        //                       where Cottages.Style == "Cottage"
        //                       select Cottages;

        //// var filteredCottages = Accommodation.Where(p => p.Style == "Cottage");


        //foreach (var Cottages in filteredCottages)
        //{                
        //    filteredCottages = filteredCottages.Concat(new ObservableCollection<Accommodation> { Cottages });
        //}
    }
}

