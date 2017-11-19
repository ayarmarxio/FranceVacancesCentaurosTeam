using FranceVacancesCentaurosTeam.ViewModel;
using FranceVacancesCentaurosTeam.Model;
using FranceVacancesCentaurosTeam.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FranceVacancesCentaurosTeam.ViewModel
{
    public class OwnerCollection: NotifyChangePropertyClass
    {
        public ObservableCollection<Owner> Owner { get; set; }
        private Owner _selectedItem;

        public RelayCommand AddItemCommand { get; set; }

        public Owner AddNewOwner { get; set; }

        public Owner SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }


        public OwnerCollection()
        {
            Owner = new ObservableCollection<Owner>
            {
                new Owner ( "2394757689", "Vicente Capuzzo", "+33 34567898" ),
                new Owner ( "2321436813", "George Orwell", "+33 93843789"),
                new Owner ( "5684747564", "Saruto Kitano", "+33 85764536" ),
                new Owner ( "4843858848", "Piong Kim Du", "+33 76234354" ),
                new Owner ( "4955648945", "Henry Fuerte", "+33 76875432"),
                new Owner ( "9437476373", "Annabella Smuk", "+33 54637867" ),
                new Owner ( "3284782889", "Morten PiuVita", "+33 76345321"),
                new Owner ( "6453883272", "Armando Paredes", "+33 76453676" ),
                new Owner ( "7583773266", "Greg Orian", "+33 23435423")
            };

            AddItemCommand = new RelayCommand(DoAddItem);

            AddNewOwner = new  Owner();
            SelectedItem = new Owner();
        }

        public void DoAddItem()
        {
            Owner.Add(AddNewOwner);
        }

    }
}
