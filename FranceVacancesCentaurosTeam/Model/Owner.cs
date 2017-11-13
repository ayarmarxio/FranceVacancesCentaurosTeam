using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesCentaurosTeam.Model
{

    public class Owner : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        private string _id;
        private string _name;
        private string _tlfnr;

        public Owner()
        {
        }

        public string Id
        {
            get { return this._id; }
            set
            {
                this._id = value;
                NotifyPropertyChanged("Id");
            }
        }

        private void NotifyPropertyChanged(string id)
        {
            throw new NotImplementedException();
        }


        public string Name
        {
            get { return this._name; }
            set
            {
                this._name= value;
                NotifyPropertyChanged("Name");
            }
        }


        public string Tlfnr
        {
            get { return this._tlfnr; }
            set
            {
                this._tlfnr = value;
                NotifyPropertyChanged("Tlfnr");
            }
        }

        public Owner[] GetOwner()
        {

            return new[]
            {
                new Owner {Id = "011", Name = "Pierre Bonchance", Tlfnr = "35.65.42.11"},
                new Owner {Id = "012", Name = "Antoine Valois", Tlfnr = "67.45.21.37"},
                new Owner {Id = "013", Name = "Marcelle Guerlain", Tlfnr = "39.45.69.00"},



            };

            void NotifyPropertyChanged(string propertyName)
            {
                if (this.PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
    }
}
