using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dade.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dade.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CityPage : ContentPage
	{
        public string MuniName;

		public CityPage (Municipality Muni)
		{
			InitializeComponent ();

            this.Title = Muni.Name;
            MuniName = Muni.Name;
            MuniImage.Source = Muni.ImageUrl;
            Info.Text = Muni.Info;

		}

        private void Home_Clicked(object sender, EventArgs e)
        {

        }

        private async void Officals_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OfficialsPage(MuniName));
        }
    }
}