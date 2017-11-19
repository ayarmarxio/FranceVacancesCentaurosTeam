using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesCentaurosTeam.ViewModel
{
    class BookingVM
    {
        private Singleton _singleton;

        public string Accommodation { get; set; }
    

        public BookingVM()
        {
            _singleton = Singleton.GetInstance();


            Accommodation = _singleton.GetAccommodation();
            

        }
    }

    internal class Singleton
    {
        public static Singleton GetInstance()
        {
            throw new NotImplementedException();
        }

        public string GetAccommodation()
        {
            throw new NotImplementedException();
        }
    }
}
