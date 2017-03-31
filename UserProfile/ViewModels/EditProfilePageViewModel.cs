using System;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Commands;

namespace UserProfile.ViewModels
{
	public class EditProfilePageViewModel : BindableBase, INavigatedAware
	{
		INavigationService _navigationService;



		public DelegateCommand SaveCommand
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
	
		public EditProfilePageViewModel(INavigationService navigationService)
		{
			SaveCommand = new DelegateCommand(OnSave);
			this._navigationService = navigationService;
		}

		void OnSave()
		{
			//throw new NotImplementedException();
			var pars = new NavigationParameters();
			pars.Add("model", UserProfile);

			_navigationService.GoBackAsync(pars);
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (parameters.ContainsKey("model"))
			{
				UserProfile = (UserProfile)parameters["model"];
			}
		}
	}
}
