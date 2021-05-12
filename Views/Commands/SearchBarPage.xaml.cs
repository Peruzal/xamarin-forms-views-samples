using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Views.Commands
{
    public partial class SearchBarPage : ContentPage
    {
        public ObservableCollection<string> Cities { get; set; } = new ObservableCollection<string>();

        public SearchBarPage()
        {
           
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Cities.Add("Johannesburg");
            Cities.Add("Windhoek");
        }

    }
}
