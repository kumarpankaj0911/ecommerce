using System.Collections.Generic;

namespace BusinessLogic
{
    public class CartDetails
    {
        public CartDetails()
        {
            ProductDetials = new List<ProductDetails>();
        }
        public List<ProductDetails> ProductDetials { get; set; }
        public UserDetails UserDetials { get; set; }
        public decimal ProductSubTotal { get; set; }
        public decimal ProductGrandTotal { get; set; }
        public decimal ProductDiscountTotal { get; set; }
        public decimal ProductDiscountApplied { get; set; }
        public decimal ProductAmpountPayable { get; set; }
    }
}
