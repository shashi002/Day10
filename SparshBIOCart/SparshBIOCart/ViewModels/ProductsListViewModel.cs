
using SparshBIOCart.Commands;
using SparshBIOCart.Models;
using SparshBIOCart.Services;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace SparshBIOCart.ViewModels
{
    public class ProductsListViewModel : BaseViewModel
    {
        private readonly IAppNavigation _navi;
        private readonly LogOutCommand _logOut;

        public ProductsListViewModel(IAppNavigation navi, LogOutCommand logOut)
        {
            _navi = navi;
             //  _logOut = logOut;
            Title = "Products Page";
            AboutCommand = new Command(async () => await _navi.ShowAbout());
            MessagingCenter.Subscribe<Product>(this, Messages.NavigateTo, NavigateToProduct);
            base.RaisePropertyChanged("CartTotal");
        }

        public List<ProductViewModel> Products
        {
            get { return GetValue<List<ProductViewModel>>(); }
            set { SetValue(value); }
        }

        public string Title
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        private async void NavigateToProduct(Product product)
        {
            await _navi.ShowProduct(product);
        }

        public string CartTotal
        {
            get
            {
                return string.Format("My Cart({0})", ApplicationData.MyCartCollectionCount);
            }
            set
            {
                int x = System.Convert.ToInt32(ApplicationData.MyCartCollectionCount); // System.Convert.ToInt32( ApplicationState.GetValue<string>(ApplicationFields.MyCartCollectionCount.ToString()));
                ApplicationData.MyCartCollectionCount = System.Convert.ToString(x++);
            }
        }

        public ICommand LogOut { get { return _logOut; } }

        public ICommand AboutCommand { get; private set; }
    }
}