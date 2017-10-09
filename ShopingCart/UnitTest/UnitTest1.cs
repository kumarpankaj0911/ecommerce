using BusinessLogic;
using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmplyee()
        {
           
            UserDetails userDetails = new UserDetails();
            List<ProductDetails> productDetails = new List<ProductDetails>();

            userDetails.UserID = 111;
            userDetails.UserName = "Employee";
            userDetails.UserType = UserTypeEnum.Employee;

           


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


            IShoppingStrategy shoppingStrategy = new ShoppingStrategy();
            IShopping shopping = shoppingStrategy.CreateShoppingInstance(userDetails.UserType);
            CartDetails carDetails = shopping.ShoppingCart(productDetails);
            decimal expectedDiscout = 30;
            Assert.AreEqual(expectedDiscout, carDetails.ProductDiscountApplied);
        }


        [TestMethod]
        public void TestAffiliate()
        {
           
            UserDetails userDetails = new UserDetails();
            List<ProductDetails> productDetails = new List<ProductDetails>();

            userDetails.UserID = 112;
            userDetails.UserName = "Affiliate";
            userDetails.UserType = UserTypeEnum.Affiliate;

           



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

            IShoppingStrategy shoppingStrategy = new ShoppingStrategy();
            IShopping shopping = shoppingStrategy.CreateShoppingInstance(userDetails.UserType);
            CartDetails carDetails = shopping.ShoppingCart(productDetails);
            decimal expectedDiscout = 10;
            Assert.AreEqual(expectedDiscout, carDetails.ProductDiscountApplied);
        }

        [TestMethod]
        public void TestCustomer()
        {
            
            UserDetails userDetails = new UserDetails();
            List<ProductDetails> productDetails = new List<ProductDetails>();

            userDetails.UserID = 113;
            userDetails.UserName = "Customer";
            userDetails.UserType = UserTypeEnum.Customer;

           


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

            IShoppingStrategy shoppingStrategy = new ShoppingStrategy();
            IShopping shopping = shoppingStrategy.CreateShoppingInstance(userDetails.UserType);
            CartDetails carDetails = shopping.ShoppingCart(productDetails);
            decimal expectedDiscout = 5;
            Assert.AreEqual(expectedDiscout, carDetails.ProductDiscountApplied);
        }

        [TestMethod]
        public void TestOther()
        {
           
            UserDetails userDetails = new UserDetails();
            List<ProductDetails> productDetails = new List<ProductDetails>();

            userDetails.UserID = 111;
            userDetails.UserName = "Other";
            userDetails.UserType = UserTypeEnum.Other;
            

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

            IShoppingStrategy shoppingStrategy = new ShoppingStrategy();
            IShopping shopping = shoppingStrategy.CreateShoppingInstance(userDetails.UserType);
            CartDetails carDetails = shopping.ShoppingCart(productDetails);
            decimal expectedDiscout = 0;
            Assert.AreEqual(expectedDiscout, carDetails.ProductDiscountApplied);
        }
    }
}
