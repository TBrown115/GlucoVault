using GlucoVault.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlucoVault.ModelViews
{
	public class DietariesPageViewModel : ViewModelBase
	{
		public IList<Dietary> Dietaries { get { return DietaryData.Dietaries; } }

		Dietary selectedDietary;
		public Dietary SelectedDietary
		{
			get { return selectedDietary; }
			set
			{
				if (selectedDietary != value)
				{
					selectedDietary = value;
					OnPropertyChanged();
				}
			}
		}
	}
}
