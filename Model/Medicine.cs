using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPharmacy.Model
{
    public class Medicine : INotifyPropertyChanged
    {
		public Medicine()
		{

		}

		private int id;

		public int Id
		{
			get { return id; }
			set 
            { 
                id = value; 
                OnPropertyChanged("Id");
            }
		}
		private string name;

		public string Name
		{
			get { return name; }
			set 
			{ 
				name = value; 
				OnPropertyChanged("Name");
			}
		}
		private string description;

		public string Description
		{
			get { return description; }
			set 
			{ 
				description = value;
				OnPropertyChanged("Description");
			}
		}
		private string fullDiscription;

		public string FullDiscription
		{
			get { return fullDiscription; }
			set 
			{ 
				fullDiscription = value;
				OnPropertyChanged("FullDiscription");
			}
		}

		private string imgSource;

		public string ImgSource
		{
			get { return imgSource; }
			set 
			{ 
				imgSource = value;
                OnPropertyChanged("ImgSource");
            }
		}


		public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
