using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesCentaurosTeam.Model
{
    public class Accommodation
    {
        public string Booking { get; set; }
        public string Style { get; set; }
        public string Rent { get; set; }
        public string MainImage { get; set; }

        public string Location { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }

        public Accommodation
            (
            string booking,
            string style,
            string rent,
            string mainimage,
            string location,
            string description,
            string id
            )
        {
            Booking = booking;
            Style = style;
            Rent = rent;
            MainImage = mainimage;
            Location = location;
            Description = description;
            ID = id;
        }

       
        public Accommodation(string v)
        {
        }

        public Accommodation(string v, string v1, string v2, string v3, string v4, string v5) : this(v)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public Accommodation()
        {
        }

        //public override string ToString()
        //{
        //    return Style;
        //}

        public static Accommodation _accommodation;
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;

        public void SetAccommodation(Accommodation accommodation)
        {
            _accommodation = accommodation;
        }

        public string GetBooking()
        {
            return _accommodation.Booking;
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
