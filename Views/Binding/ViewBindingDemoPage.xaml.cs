using System;
using System.Collections.Generic;
using Views.ViewModels;
using Xamarin.Forms;

namespace Views.Binding
{
    public partial class ViewBindingDemoPage : ContentPage
    {
        public ViewBindingDemoPage()
        {
            InitializeComponent();

            BindingContext = new ViewBindingViewModel();
        }
    }
}
