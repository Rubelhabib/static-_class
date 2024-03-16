using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace static__class
{
    static class Product
    {
        public static int ProductId;
        public static string ProductName;
        public static int ProductPrice;

        static Product()
        {
            ProductId = 101;
            ProductName = "Audi";
            ProductPrice = 6000;
        }

        public static void getProducetDetails()
        {
            Console.WriteLine($"Product id is: {ProductId} \n Product name is: {ProductName} \n Product price is : {ProductPrice}");
        }
        
        public static void getDiscount()
        {
            int d_Amount = ProductPrice / 5;
            Console.WriteLine("Your discount price is: = {0}",d_Amount);
            Console.WriteLine("Total cost product is : = {0}",(ProductPrice - d_Amount));
        }
            
            
    }
}
