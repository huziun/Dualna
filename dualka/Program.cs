using System;

namespace dualka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a + b: "+ (a + b));
            Console.WriteLine("a - b: " + (a - b));
            Console.WriteLine("a * b: " + (a * b));
            if (b == 0)
            {
                Console.WriteLine("a / b = Error.");
            }
            else
            {
                Console.WriteLine("a / b: " + (a / b));
            }
            //--------------------
            Console.WriteLine("How are you?");
            string feel = Console.ReadLine();
            Console.WriteLine("You are " + feel + ".");
            //--------------------
            Console.WriteLine("Enter 3 char: ");
            char one = Convert.ToChar(Console.ReadLine());
            char two = Convert.ToChar(Console.ReadLine());
            char three = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("You enter " + one + ", " + two + ", " + three + ".");
            //--------------------
            Console.WriteLine("Enter 2 numbers: ");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            if(first > 0 && second > 0)
            {
                check = true;
            }
            Console.WriteLine("First and second numbers are positive: " + check);
            //--------------------
            Console.WriteLine("Enter length of square: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            if (a1 == 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                if (a1 < 0)
                {
                    a1 *= -1;
                }
                Console.WriteLine("Area: " + (a1 * a));
                Console.WriteLine("Perimeter: " + (4 * a1));
            }
            //--------------------
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you, " + name+"?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0 || age > 120)
            {
                Console.WriteLine("It is impossible!");
            }
            Console.WriteLine("Your name is " + name + ". \nYour age is " + age);
            //--------------------
            double pi = 3.14;
            Console.WriteLine("Enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            if (radius <= 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine("Length: " + (2 * pi * radius));
                Console.WriteLine("Area: " + (pi * pi * radius));
                Console.WriteLine("Volume: " + ((4 / 3) * pi * radius * radius * radius));
            }
        }
    }
}
