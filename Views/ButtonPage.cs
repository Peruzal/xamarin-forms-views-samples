using System;

using Xamarin.Forms;

namespace Views
{
    public class ButtonPage : ContentPage
    {
        public ButtonPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

