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
        public int Price { get; set;}
        public string MainImage { get; set;}

        

        //public string Style { get; set; }
        //public string ApartmentID { get; set; }
        //public string Description { get; set; }
        //public int Price { get; set; }
        //public string Image { get; set; }

        //public class apartments
        //{           
        //    public string Style { get; set; }
        //    public string ApartmentID { get; set; }
        //    public string Description { get; set; }
        //    public int Price { get; set; }
        //    public string Image { get; set; }
        //}
        //public class ListApartments
        //{
        //    public static List<apartments> ChooseApartment()
        //    {
        //        var Apartments = new List<apartments>();

        //        Apartments.Add(new apartments { Style = "Flat", ApartmentID = "Cannes 1", Description = "", Price = 300, Image = "Assets/Apartment/Cannes1a Main.jpg" });
        //        Apartments.Add(new apartments { Style = "Flat", ApartmentID = "Cannes 2", Description = "", Price = 400, Image = "Assets/Apartment/cannes2aMain" });
        //        Apartments.Add(new apartments { Style = "Cottage", ApartmentID = "Chamonix 1", Description = "", Price = 600, Image = "Assets/Apartment/chamonix1aMain" });
        //        Apartments.Add(new apartments { Style = "Cottage", ApartmentID = "Chamonix 2", Description = "", Price = 650, Image = "Assets/Apartment/chamonix2aMain" });
        //        Apartments.Add(new apartments { Style = "Flat", ApartmentID = "Lyon 1", Description = "", Price = 560, Image = "Assets/Apartment/lyon1aMain" });
        //        Apartments.Add(new apartments { Style = "Flat", ApartmentID = "Lyon 2", Description = "", Price = 660, Image = "Assets/Apartment/lyon2a" });
        //        Apartments.Add(new apartments { Style = "Flat", ApartmentID = "Nice 1", Description = "", Price = 380, Image = "Assets/Apartment/nice1Main" });
        //        Apartments.Add(new apartments { Style = "Flat", ApartmentID = "Nice 2", Description = "", Price = 340, Image = "Assets/Apartment/nice2aMain" });

        //        return Apartments;
        //    }


        //}
    }

    public class ApartmentManager
    {
        public static List<Apartment> GetApartment()
        {
            var apartments = new List<Apartment>();

            apartments.Add(new Apartment { Style = "Flat", Price = 350, MainImage = "Assets/Lyon 1.png" });
            apartments.Add(new Apartment { Style = "Flat", Price = 360, MainImage = "Assets/Lyon 2.png" });
            apartments.Add(new Apartment { Style = "Cottage", Price = 450, MainImage = "Assets/Apartment/chamonix1aMain.jpg" });
            apartments.Add(new Apartment { Style = "Cottage", Price = 470, MainImage = "Assets/Apartment/chamonix2aMain.jpg" });
            apartments.Add(new Apartment { Style = "Flat", Price = 550, MainImage = "Assets/Apartment/lyon1aMain.jpg" });
            apartments.Add(new Apartment { Style = "Flat", Price = 450, MainImage = "Assets/Apartment/lyon2a.jpg" });
            apartments.Add(new Apartment { Style = "Flat", Price = 650, MainImage = "Assets/Apartment/nice1Main.jpg" });
            apartments.Add(new Apartment { Style = "Flat", Price = 750, MainImage = "Assets/Apartment/nice2aMain.jpg" });

            return apartments;
        }
    }
}
