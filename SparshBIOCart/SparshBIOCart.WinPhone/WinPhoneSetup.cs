using Autofac;
using SparshBIOCart.Services;
using SparshBIOCart.WinPhone.Services;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(SparshBIOCart.Views.AboutPage), typeof(SparshBIOCart.WinPhone.Views.WinPhoneAboutPageRenderer))]
namespace SparshBIOCart.WinPhone
{
    public class WinPhoneSetup : AppSetup
    {
        protected override void RegisterDepenencies(ContainerBuilder cb)
        {
            base.RegisterDepenencies(cb);

            cb.RegisterType<WinPhoneLogger>().As<ILogger>().SingleInstance();
            cb.RegisterType<WinPhoneScanner>().As<IScanner>().SingleInstance();
            //cb.RegisterType<WinPhoneThemer>().As<IThemer>().SingleInstance();
        }
    }
}