using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJogoForca.Models
{
	public class Word
	{
		public Word()
		{
			
		}
		public Word(string tips, string text)
		{
			Tips = tips.Trim();
			Text = text.Trim();
		}
		public string Tips { get; set; } = string.Empty;
		public string Text { get; set; } = string.Empty;
	}
}
