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

    public class ApartmentManager
    {
        public static List<Apartment> GetApartment()
        {
            var apartments = new List<Apartment>();

            apartments.Add(new Apartment { Style = "Flat", Location = "Cannes",Rent = "$350", MainImage = "ms-appx:///Assets/Apartment/cannes1aMain.jpg" });
            apartments.Add(new Apartment { Style = "Flat", Location = "Cannes", Rent = "$360", MainImage = "ms-appx:///Assets/Apartment/cannes2aMain.jpg" });
            apartments.Add(new Apartment { Style = "Cottage", Location = "Chamonix", Rent = "$450", MainImage = "ms-appx:///Assets/Apartment/chamonix1aMain.jpg" });
            apartments.Add(new Apartment { Style = "Cottage", Location = "Chamonix", Rent = "$470", MainImage = "ms-appx:///Assets/Apartment/chamonix2aMain.jpg" });
            apartments.Add(new Apartment { Style = "Flat", Location = "Lion", Rent = "$550", MainImage = "ms-appx:///Assets/Apartment/lyon1aMain.jpg" });
            apartments.Add(new Apartment { Style = "Flat", Location = "Lion", Rent = "$450", MainImage = "ms-appx:///Assets/Apartment/lyon2a.jpg" });
            apartments.Add(new Apartment { Style = "Flat", Location = "Nice", Rent = "$650", MainImage = "ms-appx:///Assets/Apartment/nice1Main.jpg" });
            apartments.Add(new Apartment { Style = "Flat", Location = "Nice", Rent = "$750", MainImage = "ms-appx:///Assets/Apartment/nice2aMain.jpg" });

            return apartments;
        }
    }
}
