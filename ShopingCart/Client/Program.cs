using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using BusinessLogic;


namespace Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            new ShoppingClient().Shop();
            
        }

    }

    public class ShoppingClient
    {
        public UserDetails userDetails;
        public List<ProductDetails> productDetails = null;

        public  ShoppingClient()
        {

            userDetails = new UserDetails();
            userDetails.UserID = 111;
            userDetails.UserName = "TEST";
            //TODO:Update usertype to see calculation for ther users
            userDetails.UserType = UserTypeEnum.Other;

            productDetails = new List<ProductDetails>();
            ProductDetails product = new ProductDetails();
            product.ProdctName = "Product1";
            product.ProductId = "PRO1";
            product.ProductPrice = 120.50M;
            product.ProductType = ProductTypeEnum.Cosmetic;
            productDetails.Add(product);
            ProductDetails product2 = new ProductDetails();
            product2.ProdctName = "Product2";
            product2.ProductId = "PRO2";
            product2.ProductPrice = 500.75M;
            product2.ProductType = ProductTypeEnum.FoodItem;
            productDetails.Add(product2);

            ProductDetails product3 = new ProductDetails();
            product3.ProdctName = "Product3";
            product3.ProductId = "PRO3";
            product3.ProductPrice = 320.02M;
            product3.ProductType = ProductTypeEnum.Cosmetic;
            productDetails.Add(product3);

            ProductDetails product4 = new ProductDetails();
            product4.ProdctName = "Product4";
            product4.ProductId = "PRO4";
            product4.ProductPrice = 420.95M;
            product4.ProductType = ProductTypeEnum.Groceries;
            productDetails.Add(product4);
        }

        public void Shop()
        {
            IShoppingStrategy shoppingStrategy = new ShoppingStrategy();
            IShopping shopping = shoppingStrategy.CreateShoppingInstance(userDetails.UserType);
            CartDetails carDetails = shopping.ShoppingCart(productDetails);

            Console.WriteLine($"*******Product Details for {userDetails.UserName} User Type: {userDetails.UserType.ToString()} *********");
            foreach (ProductDetails product in carDetails.ProductDetials)
            {
                Console.WriteLine($"Product Name: {product.ProdctName}  Prodct Type:  {product.ProductType.ToString()}  Prouct Discount:  {product.ProductDiscount}  Product Price {product.ProductPrice}");
            }

            Console.WriteLine("*********************************************************");
            Console.WriteLine($" Sub Total: {carDetails.ProductSubTotal}");
            Console.WriteLine($" Discount Applied: {carDetails.ProductDiscountApplied} %");
            Console.WriteLine($" Total Discount: -{carDetails.ProductDiscountTotal}");
            Console.WriteLine($" Total Amount: {carDetails.ProductGrandTotal}");
            Console.WriteLine($" Net Amount Payable: {carDetails.ProductAmpountPayable}");

            Console.WriteLine("****************Thank you***********************");

            Console.ReadLine();
        }
    }

}
