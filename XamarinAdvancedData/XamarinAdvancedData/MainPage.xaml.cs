using Akavache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using Xamarin.Forms;
using System.Reactive.Threading.Tasks;
using Refit;
using XamarinAdvancedData.Services;

namespace XamarinAdvancedData
{
	public partial class MainPage : ContentPage
	{
        private IBlobCache localData;

		public MainPage()
		{
			InitializeComponent();
		}

        private void InitializeAkavache()
        {
            BlobCache.ApplicationName = "OpenWebinars";
            BlobCache.EnsureInitialized();
            localData = BlobCache.LocalMachine;
        }

        private async void InsertObjects()
        {
            var postService = RestService.For<IHttpCallsJsonPlaceHolder>("http:\\jsonplaceholder.com");

            var posts = await postService.GetPosts();

            localData.InsertObject("Posts", posts);
        }

        private async void RecoverObjects()
        {
            var animal = (await localData.GetObject<Animal>("Animals").ToTask());

            Settings.Name = "JoseMontero";
        }


	}
}
