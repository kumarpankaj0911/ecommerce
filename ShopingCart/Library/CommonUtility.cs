using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace Library
{
    public class CommonUtility
    {
        public CartDetails CartDiscount(List<ProductDetails> productDetails, decimal discountPrecent = 0)
        {
            CartDetails cartDetails = new CartDetails();

            foreach (ProductDetails product in productDetails)
            {
                if (product.ProductType.Equals(ProductTypeEnum.Groceries))
                {
                    product.ProductDiscount = 0;
                    cartDetails.ProductDetials.Add(product);
                }
                else
                {
                    product.ProductDiscount = decimal.Round((product.ProductPrice * discountPrecent) / 100, 2, MidpointRounding.AwayFromZero);
                    cartDetails.ProductDetials.Add(product);

                }

            }
            cartDetails.ProductSubTotal = cartDetails.ProductDetials.Sum(k => k.ProductPrice);


            cartDetails.ProductDiscountTotal = decimal.Round(cartDetails.ProductDetials.Sum(k => k.ProductDiscount), 2, MidpointRounding.AwayFromZero);
            cartDetails.ProductGrandTotal = cartDetails.ProductSubTotal - cartDetails.ProductDiscountTotal;
            cartDetails.ProductDiscountApplied = discountPrecent;
            cartDetails.ProductAmpountPayable = cartDetails.ProductGrandTotal - ((cartDetails.ProductGrandTotal - (cartDetails.ProductGrandTotal % 100)) / 100 * 5);//.    For every $100 on the bill, there would be a $5 discount (e.g. for $ 990, you get $ 45 as a discount).
            return cartDetails;
        }
    }
}
