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
        private ObservableCollection<Accommodation> _filteredCottage;
        public ObservableCollection<Accommodation> Accommodation { get; set; }

        public Accommodation SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
            }
        }

        

        public ObservableCollection<Accommodation> FilteredCottage { get { return _filteredCottage; } set { _filteredCottage = value; } }
        
        //public AccommodationCollectionVM()
        //{
        //    FilteredCottage = ;
        //}

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
        }                
        
        public void FilterCottage()
        {
           
            foreach (Accommodation Cottage in Accommodation)
            {
                string filteredCottage;

                if (Cottage.Style == "Cottage")
                {
                    filteredCottage = Cottage.MainImage + Cottage.Location + Cottage.Rent;
                }
            }
        }
        
    }
}

