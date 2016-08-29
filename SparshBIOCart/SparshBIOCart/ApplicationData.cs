using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparshBIOCart
{
    public class ApplicationData
    {
        public static string MyCartCollectionCount
        {
            get {

                return  ApplicationState.GetValue<string>(ApplicationFields.MyCartCollectionCount.ToString());
      
            }
            set { ApplicationState.SetValue(ApplicationFields.MyCartCollectionCount.ToString(), Convert.ToString(value));  }
        }
    }
}
