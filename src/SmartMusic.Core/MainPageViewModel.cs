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
                },
                new Song
                {
                   Name = "Dogs",
                   Album = "Animals",
                   OnFire = false,
                   Position = 2
                },
                new Song
                {
                   Name = "Juntos e Shallow Now",
                   Album = "Nasce uma estrela HUE-BR",
                   OnFire = false,
                   Position = 3
                },
                new Song
                {
                   Name = "be alone",
                   Album = "QIQI",
                   OnFire = false,
                   Position = 4 
                },
                new Song
                {
                   Name = "go and have a cup of coffee",
                   Album = "Starbucks",
                   OnFire = false,
                   Position = 5
                }
            };
        }
    }
}