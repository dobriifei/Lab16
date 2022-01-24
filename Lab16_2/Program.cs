using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxProduct = products[0];
            foreach (Product e in products)
            {
                if (e.Price > maxProduct.Price)
                {
                    maxProduct = e;
                }
            }
            Console.WriteLine($"{maxProduct.Kod} {maxProduct.Name} {maxProduct.Price}");
            Console.ReadKey();
        }
    }
}
