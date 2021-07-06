using Kargo.Models;
using Kargo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kargo.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMenu : ContentPage
    {
        public MyMenu()
        {
            InitializeComponent();
            IconImageSource = "menu.png";
            Title = "Menu";
            var lst = new List<Item>
            {
                new Item { Name = "Anasayfa", No = "1",Image="home.png" },
                new Item {Name ="Düzenle",No="2",Image="edit.png"},
                new Item {Name ="Çıkış Yap",No="3",Image="exit.png"}
            };
            lstMenu.ItemsSource = lst;
           

        }

        private void lstMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItemIndex==0)
            {
                Navigation.PushAsync(new MyDetail());
            }
            if (e.SelectedItemIndex==1)
            {
                Navigation.PushAsync(new EditCari());
            }
            if (e.SelectedItemIndex == 2)
            {
                Navigation.PushAsync(new Login());
            }

        }

        
    }
}