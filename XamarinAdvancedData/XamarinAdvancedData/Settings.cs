using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinAdvancedData
{
    public static class Settings
    {
        private static ISettings CurrentSettings => Plugin.Settings.CrossSettings.Current;

        public static string Name
        {
            get => CurrentSettings.GetValueOrDefault("username", "NuevoUsuario");
            set => CurrentSettings.AddOrUpdateValue("username", value);
        }
    }
}
