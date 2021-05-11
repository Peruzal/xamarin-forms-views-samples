using System;

using Xamarin.Forms;

namespace Views
{
    public class DatePickerPage : ContentPage
    {
        public DatePickerPage()
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

