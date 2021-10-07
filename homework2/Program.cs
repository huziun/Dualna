using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
        }

        static void Task1()
        {
            bool name = false;
            Console.WriteLine("Enter 3 float (x,y) numbers: ");
            for (int i = 0; i < 3; i++)
            {
                float a = Convert.ToSingle(Console.ReadLine());
                if (a < 5.0 && a > -5.0)
                {
                    name = true;
                }
                else
                {
                    name = false;
                    break;
                }
            }
            string result = (name) ? "True" : "False";
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static void Task2()
        {
            Console.WriteLine("Enter 3 numbers: ");
            int one = Convert.ToInt32(Console.ReadLine());
            int count = 0, max = one, min = one;
            do
            {
                int two_numbers = Convert.ToInt32(Console.ReadLine());
                if (min > two_numbers)
                {
                    min = two_numbers;
                }
                if (max < two_numbers)
                {
                    max = two_numbers;
                }
                count++;
            } while (count < 2);
            Console.WriteLine("Max: {0} \nMin: {1}", max, min);
            Console.ReadLine();
        }

        static void Task3()
        {
            int error = Convert.ToInt32(Console.ReadLine());
            string result = Enum.GetName(typeof(Errors), error);
            if (error < 400 || error > 416)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("Erorr name: {0}.",result);
            }
            Console.ReadLine();
        }
        static void Task4()
        {
            var dog = new Dog();
            dog.name = "Maks";
            dog.mark = "Buldog";
            dog.age = 12;
            Console.WriteLine(dog);
            Console.ReadLine();
        }
    }
    public enum Errors
    {
        Error_Bad_Request = 400,
        Unauthorized = 401,
        Payment_Required = 402,
        Forbidden = 403,
        Not_Found = 404,
        Method_Not_Allowed = 405,
        Not_Acceptable = 406,
        Proxy_Authentication_Required = 407,
        Request_Timeout =  408,
        Conflict = 409,
        Gone = 410,
        Length_Required = 411,
        Precondition_Failed = 412,
        Payload_Too_Large = 413,
        URI_Too_Long = 414,
        Unsupported_Media_Type = 415,
        Range_Not_Satisfiable = 416
    }
    public struct Dog
    {
        public string name;
        public string mark;
        public int age;
        public override string ToString() => $"({name},{mark},{age})";
    }
}

