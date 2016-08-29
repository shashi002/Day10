using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SparshBIOCart.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SparshBIOCart.ViewModels
{
    class CartsViewModel
    {
       static  private ObservableCollection<Cart> _cartsCollection;
        static public ObservableCollection<Cart> CartsCollection
        {
            get { return _cartsCollection; }
            set { _cartsCollection = value; }
        }
    }

}
