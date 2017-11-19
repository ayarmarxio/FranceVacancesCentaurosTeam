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
        public ObservableCollection<Accommodation> filteredAccommodation { get; set; }
        //public ObservableCollection<Accommodation> filteredFlat { get; set; }
        //public ObservableCollection<Accommodation> filteredBungalow { get; set; }
        //public ObservableCollection<Accommodation> filteredVilla { get; set; }


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

            filteredAccommodation = new ObservableCollection<Accommodation>();
            FilterAccommodation();
            
        }

        //public void CreateCottageList()
        //{
        //    filteredCottages = new ObservableCollection<Accommodation>();
        //    FilterCottage();
        //}


        //public void CreateFlatList()
        //{
        //    filteredFlat = new ObservableCollection<Accommodation>();
        //    FilterFlat();
        //}

        //filteredVilla = new ObservableCollection<Accommodation>();
        //FilterVilla();

        //filteredBungalow = new ObservableCollection<Accommodation>();
        //FilterBungalow();

        public void FilterAccommodation()
        {
            foreach (Accommodation EachAccommodation in Accommodation)
            {
                switch (EachAccommodation.Style)
                {
                    case EachAccommodation.Style == "Cottage":
                    return filteredAccommodation.Add(EachAccommodation);
                }

            }
        }

        //public void FilterFlat()
        //{
        //    foreach (Accommodation Flat in Accommodation)
        //    {
        //        if (Flat.Style == "Flat")
        //        {
        //            filteredFlat.Add(Flat);
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
    }
}

