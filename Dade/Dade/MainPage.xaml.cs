using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Dade.Models;
using Dade.Views;

namespace Dade
{
	public partial class MainPage : ContentPage
	{
        GovController manager = new GovController();

		public MainPage()
		{
            
            InitializeComponent();

		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await LoadMunis();
            //MunisList.ItemTapped += null;
        }

        //Load list of Munis
        private async Task LoadMunis()
        {
            IEnumerable<Municipality> list = await manager.GetMunis();
            //Sort by name
            list = list.OrderBy(m => m.Name);

            MunisList.ItemsSource = list;
        }

        private async void MunisList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new CityPage(e.SelectedItem as Municipality));
        }

    }
}
