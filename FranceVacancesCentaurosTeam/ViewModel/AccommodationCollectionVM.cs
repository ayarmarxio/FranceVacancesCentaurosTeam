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

        public ObservableCollection<Accommodation> filteredCannes { get; set; }

        public ObservableCollection<Accommodation> filteredChamonix { get; set; }

        public ObservableCollection<Accommodation> filteredLyon { get; set; }

        public ObservableCollection<Accommodation> filteredNice { get; set; }

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
                 new Accommodation ("Cottage", "$420", "ms-appx:///Assets/Apartment/CannesCottage1.jpg","Cannes", "Beautiful house description", "9"),
                 new Accommodation ("Villa", "$420", "ms-appx:///Assets/Apartment/CannesVilla2.jpg","Cannes", "Beautiful house description", "10"),
                 new Accommodation ("Villa", "$420", "ms-appx:///Assets/Apartment/CannesVilla3.jpg","Cannes", "Beautiful house description", "11"),
                 new Accommodation ("Villa", "$420", "ms-appx:///Assets/Apartment/CannesVillaMain.jpg","Cannes", "Beautiful house description", "12"),
                 new Accommodation ("Bungalow", "$420", "ms-appx:///Assets/Apartment/ChamonixBungalow1.jpg","Chamonix", "Beautiful house description", "13"),
                 new Accommodation ("Bungalow", "$420", "ms-appx:///Assets/Apartment/LyonBungalows.jpg","Lyon", "Beautiful house description", "14"),
                 new Accommodation ("Bungalow", "$420", "ms-appx:///Assets/Apartment/LyonBungalows1.jpg","Lyon", "Beautiful house description", "15"),
                 new Accommodation ("Villa", "$420", "ms-appx:///Assets/Apartment/LyonVilla2.jpg","Lyon", "Beautiful house description", "16"),
                 new Accommodation ("Villa", "$420", "ms-appx:///Assets/Apartment/LyonVilla3.jpg","Lyon", "Beautiful house description", "17"),
                 new Accommodation ("Villa", "$420", "ms-appx:///Assets/Apartment/LyonVillaMain.jpg","Lyon", "Beautiful house description", "18"),
                 new Accommodation ("Villa", "$420", "ms-appx:///Assets/Apartment/NiceVilla2.jpg","Nice", "Beautiful house description", "19"),
                 new Accommodation ("Villa", "$420", "ms-appx:///Assets/Apartment/NiceVillaMain.jpg","Nice", "Beautiful house description", "20"),
                 new Accommodation ("Villa", "$420", "ms-appx:///Assets/Apartment/CannesBungalow1.jpg","Cannes", "Beautiful house description", "21"),
                
            };

            SelectedItem = new Accommodation();

            filteredCottages = new ObservableCollection<Accommodation>();
            FilterCottage();

            SelectedItem = new Accommodation();
           
            filteredFlat = new ObservableCollection<Accommodation>();
            FilterFlat();

            SelectedItem = new Accommodation();
            

            filteredVilla = new ObservableCollection<Accommodation>();
            FilterVilla();

            SelectedItem = new Accommodation();

            filteredBungalow = new ObservableCollection<Accommodation>();
            FilterBungalow();

            SelectedItem = new Accommodation();

            filteredCannes = new ObservableCollection<Accommodation>();
            FilterCannes();

            SelectedItem = new Accommodation();

            filteredChamonix = new ObservableCollection<Accommodation>();
            FilterChamonix();

            SelectedItem = new Accommodation();

            filteredLyon = new ObservableCollection<Accommodation>();
            FilterLyon();

            SelectedItem = new Accommodation();

            filteredNice = new ObservableCollection<Accommodation>();
            FilterNice();

        }

    

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
        
        public void FilterFlat()
        {
            foreach (Accommodation Flat in Accommodation)
            {
                if (Flat.Style == "Flat")
                {
                    filteredFlat.Add(Flat);
                }
            }
        }

        public void FilterVilla()
        {
            foreach (Accommodation Villa in Accommodation)
            {
                if (Villa.Style == "Villa")
                {
                    filteredVilla.Add(Villa);
                }
            }
        }

        public void FilterBungalow()
        {
            foreach (Accommodation Bungalow in Accommodation)
            {
                if (Bungalow.Style == "Bungalow")
                {
                    filteredBungalow.Add(Bungalow);
                }
            }
        }
        public void FilterCannes()
        {
            foreach (Accommodation Cannes in Accommodation)
            {
                if (Cannes.Location == "Cannes")
                {
                    filteredCannes.Add(Cannes);
                }
            }
        }

        public void FilterChamonix()
        {
            foreach (Accommodation Chamonix in Accommodation)
            {
                if (Chamonix.Location == "Chamonix")
                {
                    filteredChamonix.Add(Chamonix);
                }
            }
        }

        public void FilterLyon()
        {
            foreach (Accommodation Lyon in Accommodation)
            {
                if (Lyon.Location == "Lyon")
                {
                    filteredLyon.Add(Lyon);
                }
            }
        }

        public void FilterNice()
        {
            foreach (Accommodation Nice in Accommodation)
            {
                if (Nice.Location == "Nice")
                {
                    filteredNice.Add(Nice);
                }
            }
        }

      
    }
}

