using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Employee : IShopping
    {
        CommonUtility commonUtility;
        public Employee()
        {
            commonUtility = new CommonUtility();
        }

        public CartDetails ShoppingCart(List<ProductDetails> productDetails)
        {
            return commonUtility.CartDiscount(productDetails, 30);
        }
    }
}
