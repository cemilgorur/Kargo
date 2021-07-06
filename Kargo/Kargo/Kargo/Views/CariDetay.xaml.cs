using Kargo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kargo.Views
{
   
    public partial class CariDetay : ContentPage
    {
        public static Color myColor = Color.Green;
        public CariDetay()
        {
            InitializeComponent();
            
            var list = new List<Detay>
            {
                new Detay { urun="URUN", adres="ADRES", date="TARİH"},
                
                };
            lstDetay.ItemsSource = list;
           

            }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditCari());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

         

            
            DisplayAlert("Görev", "Kaydedildi","Tamam");
           
        }
      

    }
    }
