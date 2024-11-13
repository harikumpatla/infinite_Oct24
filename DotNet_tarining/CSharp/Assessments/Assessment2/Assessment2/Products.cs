using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class Products
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int price { get; set; }

        public Products(int productId, string productName, decimal price)
        {
            product_id = productId;
            product_name = productName;
            price = price;
        }

        public override string ToString()
        {
            return $"ID: {product_id},Name: {product_name},Price: {price:c}";
        }

    }

    class DriverClass
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>();
            Console.WriteLine("enter the number of products");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"enter product {i+1} details :");
                Console.WriteLine("product id : ");
                int productId = int.Parse(Console.ReadLine());
                Console.WriteLine("product Name : ");
                string productName = Console.ReadLine();
                Console.WriteLine("product price : ");
                decimal price = decimal.Parse(Console.ReadLine());
                products.Add(new Products(productId, productName, price));
                Console.WriteLine();
            }
            var sortedProducts = products.OrderBy(p => p.price).ToList();
            Console.WriteLine("products sorted by price :");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine(product);

            }
            Console.Read();
        }
    }
}
