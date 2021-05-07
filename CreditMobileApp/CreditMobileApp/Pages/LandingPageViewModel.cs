using CreditMobileApp.ViewModels;
using Prism.Navigation;

namespace CreditMobileApp.Droid.Pages
{
    public class LandingPageViewModel : ViewModelBase
    {
        public LandingPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Landing Page";
            UserName = "Kudzai";
        }

        private string _userName;
        public string UserName
        {
            get =>  _userName; 
            set => SetProperty(ref _userName, value); 
        }


    }
}