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
      


          public Owner( string cpr, string name, string telephoneNumber )
        {
            Cpr = cpr;
            Name = name;
            TelephoneNumber = telephoneNumber;
      
        }

        public Owner()
        {

        }

        public override string ToString()
        {
            return Name + Cpr + TelephoneNumber;
        }
    }


 }
    


