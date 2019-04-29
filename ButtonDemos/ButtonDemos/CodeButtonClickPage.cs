using System;
using Xamarin.Forms;

namespace ButtonDemos
{
    public class CodeButtonClickPage : ContentPage
    {
        public CodeButtonClickPage ()
        {
            Title = "Code Button Click";

            Label label = new Label
            {
                Text = "Test page number two. filling in words to see how size space goes.",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };


            Content = new StackLayout
            {
                Children =
                {
                    label
                }
            };
        }
    }
}