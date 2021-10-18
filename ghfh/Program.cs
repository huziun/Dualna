using System;
using System.Collections.Generic;

namespace ghfh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Human = new List<Person>();
            for (int i = 0; i < 6; i++)
            {
                Human.Add(new Person());
                Human[i].Input();
                int age = Human[i].Age();
                if(age < 17)
                {
                    Human[i].ChangeName("Very Young");
                }
            }
            for(int i = 0; i < 6; i++)
            {
                Human[i].Output();
            }
            for(int i = 0; i < 6; i++)
            {
                
                if(i == 5)
                {
                    break;
                }
                for(int j = 0; j < 6; j++)
                {
                    if (Human[i] == Human[j] && i != j)
                    {
                        Console.WriteLine("People with the same name: ");
                        Human[i].Output();
                        Human[j].Output();
                    }
                    
                }
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        private string name;
        private DateTime birthYear;
       
        public Person(string b, int a){
            this.name = b;
            DateTime year = new DateTime(a, 1, 1, 1, 1, 1);
            this.birthYear = year;
        }
        public Person()
        {
            this.name = "Monika";
            this.birthYear = new DateTime(2008, 1, 1, 1, 1, 1);
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public DateTime BirthYear
        {
            get
            {
                return this.birthYear;
            }
        }
        public void Input()
        {
            Console.WriteLine("Enter name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter birthday year: ");
            int a = Convert.ToInt32(Console.ReadLine());
            DateTime year = new DateTime(a, 1, 1, 1, 1, 1);
            this.birthYear = year;
        }
        public void Output()
        {
            this.ToString();
        }
        public void ToString()
        {
            Console.WriteLine("Name: {0}\nBirthday year: {1}", this.name, this.birthYear.Year);
        }
        public int Age()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - this.birthYear.Year;
            Console.WriteLine("Age: {0}", age);
            return age;
        }
        public void ChangeName(string NewName)
        {
            this.name = NewName;
        }
        public static bool operator == (Person first, Person second)
        {
            return first.name == second.name;
        }
        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }
    }
}
