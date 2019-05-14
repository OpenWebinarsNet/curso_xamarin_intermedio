[assembly: Xamarin.Forms.ExportRenderer(typeof(CustomPlatform.Controls.ExtendedButton),
                                        typeof(CustomPlatform.Droid.Renderers.ExtendedButtonRenderer))]

namespace CustomPlatform.Droid.Renderers
{
    using System.ComponentModel;
    using Android.Content;
    using CustomPlatform.Controls;
    using Xamarin.Forms.Platform.Android;

    public class ExtendedButtonRenderer : ButtonRenderer
    {
        public ExtendedButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
                return;                          
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if(e.PropertyName == ExtendedButton.IsLoadingProperty.PropertyName)
            {
                if((Element as ExtendedButton).IsLoading)
                {
                    Control.TextSize = 30;
                }
            }
        }
    }
}