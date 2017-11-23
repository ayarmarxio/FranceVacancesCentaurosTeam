using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesCentaurosTeam.Model
{
    public class Accommodation
    {

        public string Style { get; set; }
        public string Rent { get; set; }
        public string MainImage { get; set; }

        public string Location { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }

        public Accommodation
            (
            string style,
            string rent,
            string mainimage,
            string location,
            string description,
            string id
            )
        {
            Style = style;
            Rent = rent;
            MainImage = mainimage;
            Location = location;
            Description = description;
            ID = id;
        }

       
        public Accommodation()
        {
        }

        //public override string ToString()
        //{
        //    return Style;
        //}

        public static Accommodation _accommodation;

        public void SetAccommodation(Accommodation accommodation)
        {
            _accommodation = accommodation;
        }
        public string GetID()
        {
            return _accommodation.ID;
        }

        public string GetStyle()
        {
            return _accommodation.Style;
        }

        public string GetRent()
        {
            return _accommodation.Rent;
        }

        public string GetMainImage()
        {
            return _accommodation.MainImage;
        }

        public string GetLocation()
        {
            return _accommodation.Location;
        }
    }

}
