
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesCentaurosTeam.Model
{

    public class Apartment : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        private string _id;
        private string _address;
        private string _type;

        public Apartment()
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


        public string Address
        {
            get { return this._address; }
            set
            {
                this._address = value;
                NotifyPropertyChanged("Address");
            }
        }


        public string Type
        {
            get { return this._type; }
            set
            {
                this._type = value;
                NotifyPropertyChanged("Type");
            }
        }

        public Apartment[] GetApartment()
        {
            return new[]
            {
                new Apartment {Id = "001", Address = "27 RUE PASTEUR", Type = "2 rooms"},
                new Apartment {Id = "002", Address = "IMPASSE VIVALDI VAUCE", Type = "1 rooms"},
                new Apartment {Id = "003", Address = "12 MONT PARNASE", Type = "2 rooms"},
                new Apartment {Id = "004", Address = "5 RUE MADAM CHARLOTTE", Type = "1 rooms"},
                new Apartment {Id = "005", Address = "44 AVENUE DES TERNES", Type = "2 rooms"},
                new Apartment {Id = "006", Address = "55 RUE DU FAUBOURG", Type = "1 rooms"},
                new Apartment {Id = "007", Address = "3 AVENUE DORIAN", Type = "2 rooms"},
                new Apartment {Id = "008", Address = "IMPASSE LOLITA", Type = "2 rooms"},


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

