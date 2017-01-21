using System;

using Xamarin.Forms;
using translation.Languages;
using System.Globalization;

namespace translation
{
	public class Translate : ContentPage
	{
		string lang = "en";
		bool clicked = false;

		public Translate()
		{
			var txtLabel = new Label
			{
				Text = Langs.Hello,
				FontSize = 22,
				TextColor = Color.Red,
				HorizontalTextAlignment = TextAlignment.Center
			};

			var btnChange = new Button
			{
				Text = "Change language"
			};

			btnChange.Clicked += (sender, e) =>
			{
				lang = lang == "en" ? "de" : "en";
				Langs.Culture = new CultureInfo(lang);
				txtLabel.Text = clicked == false ? Langs.Goodby : Langs.Hello;
				clicked = !clicked;
				InvalidateMeasure();
			};

			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
				Orientation = StackOrientation.Vertical,
				Padding = new Thickness(12),
				Children =
				{
					txtLabel, btnChange
				}
			};
		}
	}
}

