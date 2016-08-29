using Microsoft.Phone.Controls;
using System;
using System.Linq;

namespace SparshBIOCart.WinPhone.Views
{
    public partial class WinPhoneAboutPage : PhoneApplicationPage
    {
        public WinPhoneAboutPage()
        {
            this.DataContext = SparshBIOCart.App.AboutViewModel;
            InitializeComponent();
        }
    }
}