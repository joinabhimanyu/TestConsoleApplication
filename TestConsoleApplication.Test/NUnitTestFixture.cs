using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using TestConsoleApplication;

namespace TestConsoleApplication.Test
{
    [TestFixture]
    public class NUnitTestFixture
    {
        [Test]
        public void SumOfTwoNumbers()
        {
            Assert.AreEqual(10, 5 + 5);
        }

        [Test]
        public void AreTheTwoNumbersSame()
        {
            Assert.AreSame("a", "a");
        }

        [Test]
        public void TestProgram()
        {
            DemoClass cs = new DemoClass();
            var message = "abhimanyu";
            var expected = "asdfsdaf";

            var result = cs.GoUpper(message.Trim());
            Assert.AreEqual(message.ToUpper().Trim(), result.Trim());
            //Assert.AreSame(expected.ToUpper().Trim(), result.Trim());
        }

        [Test]
        public void TestPerson()
        {
            DemoClass cs = new DemoClass();
            var p = new Person();
            p.firstname = "abhi";
            p.lastname = "chak";
            p.gender = "male";

            var result = cs.GetPerson();

            Assert.IsInstanceOf<Person>(result);

            //Assert.AreEqual(p.firstname, result.firstname);
            //Assert.AreEqual(p.lastname, result.lastname);
            //Assert.AreEqual(p.gender, result.gender);
        }

        [Test]
        public void TestFibonacci()
        {
            var number = 3;
            DemoClass cs = new DemoClass();
            var result = cs.GetFibonacci(number);

            var fib = 1;
            for (int i = 1; i <= number; i++)
            {
                fib = fib * i;
            }

            Assert.AreEqual(fib, result);
            


        }

        [Test]
        public void TestCategory()
        {
            DemoClass cs = new DemoClass();
            var result = cs.GetCategories();
            if (result.Count > 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void TestBeverages()
        {
            DemoClass cs = new DemoClass();
            var category_id = 4;
            var category_name = "Dairy Products";
            var result = cs.FindBeverages(category_name.Trim(), category_id);
            if (result.Count > 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

    }
}

