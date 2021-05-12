using Views.Binding;
using Views.Commands;
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
                    page = new LabelPage();
                    break;
                case 1:
                    page = new ButtonPage();
                    break;
                case 2:
                    page = new ViewBindingDemoPage();
                    break;
            }

            page.Title = title;
            await Navigation.PushAsync(page);
        }
    }
}
