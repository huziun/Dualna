using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghfh
{
    class Program
    {
        static void Main(string[] args)
        {
            Car x1 = new Car();
            Car x2 = new Car();
            x1.Input();
            x1.Print();
            x1.ChangePrice();
            Console.ReadLine();
        }
    }
    class Car
    {
        public double price;
        public const string CompanyName = "WW";
        public string name;
        private string color;
        public Car()
        {
            this.name = "WW Golf 7";
            this.color = "red";
        }
        public Car(string b, string a){
            this.name = b;
            this.color = a;
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public void Input()
        {
            Console.WriteLine("Enter name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter color: ");
            this.color = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine($"Name: {name}\nColor: {color}\nCompany: {CompanyName}");
        }
        public void ChangePrice( )
        {
            Console.WriteLine("Enter price: ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter discount (%): ");
            double x = Convert.ToDouble(Console.ReadLine());
            double NewPrice = price - ((price * x) / 100);
            Console.WriteLine("New price {0}", NewPrice);
        }
    }
}
