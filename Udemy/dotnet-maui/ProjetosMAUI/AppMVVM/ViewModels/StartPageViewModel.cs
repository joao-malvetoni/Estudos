using AppMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppMVVM.ViewModels
{
	public class StartPageViewModel : INotifyPropertyChanged
	{
		private Person _person;
		public ICommand SaveCommand { get; set; }
		public Person Person
		{
			get
			{
				return _person;
			}
			set
			{
				_person = value;
				OnPropertyChanged(nameof(Person));
			}
		}
		public ObservableCollection<Person> People { get; set; }
		public StartPageViewModel()
		{
			Person = new Person();
			SaveCommand = new Command(Save);
			People = new ObservableCollection<Person>();
		}

		private void Save()
		{
			People.Add(Person);
			Person = new Person();
		}
		public event PropertyChangedEventHandler? PropertyChanged;
		public void OnPropertyChanged(string prop)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(prop));
			}
		}
	}
}
