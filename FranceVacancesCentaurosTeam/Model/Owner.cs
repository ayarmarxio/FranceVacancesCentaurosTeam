using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesCentaurosTeam.Model
{
    public class Owner
    {
        public string Cpr{ get; set; }
        public string Name {get;  set; }

        public string TelephoneNumber { get; set; }
        //public string ImageUrl { get; set; }


        //private string _cpr;
        //private string _name;
        //private string _telephoneNumber;
        //private string _imageUrl;

        public Owner( string cpr, string name, string telephoneNumber )
        {
            Cpr = cpr;
            Name = name;
            TelephoneNumber = telephoneNumber;
            //ImageUrl = imageUrl;
        }

        public Owner()
        {

        }

        public override string ToString()
        {
            return Name;
        }


        //public string Cpr
        //{
        //    get { return this._cpr; }
        //    set
        //    {
        //        this._cpr = value;
        //        NotifyPropertyChanged("Cpr No");
        //    }
        //}

        //private void NotifyPropertyChanged(string cprNo)
        //{
        //    throw new NotImplementedException();



        //public string Name
        //{
        //    get { return this._name; }
        //    set
        //    {
        //        this._name = value;
        //        NotifyPropertyChanged("Name");
        //    }
        //}


        //public string TelephoneNumber
        //{
        //    get { return this._telephoneNumber; }
        //    set
        //    {
        //        this._telephoneNumber = value;
        //        NotifyPropertyChanged("TelephoneNumber");
        //    }
        //}

        //public string ImageUrl
        //{
        //    get { return this._telephoneNumber; }
        //    set
        //    {
        //        this._telephoneNumber = value;
        //        NotifyPropertyChanged("ImageUrl");
        //    }
        //}




        //public Owner[] GetOwner()
        //{
        //    return new[]
        //    {
        //        new Owner {Cpr = "011", Name = "Pierre Bonchance", Tlfnr = "35.65.42.11"},
        //        new Owner {Cpr= "012", Name = "Antoine Valois", Tlfnr = "67.45.21.37"},
        //        new Owner {Cpr = "013", Name = "Marcelle Guerlain", Tlfnr = "39.45.69.00"},



    };


 }
    


