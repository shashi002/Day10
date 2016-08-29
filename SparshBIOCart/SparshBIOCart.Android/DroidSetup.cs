using Autofac;
using SparshBIOCart.Droid.Services;
using SparshBIOCart.Services;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(SparshBIOCart.Views.AboutPage), typeof(SparshBIOCart.Droid.Renderers.DroidAboutPageRenderer))]

namespace SparshBIOCart.Droid
{
    public class DroidSetup : AppSetup
    {
        protected override void RegisterDepenencies(ContainerBuilder cb)
        {
            base.RegisterDepenencies(cb);

            cb.RegisterType<DroidLogger>().As<ILogger>().SingleInstance();
            cb.RegisterType<DroidScanner>().As<IScanner>().SingleInstance();
            cb.RegisterType<DroidThemer>().As<IThemer>().SingleInstance();
        }
    }
}