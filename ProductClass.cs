using System.Collections.Specialized;
using System.Diagnostics;
using System.Xml.Linq;

internal class Program
{
    class Product
    {
        public string name;
        public int price;
        public void output()
        {
            Console.WriteLine($"{name} : {price}원");
        }
    }
    private static void Main(string[] args)
    {
        Product productA = new Product() { name = "감자", price = 2000 };
        Product productB = new Product() { name = "고구마", price = 3000 };
        productA.output();
        productB.output();
    }
}