using Kargo.Master;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Kargo.Views
{
    public class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {

            
            Master = new MyMenu();          
            Detail = new NavigationPage(new MyDetail());
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
            IsPresented = false;
            

        }
    }
}
