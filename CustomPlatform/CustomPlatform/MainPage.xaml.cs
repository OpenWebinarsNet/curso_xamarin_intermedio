using CustomPlatform.Controls;
using CustomPlatform.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomPlatform
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void ExtendedButton_Clicked(object sender, EventArgs e)
        {
            (sender as ExtendedButton).IsLoading = true;

            //DependencyService.Get<IPhoneService>().Call("6000000");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            LabelWelcome.Text = "Yay!";
        }
    }
}
