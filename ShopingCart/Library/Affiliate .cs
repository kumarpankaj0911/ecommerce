using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Affiliate : IShopping
    {

        CommonUtility commonUtility;
        public Affiliate()
        {
            commonUtility = new CommonUtility();
        }

        public CartDetails ShoppingCart(List<ProductDetails> productDetails)
        {
            return commonUtility.CartDiscount(productDetails, 10);
        }


    }
}
