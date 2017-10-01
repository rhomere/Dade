using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dade.Views;
using Dade.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dade.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OfficialsPage : ContentPage
	{
        GovController manager = new GovController();
        public string MuniName;

		public OfficialsPage (String muniName)
		{
			InitializeComponent ();
            this.Title = muniName;
            MuniName = muniName;

		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await LoadOfficials();
        }

        private async Task LoadOfficials()
        {
            IEnumerable<Official> list = await manager.GetOfficials();

            //Sort by name
            list = list.Where(m => m.Municipality == MuniName);

            list = list.OrderBy(m => m.Placement);

            OfficialsList.ItemsSource = list;
        }

        private async void OfficialsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new DetailPage(e.SelectedItem as Official));
        }
    }
}