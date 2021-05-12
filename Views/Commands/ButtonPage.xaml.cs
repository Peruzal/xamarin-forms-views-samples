using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace Views.Commands
{
    public partial class ButtonPage : ContentPage
    {
        public ICommand DisplayAlertCommand { get; private set; }

        public ButtonPage()
        {
            InitializeComponent();

            DisplayAlertCommand = new Command(ShowAlert);

            BindingContext = this;
        }

        private void ShowAlert(object obj)
        {
            Debug.WriteLine("Button clicked");
        }
    }
}
