[assembly:Xamarin.Forms.Dependency(typeof(CustomPlatform.Droid.Services.PhoneService))]
namespace CustomPlatform.Droid.Services
{
    using Android.App;
    using Android.Content;
    using CustomPlatform.Services;

    public class PhoneService : IPhoneService
    {
        public void Call(string phoneNumber)
        {
            Intent intent = new Intent(Intent.ActionDial);
            intent.SetData(Android.Net.Uri.Parse($"tel:{phoneNumber}"));
            Application.Context.StartActivity(intent);
        }
    }
}