using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SteamPricely.Services;

namespace SteamPricely
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        List<SearchItem> tempdata;
        
        public MenuPage()
        {
            InitializeComponent();
            data();
            listView.ItemsSource = tempdata;
        }

        void data()
        {
            // all the temp data  
            tempdata = new List<SearchItem> {
        new SearchItem(){ Name = "AWP | Mortis", Exterior = "Field-Tested", Img = "https://community.akamai.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot621FABz7PLfYQJG6d2inL-GkvP9JrbummpD78A_077EoYjwiwPsqktpa2v3IYLEIQY7NAnX-ge2kunug8W_uZjNyiRk7z5iuyihMO8qww/360fx360f"},
        new SearchItem(){ Name = "M4A4 | Neo-Noir", Exterior = "Field-Tested", Img = "https://community.akamai.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou-6kejhjxszFJTwW09Kzm7-FmP7mDLbUkmJE5fp9i_vG8MKhigft8kVsZmGhd4WTdwE9NFGErFnqxbzvg5W6uM7IyyRm7CYnti3YgVXp1vjKz5XZ/360fx360f"},
        new SearchItem(){ Name = "AK-47 | Asiimov", Exterior = "Field-Tested", Img = "https://community.akamai.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhjxszJemkV092lnYmGmOHLPr7Vn35c18lwmO7Eu92milbl-BZsZGiiLNKdJFc8Mg7V_1S_xuzshZK97c_In3pruCJx4X_D30vgyZM--n4/360fx360f"},
        new SearchItem(){ Name = "M4A4 | Cyber Security", Exterior = "Field-Tested", Img = "https://community.akamai.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou-6kejhjxszFJTwW09-vloWZh-L6OITck29Y_chOhujT8om72wy1-kBlYzryJI-UdAA8aAvU81e7w-zphJS06JrMnSdmvCkjtCrelgv33099jS-zpA/360fx360f"},
        new SearchItem(){ Name = "AWP | Neo-Noir", Exterior = "Minimal Wear", Img = "https://community.akamai.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot621FAR17PLfYQJM6dO4m4mZqPrxN7LEm1Rd6dd2j6eV9I_2iwLk_EZrZ22gJNWXcQQ7Y1jV_Qe_kOfr08e0vJXOzHJhuHV2-z-DyGLCbG22/360fx360f"},
        new SearchItem(){ Name = "MAG-7 | Carbon Fiber", Exterior = "Factory New", Img = "https://community.akamai.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou7uifDhh3szLcC9A49KJkomJkuXLP7LWnn9u5MRjjeyPp96jiVW2_0dsNm-mIoaRc1Q7M1yC-ljoyO7og5-57czBzHYx6XN35WGdwUIbo5XIWg/360fx360f"},
        new SearchItem(){ Name = "AK-47 | Elite Build", Exterior = "Well-Worn", Img = "https://community.akamai.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhjxszJemkV09G3h5SOhe7LPr7Vn35c18lwmO7Eu4ih0VDi80drZ276JtfBdQE4ZA3S8gXoxebogZ-57ZiYmCFlvyIi5HjD30vgrWhS6dA/360fx360f"},
        new SearchItem(){ Name = "AK-47 | Slate", Exterior = "Minimal Wear", Img = "https://community.akamai.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhnwMzJemkV08ykm4aOhOT9PLXQmlRd4cJ5ntbN9J7yjRqw-0o4ZWvwcIbEdQQ7Ml7Tr1nvwufvgMC6us-bmHZi6HEgsCvYlkC_n1gSOasHEuYf/360fx360f"},
        new SearchItem(){ Name = "AK-47 | The Empress", Exterior = "Well-Worn", Img = "https://community.akamai.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhnwMzJemkV09m7hJKOhOTLPr7Vn35c18lwmO7Eu9ql2gDg8kBoYWqlddLHIVI8YFnZqFTrk73mjMW-v87ByHRluiB2533D30vgNUkukuM/360fx360f"},
        new SearchItem(){ Name = "AWP | Atheris", Exterior = "Field-Tested", Img = "https://community.akamai.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot621FAR17PLfYQJU5cyzhr-GkvP9JrbummpD78A_3-vE9I6t0Afir0JuMWnxIdKRJAZvZF-E_FLsyLruhsS8ucmcz3Vmvj5iuygKH_-NNA/360fx360f"},
    };
        }


            private void SearchBar_TextChanged(object sender, TextChangedEventArgs e){
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                listView.ItemsSource = tempdata;
            }

            else
            {
                listView.ItemsSource = tempdata.Where(x => x.Name.StartsWith(e.NewTextValue));
            }

        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (SearchItem)e.SelectedItem;
            ;
                Navigation.PushAsync(new ItemPage(item));

        }
    }

  
}