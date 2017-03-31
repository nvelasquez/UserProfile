using Prism.Unity;
using Prism.Mvvm;
using Xamarin.Forms;
using UserProfile.Views;

namespace UserProfile
{
	public partial class App : PrismApplication
	{
		public App()
		{
			InitializeComponent();
		}

		protected override void OnInitialized()
		{
			NavigationService.NavigateAsync("HomePage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<HomePage>();
			Container.RegisterTypeForNavigation<EditProfilePage>();
			Container.RegisterTypeForNavigation<AboutPage>();
		}
	}
}
