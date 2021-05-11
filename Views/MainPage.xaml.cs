using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views.Presentation;
using Xamarin.Forms;

namespace Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        async void PageItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var pageList = (string[])Resources["PageArray"];
            await Navigation.PushAsync(new LabelPage());
            
        }
    }
}
