using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FlexLayout1
{
	public partial class Tags : ObservableObject
	{
		[ObservableProperty]
		private ObservableCollection<string> _modes = new ObservableCollection<string>();

        [ObservableProperty]
        private string _header = "Header";

        public Tags(int count)
		{
			if(count == 0)
            {
                Modes.Add("Kompetenz");
                Modes.Add("Eingliederung");
                Modes.Add("Fallbeispielen");
                Modes.Add("Wissen");
                Modes.Add("Erkenntnisse");
                Modes.Add("Seminar");
                Modes.Add("BEM");
            }
            else
            {

                Modes.Add("Berufliche Rehabilitation");
                Modes.Add("Beratung/Coaching");
            }

        }

	}
}

