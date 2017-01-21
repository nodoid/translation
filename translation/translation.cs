using System;

using Xamarin.Forms;
using translation.Languages;
using System.Globalization;

namespace translation
{
	public class App : Application
	{
		public App()
		{
			var netLanguage = DependencyService.Get<ILocalise>().GetCurrent();
			Langs.Culture = new CultureInfo(netLanguage);
			DependencyService.Get<ILocalise>().SetLocale();
			MainPage = new NavigationPage(new Translate());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
