using SparshBIOCart.Async;
using SparshBIOCart.Commands;
using SparshBIOCart.Models;
using SparshBIOCart.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SparshBIOCart.ViewModels
{
    public class CategoriesListViewModel : BaseViewModel
    {
        private readonly LogOutCommand _logOut;
        private readonly IAppNavigation _navi;
        private readonly IScanner _scanner;
        private readonly Command _searchCommand;
        private readonly IProductService _service;

        public CategoriesListViewModel(IProductService service, IAppNavigation navi, IScanner scanner, LogOutCommand logOut)
        {
            _service = service;
            _navi = navi;
            _scanner = scanner;
            _logOut = logOut;

            MessagingCenter.Subscribe<Category>(this, Messages.NavigateTo, NavigateToCategory);

            _searchCommand = new Command(Search, () => !string.IsNullOrWhiteSpace(SearchTerm));
            ScanCommand = new Command(async () =>
            {
                var result = await _scanner.Scan();

                SearchTerm = result.Text;
                Search();
            });

            AboutCommand = new Command(async () => await _navi.ShowAbout());

            Categories = new NotifyTaskCompletion<List<CategoryViewModel>>(GetCategories());

             base.RaisePropertyChanged("CartTotal");
        }

        public NotifyTaskCompletion<List<CategoryViewModel>> Categories { get; private set; }

        public ICommand LogOut { get { return _logOut; } }

        public ICommand ScanCommand { get; private set; }

        public ICommand SearchCommand { get { return _searchCommand; } }

        public ICommand AboutCommand { get; private set; }

        public string SearchTerm
        {
            get { return GetValue<string>(); }
            set
            {
                SetValue(value);
                _searchCommand.ChangeCanExecute();
            }
        }

        private async Task<List<CategoryViewModel>> GetCategories()
        {
            var names = await _service.GetCategories();
            return names.Select(n => new CategoryViewModel(n)).ToList();
        }

        private async void NavigateToCategory(Category cat)
        {
            var items = (await _service.GetProductsForCategory(cat.Name))
                .OrderByDescending(i => i.Rating)
                .ToList();

            await _navi.ShowProductList(items, cat.Name);
        }

        private async void Search()
        {
            var items = (await _service.Search(SearchTerm))
                        .OrderByDescending(i => i.Rating)
                        .ToList();

            await _navi.ShowProductList(items, SearchTerm, true);

            SearchTerm = string.Empty;
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
                ApplicationData.MyCartCollectionCount = System.Convert.ToString(x+1);
            }
        }
    }
}