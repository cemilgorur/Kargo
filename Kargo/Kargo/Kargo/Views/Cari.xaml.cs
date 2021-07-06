
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Kargo.Models;
using Kargo.Views;
using System.Data.SqlClient;

namespace Kargo.Views
{

    public partial class Cari : ContentPage
    {

        public Cari()
        {
            InitializeComponent();          
            var list = new List<Cariler>
            {
                new Cariler {Name="Can elektrik"},
                new Cariler {Name="Künefeci"}

            };
            lstCari.ItemsSource = list;
        }
        private async void lstCari_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Cariler = e.Item as Cari;
            await Navigation.PushAsync(new CariDetay());
                
        }
        


       
    }
}
