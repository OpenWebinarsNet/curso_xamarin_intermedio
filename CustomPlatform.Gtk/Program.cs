using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.GTK;

namespace CustomPlatform.GTK
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Xamarin.Forms.Forms.Init();
            var app = new CustomPlatform.App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("CustomPlatform");
            window.Show();
            Gtk.Application.Run();
            
        }
    }
}
