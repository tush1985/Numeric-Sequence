using NUnit.Framework;
using NumberSequence;
using System.Collections.Generic;
using System;
using System.Collections;
using NumberSequence.Models;

namespace NumberSequence.Tests
{
    [TestFixture]
    public class SequenceNumericTest
    {

        SequenceNumeric sut;
        //Run before each test
        [SetUp]
        public void BeforeEachTest()
        {

            Console.WriteLine("Before {0}", TestContext.CurrentContext.Test.Name);
            sut = new NumberSequence.Models.SequenceNumeric();
        }

        //Test for the sequential Numbers
        [TestCase(10)]
        public void ShouldGetNumbers(int value)
        {
            
            var result = sut.Numbers(value);
            List<int> numbers = new List<int>();            
            for(int i=1;i<=value;i++)
            {
                numbers.Add(i)  ;
            }

            Assert.That(result, Is.EqualTo(numbers));    

        }

        //Test for the odd numbers
        [TestCase(10)]
        public void ShouldGetOddNumbers(int value)
        {

            var result = sut.OddNumbers(value);            
            List<int> numbers = new List<int>();
            for (int i = 1; i <= value; i++)
            {
                if ((i % 2) != 0)
                {
                    numbers.Add(i);
                }
            }

            Assert.That(result, Is.EqualTo(numbers));

        }
        //Test for the Even numbers
        [TestCase(10)]
        public void ShouldGetEvenNumbers(int value)
        {

            var result = sut.EvenNumbers(value);
            List<int> numbers = new List<int>();
            for (int i = 1; i <= value; i++)
            {
                if ((i % 2) == 0)
                {
                    numbers.Add(i);
                }
            }            
            Assert.AreEqual(result, Is.EqualTo(numbers)) ;

        }
        //Test for the Custom Numbers
        [TestCase(10)]
        public void ShouldGetCustomNumbers(int value)
        {

            var result = sut.CustomNumbers(value);
            List<string> numbers = new List<string>();
            for (int i = 1; i <= value; i++)
            {
                if (((i % 5) == 0 && (i % 3) == 0)) //Multiple of 5 and  3
                {
                    numbers.Add("Z");
                }
                else if ((i % 5) == 0) //Multiple of 5
                {
                    numbers.Add("E");
                }
                else if ((i % 3) == 0)//Multiple OF 3
                {
                    numbers.Add("C");
                }
                else
                {
                    numbers.Add(i.ToString());
                }

            }

            Assert.That(result, Is.EqualTo(numbers));

        }
        //Test for the Fibonacci
        [TestCase(5)]
        public void ShouldGetFibonacciNumbers(int value)
        {

            var result = sut.FibonacciNumbers(value);
            List<int> numbers = new List<int>();
            numbers.Add(0);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(5);

            Assert.That(result, Is.EqualTo(numbers));

        }
        //Run after each test
        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine("After {0}", TestContext.CurrentContext.Test.Name);
            sut = null;
        }
    
    }

    
}
