using Microsoft.Phone.Controls;

using Xamarin.Forms;

namespace SparshBIOCart.WinPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            SparshBIOCart.App.Init(new WinPhoneSetup());
            Content = SparshBIOCart.App.StartupPage.ConvertPageToUIElement(this);
            DispatcherSingleton = this.Dispatcher;
        }

        public static System.Windows.Threading.Dispatcher DispatcherSingleton { get; private set; }
    }
}