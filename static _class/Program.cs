using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static__class
{
    internal class Program
    {
        static class Product
        {
            public static int ProductId;
            public static string ProductName;
            public static string ProductDescription;
            public static int ProductPrice;

            static Product()
            {
                ProductId = 201;
                ProductName = "Volvo";
                ProductDescription = "Good Product";
                ProductPrice = 500;
            }
            public static void productDetails()
            {
                Console.WriteLine("Product Id = {0}", ProductId);
                Console.WriteLine("Product name = {0}", ProductName);
                Console.WriteLine("Product description = {0}", ProductDescription);
                Console.WriteLine("Product price = {0}", ProductPrice);
            }
            public static void productDiscount()
            {
                int d_amount = ProductPrice / 5;
                Console.WriteLine("Your discount price is = {0}", d_amount);
                Console.WriteLine("Total cost price is = {0}", ProductPrice - d_amount);
            }

        }
        static void Main(string[] args)
        {
            //Product.getProducetDetails();
            //Product.getDiscount();

            Product.productDetails();
            Product.productDiscount();
            Console.ReadKey();
        }
    }
}
