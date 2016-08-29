namespace SparshBIOCart.Views
{
    public partial class ProductsListPage
    {
        public ProductsListPage()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            Views.CategoriesListPage clp = new CategoriesListPage();
            Navigation.PushAsync(clp);
            return true;
        }
    }
}