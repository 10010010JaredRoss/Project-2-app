using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;

namespace ButtonDemos
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });

            BindingContext = this;
        }

        public ICommand NavigateCommand { private set; get; }
    }
}
