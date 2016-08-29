
using SparshBIOCart.Async;
using SparshBIOCart.Models;
using SparshBIOCart.Mvvm;
using SparshBIOCart.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace SparshBIOCart.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        private const string _resource = "SparshBIOCart.Resources.placeholderImageSmall.png";
      

        public ProductViewModel(Product product)
        {
            Product = product;
            IconSource = AsyncImageSource.FromUriAndResource(product.IconUrl, _resource);
            NavigateToProduct = new Command(() => MessagingCenter.Send(Product, Messages.NavigateTo));
            _cartsCollection = new ObservableCollection<Product>();
            base.RaisePropertyChanged("CartTotal");
            //AddItemstoCart = new Command(async () =>
            //{
            //    bool result  =  addItem(this.Product);
            //});
        }

        public NotifyTaskCompletion<ImageSource> IconSource { get; private set; }

       public ICommand NavigateToProduct { get; private set; }

        public ICommand AddtoCartCommand { get { return new SimpleCommand(AddItemstoCart); } }

        public Product Product
        {
            get { return GetValue<Product>(); }
            set { SetValue(value); }
        }

      
     //   public ICommand AddItemstoCart { get { return new SimpleCommand(AddItem); }; }

        private ObservableCollection<Product> _cartsCollection;

        private async void AddItemstoCart( )
        {
            _cartsCollection.Add(Product);
            int x = System.Convert.ToInt32(ApplicationData.MyCartCollectionCount); 
            // System.Convert.ToInt32( ApplicationState.GetValue<string>(ApplicationFields.MyCartCollectionCount.ToString()));
            ApplicationData.MyCartCollectionCount = System.Convert.ToString(x + 1) ;
            // ApplicationState.SetValue(ApplicationFields.MyCartCollectionCount.ToString(), x++);
            base.RaisePropertyChanged("CartTotal");
        }


        public   string CartTotal {
            get {
                return string.Format("My Cart({0})", ApplicationData.MyCartCollectionCount);
            }
            set {
                int x = System.Convert.ToInt32(ApplicationData.MyCartCollectionCount); // System.Convert.ToInt32( ApplicationState.GetValue<string>(ApplicationFields.MyCartCollectionCount.ToString()));
                ApplicationData.MyCartCollectionCount = System.Convert.ToString(x++);
                
               }
        }
    }
}