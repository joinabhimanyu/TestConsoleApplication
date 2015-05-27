using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    class Person
    {
        public string name { get; set;}
        public string title { get; set; }

        public Person(string name, string title)
        {
            this.name = name;
            this.title = title;
        }

    }

    class MyGeneric<T, U> where T: Person
                          where U: struct
    {
        private T variable_1;
        private U variable_2;
        private Person p;

        public MyGeneric(string name, string title)
        {
            p = (Person)variable_1;
            p = new Person(name.Trim(), title.Trim());
            variable_2 = new U();
        }

        public void show()
        {
            Console.WriteLine("the type is: " + p.GetType().ToString().Trim());
            Console.WriteLine("the type is: " + variable_2.GetType().ToString().Trim());
        }

        public void showValues()
        {
            Console.WriteLine("Name: " + p.name);
            Console.WriteLine("Title: " + p.title);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Enter title: ");
                var title = Console.ReadLine();

                MyGeneric<Person, int> obj1 = new MyGeneric<Person, int>(name.Trim(), title.Trim());             
                obj1.show();
                Console.WriteLine("The values are: ");
                obj1.showValues();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString().Trim() + ex.InnerException.ToString().Trim());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
