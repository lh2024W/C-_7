using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__7
{
    class Product
    {
        List<Product> products = new List<Product>();
        public string name;
        public int count;
        public double price;
        public int discount;

        public Product(): this ("Не задано название продукта", 0, 0.00, 0) {}
        public Product(string name, int count, double price, int discount)
        {
        this.name = name;
        this.count = count;
        this.price = price;
        this.discount = discount;
        }

        public void PrintProduct()
        {
            Console.WriteLine(name);
            Console.WriteLine(count + "x" + price + "...................." + price);
            Console.WriteLine("Скидка: " + discount + "%");
        }

        public override string ToString()
        {
            return name + " " + count + "x" + price + "\nСкидка: " + discount + "%";
        }

       
    }
}
