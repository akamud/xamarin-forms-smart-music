using System.Collections.ObjectModel;

namespace SmartMusic
{
    public class MainPageViewModel
    {
        public ObservableCollection<Song> Songs { get; set; }
        public MainPageViewModel()
        {
            Songs = new ObservableCollection<Song>()
            {
                new Song
                {
                   Name = "You are as beautiful as spring",
                   Album = "XIAPI",
                   OnFire = true,
                   Position = 1
                }
            };
        }
    }
}