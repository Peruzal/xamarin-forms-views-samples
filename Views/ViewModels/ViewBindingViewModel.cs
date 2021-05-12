using System;
namespace Views.ViewModels
{
    public class ViewBindingViewModel
    {
        public string TextTitle => "ROTATION";
        public string[] Months { get => new string[] { "Jan", "Feb", "Mar" }; }
    }
}
