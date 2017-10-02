using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsTest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			//InitializeComponent();
			StackLayout layout = new StackLayout
			{
				Padding = new Thickness(20),
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.Fill
			};
			
			Label label = new Label
			{
				Text = "Hola!\nPresiona el botón",
				FontSize = 24,
				FontAttributes = FontAttributes.Bold,
				HorizontalTextAlignment = TextAlignment.Center
			};
			layout.Children.Add(label);

			Button elButton = new Button
			{
				Text = "El Boton",
				HorizontalOptions = LayoutOptions.Fill
			};
			
			elButton.Clicked += (sender, args) => { DisplayAlert("Hola", "Click", "OK"); };
			layout.Children.Add(elButton);
			Content = layout;
		}

		private async void ElBotonClicked(object sender, EventArgs e)
		{
			//DisplayAlert("Clicked", "Haz presionado el botón", "OK");
			var opt = await DisplayActionSheet("Select an Option", "Cancel", "Destroy", "O1", "New Opt", "NeXT");

			await DisplayAlert("Clicked", opt, "OK");
		}
	}
}
