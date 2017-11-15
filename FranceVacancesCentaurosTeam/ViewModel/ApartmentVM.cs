using FranceVacancesCentaurosTeam.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FranceVacancesCentaurosTeam.ViewModel
{
    class ApartmentVM
    {
        public ObservableCollection<Apartment> Apartment { get; set;}



        public ApartmentVM()
        {
            Apartment = new ObservableCollection<Apartment>
            {



            };
        }
    }
}

