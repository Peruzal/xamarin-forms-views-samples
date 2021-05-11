using System;

using Xamarin.Forms;

namespace Views
{
    public class StepperPage : ContentPage
    {
        public StepperPage()
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

