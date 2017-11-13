using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesCentaurosTeam.Model
{
    public class City : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;


        public City()

        {

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

        private void NotifyPropertyChanged(string name)
        {
            throw new NotImplementedException();
        }


        public City[] GetCity()
        {
            return new[]
            {
                new City {Name = "Cannes"},
                new City {Name = "Chamonix"},
                new City {Name = "Lyon"},
                new City {Name = "Nice"},

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
