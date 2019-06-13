using Prism.Navigation;

namespace SmartMusic.Core
{
    public class SongPageViewModel : INavigatedAware
    {
        private readonly INavigationService navigationService;

        public SongPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public async void OnNavigatedTo(INavigationParameters parameters)
        {
            //await navigationService.NavigateAsync(nameof(MainPage));
        }
    }
}
