using System.Diagnostics;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace C__7
{
    class Check
    {
        public string shopInfo;
        public DateTime date;
        public long checkNumber;
        public long card;
        public double sum;
        public long codeAvtorization;
        public string adressDelivery;
        public long docNumber;
        public double sumNDS;
        public string website;
        public string adress;
        List<Product> products = new List<Product>();

        public Check () : this (0, 00.00, "Не указано")
        {
            //Console.WriteLine("main c-tor");
        }

        public Check(long card, double sum, string adressDelivery)//main c-tor
        {
            var rand = new Random ();

            shopInfo = "ДНС 2530 г.Одесса, Одесская область, ул.Д.Донского 25,\n т.0485224663";
            date = DateTime.Now;
            checkNumber = rand.Next(0, 1000);
            this.card = card;
            this.sum = sum;
            codeAvtorization = rand.Next(0, 1000000000);
            this.adressDelivery = adressDelivery;
            docNumber = rand.Next(0, 10000000);
            sumNDS = (sum * 20)/100;
            website = "ABC-shop.com";
            adress = "65001 г.Одесса, Одесская область, ул.Д.Донского 25/2";

            //Console.WriteLine("c-tor with params");
        }

        public void PrintCheck(Product product)
        {
            Console.WriteLine(shopInfo);
            Console.WriteLine(date + " " + sum * product.count + " " + "Чек " + checkNumber);
            Console.WriteLine("Оплата");
            Console.WriteLine("Карта: " + card);
            Console.WriteLine ("Сумма (грн.): " + sum * product.count);
            Console.WriteLine("ОДОБРЕНО");
            Console.WriteLine("Код авторизации: " + codeAvtorization);
            Console.WriteLine("=====================================");
            Console.WriteLine();
            Console.WriteLine("Вами заказан товар с выдачей по адресу: ");
            Console.WriteLine(adressDelivery);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("ТОВАРНЫЙ ЧЕК");
            Console.WriteLine("Документ - Е" + docNumber);
            Console.WriteLine("**************************************");
            Console.WriteLine(product.ToString());
            Console.WriteLine("Сумма НДС 20%................." + sumNDS);
            Console.WriteLine("**************************************");
            Console.WriteLine("Всю информацию можно получить на сайте: " + website);
            Console.WriteLine("Адресдля направления письменных претензий: \n" + adress);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Итог к оплате......................." + sum*product.count);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("ИТОГ                            =" + sum * product.count);
            Console.WriteLine("Сумма НДС 20%.................." + sumNDS);
            Console.WriteLine();
        }

        public void PrintProduct(Product product)
        {
            Console.WriteLine(product.name);
            Console.WriteLine(product.count + "x" + product.price + "...................." + product.price);
            Console.WriteLine("Скидка: " + product.discount + "%");
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Check c = new Check();
            //Product p = new Product();
            //c.PrintCheck(p);
            
            Check c = new Check(495522554466, 4199.00, "г.Одесса ул.Малиновая 5 кв.6");
            Product p = new Product();
            p = new Product("Смартфон ВQ 6525FD FEST 2/16GB 45/LTE/2Mpx/2200/Black \n[Гарантия - 12 мес.]", 2, 4199.00, 15);
            //p.PrintProduct();
            //c.AddProduct(p);
            //c.PrintProduct(p);
            c.PrintCheck(p);
            
        }
    }
}
