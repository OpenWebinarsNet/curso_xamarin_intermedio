using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomPlatform.Controls
{
    public class ExtendedButton : Button
    {
        public static BindableProperty
            IsLoadingProperty = BindableProperty.Create(
                nameof(IsLoading), typeof(bool), typeof(ExtendedButton),
                propertyChanged: IsLoadingPropertyChanged);


        private string OldbuttonText;

        public bool IsLoading
        {
            get => (bool)GetValue(IsLoadingProperty);
            set => SetValue(IsLoadingProperty, value);
        }

        private static void IsLoadingPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var extendedButton = (ExtendedButton)bindable;
            var isLoadingValue = (bool)newValue;

            if(isLoadingValue)
            {
                extendedButton.OldbuttonText = extendedButton.Text;
                extendedButton.Text = "...";
            }
            else
            {
                extendedButton.Text = extendedButton.OldbuttonText;
            }            
        }
    }
}
