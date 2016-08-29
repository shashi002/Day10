using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparshBIOCart.Views
{
    public partial class ProductPage
    {
        public ProductPage()
        {  
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            Views.ProductsListPage plp = new ProductsListPage();
            Navigation.PushAsync(plp);
            return true;
        }
    }
}
