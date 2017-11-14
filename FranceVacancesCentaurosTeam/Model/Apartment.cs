using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesCentaurosTeam.Model
{
    public class Apartment
    {
        public string Style { get; set;}
        public string Rent { get; set;}
        public string MainImage { get; set;}

        public string Location { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }
       
               
    }

    public class Options
    {
        public string City { get; set; }
        public string Acc { get; set; }
    }

    public class ApartmentManager
    {
        public static List<Apartment> GetApartment()
        {
            var apartments = new List<Apartment>();

            apartments.Add(new Apartment { ID = "1", Style = "Flat", Location = "Cannes",Rent = "$350", MainImage = "ms-appx:///Assets/Apartment/cannes1aMain.jpg" });
            apartments.Add(new Apartment { ID = "2", Style = "Flat", Location = "Cannes", Rent = "$360", MainImage = "ms-appx:///Assets/Apartment/cannes2aMain.jpg" });
            apartments.Add(new Apartment { ID = "3", Style = "Cottage", Location = "Chamonix", Rent = "$450", MainImage = "ms-appx:///Assets/Apartment/chamonix1aMain.jpg" });
            apartments.Add(new Apartment { ID = "4", Style = "Cottage", Location = "Chamonix", Rent = "$470", MainImage = "ms-appx:///Assets/Apartment/chamonix2aMain.jpg" });
            apartments.Add(new Apartment { ID = "5", Style = "Flat", Location = "Lion", Rent = "$550", MainImage = "ms-appx:///Assets/Apartment/lyon1aMain.jpg" });
            apartments.Add(new Apartment { ID = "6", Style = "Flat", Location = "Lion", Rent = "$450", MainImage = "ms-appx:///Assets/Apartment/lyon2a.jpg" });
            apartments.Add(new Apartment { ID = "7", Style = "Flat", Location = "Nice", Rent = "$650", MainImage = "ms-appx:///Assets/Apartment/nice1Main.jpg" });
            apartments.Add(new Apartment { ID = "8", Style = "Flat", Location = "Nice", Rent = "$750", MainImage = "ms-appx:///Assets/Apartment/nice2aMain.jpg" });

            return apartments;
        }
        public static List<Options> GetAccommodation()
        {
            var accommodations = new List<Options>();

            accommodations.Add(new Options() { City = "Cannes", Acc = "Cottage" });
            accommodations.Add(new Options() { City = "Chamonix", Acc = "Flat" });
            accommodations.Add(new Options() { City = "Lyon", Acc = "Villa" });
            accommodations.Add(new Options() { City = "Nice", Acc = "Bungalow" });


            return accommodations;
        }
    }
}
