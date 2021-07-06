using Kargo.Models;
using Kargo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using Kargo.Connection;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace Kargo.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyDetail : ContentPage
    {
        
        public MyDetail()
        {
          
            InitializeComponent();
           
             GetData(); 
        }
       public  IEnumerable<Iller> GetData()
        {
            IEnumerable<Iller> ils;
            using (HttpClient cl = new HttpClient())
            {
                cl.DefaultRequestHeaders.Accept.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var result =  cl.GetStringAsync("https://localhost:44391/api/values").Result;

                ils = JsonConvert.DeserializeObject<IEnumerable<Iller>>(result.ToString());
                
            }
            return ils;
        }

       
        async void Button_Clicked(object sender, EventArgs e)
        {
            await  Navigation.PushAsync(new Cari());
          
        }
       


    }
} 