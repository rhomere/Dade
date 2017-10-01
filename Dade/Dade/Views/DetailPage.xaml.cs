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
	public partial class DetailPage : ContentPage
	{
		public DetailPage (Official official)
		{
			InitializeComponent ();

            this.Title = official.Name;

            OfficialImage.Source = official.ImageUrl;
            OfficialName.Text = official.Name;
            OfficialPosition.Text = official.Position;
            Info.Text = official.Info;
            if(official.TermLength != null)
                TermLength.Text = "Term Length: " + official.TermLength + " years";
            if(official.NextElection != null)
                NextElection.Text = "Next Election: " + official.NextElection;
		}
	}
}