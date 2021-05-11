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
            var titles = (string[])Resources["PageArray"];
            var title = titles[e.ItemIndex];

            Page page = null;
            switch (e.ItemIndex) {
                case 0:
                    page = new LabelPage() {
                        Title = title
                    };
                    break;
                case 1:
                    page = new ButtonPage() {
                        Title = title
                    };
                    break;
            }

            await Navigation.PushAsync(page);
        }
    }
}
