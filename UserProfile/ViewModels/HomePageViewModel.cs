using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace UserProfile.ViewModels
{
	public class HomePageViewModel : BindableBase, INavigatedAware
	{
		INavigationService _navigationService;

		public DelegateCommand EditCommand
		{
			get;
			set;
		}

		UserProfile _userProfile;
		public UserProfile UserProfile
		{
			get { return _userProfile; }
			set { SetProperty(ref _userProfile, value); }
		}

		public HomePageViewModel(INavigationService navigationService)
		{
			_userProfile = new UserProfile()
			{
				FullName = "Nestor Velasquez",
				UserName = "Zerofull800",
				Age = 26,
				Occupation = "Sayayin Dev",
				TwitterHandled = "Zerofull800",
				GithubUrl = "https://github.com/nvelasquez"
			};

			EditCommand = new DelegateCommand(OnEdit);
			this._navigationService = navigationService;
		}

		void OnEdit()
		{
			//throw new NotImplementedException();
			var pars = new NavigationParameters();
			pars.Add("model", UserProfile);

			_navigationService.NavigateAsync("EditProfilePage", pars);
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			if (parameters.ContainsKey("model"))
			{
				UserProfile = (UserProfile)parameters["model"];
			}
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (parameters.ContainsKey("model"))
			{
				UserProfile = (UserProfile)parameters["model"];
			}
			//
		}
	}
}
