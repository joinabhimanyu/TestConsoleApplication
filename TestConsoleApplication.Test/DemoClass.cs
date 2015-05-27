using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication.Test
{
    class DemoClass
    {
        public string GoUpper(string message)
        {
            if (message != null)
            {
                return message.ToUpper().Trim();
            }
            else
            {
                return "error";
            }
        }

        public Person GetPerson()
        {
            var p = new Person();
            p.firstname = "abhi";
            p.lastname = "chak";
            p.gender = "male";
            return p;
        }

        public int GetFibonacci(int number)
        {
            var fib = 1;
            for (int i = 1; i <= number; i++)
            {
                fib = fib * i;
            }
            return fib;
        }

        public List<Category> GetCategories()
        {
            NorthwindEntities db = new NorthwindEntities();
            var result = db.Categories.ToList<Category>();
            return result;
            
        }

        public List<Category> FindBeverages(string category_name, int category_id)
        {
            NorthwindEntities db = new NorthwindEntities();
            //var result = db.Categories.Where(m => m.Category_Name == "Beverages");
            var result = db.Categories
                                .Where(m => m.Category_ID == category_id)
                                .Where(m => m.Category_Name == category_name.Trim());
            return result.ToList<Category>();
        }

    }
}
