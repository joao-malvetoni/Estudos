﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTask.Models
{
	public class SubTaskModel : INotifyPropertyChanged
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		private bool _isCompleted;
		public bool IsCompleted
		{
			get { return _isCompleted; }
			set
			{
				_isCompleted = value;
				OnPropertyChanged(nameof(IsCompleted));
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		private void OnPropertyChanged(string propName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propName));
			}
		}
	}
}
