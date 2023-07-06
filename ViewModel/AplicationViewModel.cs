using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfAppPharmacy.Model;

namespace WpfAppPharmacy.ViewModel
{


    public class AplicationViewModel : INotifyPropertyChanged
    {
        private RelayCommand searchCommand;
        private string nameForSearch;
        private Medicine selectedMedicine;
        public ObservableCollection<Medicine> Medicines { get; set; }
        public ObservableCollection<Medicine> Items { get; set; }
    public Medicine SelectedItem { get; set; }
        public RelayCommand SearchCommand
        {
            get
            {
                if (searchCommand == null) searchCommand = new RelayCommand(SearchMedicine);
                return searchCommand;
            }
        }
        public string NameForSearch
        {
            get { return nameForSearch; }
            set
            {
                nameForSearch = value;
                OnPropertyChanged("NameForSearch");
            }
        }

        public Medicine SelectedMedicine
        {
            get { return selectedMedicine; }
            set
            {
                selectedMedicine = value;
                OnPropertyChanged("SelectedMedicine");
            }
        }

        private void SearchMedicine()
        {
            Items.Clear();
            var filtered = Medicines.Where(x => string.IsNullOrEmpty(NameForSearch) || (x.Name != null && x.Name.Contains(NameForSearch, StringComparison.OrdinalIgnoreCase)));
            foreach(var item in filtered)
            {
                Items.Add(item);
            }
        }

        public AplicationViewModel()
        {
            Medicines = new ObservableCollection<Medicine>();
            using(PharmacyDbContext dbContext = new PharmacyDbContext())
            {
                foreach (Medicine item in dbContext.medecines)
                {
                    Medicines.Add(item);
                }
            }
            //{
            //    new Medicine() {Name="Med1", Description = "Description1", FullDiscription = "FullDescription1"},
            //    new Medicine() {Name="Med2", Description = "Description2 1234567891012134444444444444444", FullDiscription = "FullDescription2 aaaaaaaaaaaaaaaaaaaaaaaa1111111111aaaaaaaaaaaa", ImgSource="https://1sa.com.ua/media/catalog/product/cache/2/image/95x117/9df78eab33525d08d6e5fb8d27136e95/_/-/_-_-_-_-_10_front.jpg"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"},
            //    new Medicine() {Name="Med3", Description = "Description3", FullDiscription = "FullDescription3"}
            //};
            Items = new ObservableCollection<Medicine>();
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
