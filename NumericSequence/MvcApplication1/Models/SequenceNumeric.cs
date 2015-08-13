using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberSequence.Models
{
    public class SequenceNumeric
    {
        //Return all numbers
        public List<int> Numbers(int UserInput)
        {
            
                List<int> numbers = new List<int>();

                for (int i = 1; i <= UserInput; i++)
                {
                    numbers.Add(i);
                }
                return numbers;
            
        }

        //Return Even Numbers
        public List<int> OddNumbers(int UserInput)
        {

            List<int> odd_numbers = new List<int>();

            for (int i = 1; i <= UserInput; i++)
            {
                if ((i % 2) != 0) //IF result Not 0 then odd number
                {
                    odd_numbers.Add(i);
                }
            }
            return odd_numbers;

        }

        //Return Even Numbers
        public List<int> EvenNumbers(int UserInput)
        {

            List<int> even_numbers = new List<int>();

            for (int i = 1; i <= UserInput; i++)
            {
                if ((i % 2) == 0) //IF result equals 0 then even number
                {
                    even_numbers.Add(i);
                }
            }
            return even_numbers;

        }

        //Custom Numbers
        public List<string> CustomNumbers(int UserInput)
        {

            List<string> custom_numbers = new List<string>();

            for (int i = 1; i <= UserInput; i++)
            {
                //Multiple OF 3 
                if (((i % 5) == 0 && (i%3)==0)) //Multiple of 5 and  3
                {
                    custom_numbers.Add("Z");
                }
                else if((i%5)==0) //Multiple of 5
                {
                    custom_numbers.Add("E");
                }
                else if ((i % 3) == 0)//Multiple OF 3
                {
                    custom_numbers.Add("C");
                }
                else
                {
                    custom_numbers.Add(i.ToString());
                }

            }
            return custom_numbers;

        }

        //Fibonacci Numbers
        public List<int> FibonacciNumbers(int UserInput)
        {

            List<int> fibonacci_numbers = new List<int>();
            int a = 0;
            int b = 1;
            
            if (UserInput != 1)//IF UserInputs is greater than 1
            {
                int temp = a;
                for (int i = 0; temp <= UserInput; i++)
                {
                    temp = a;
                    a = b;
                    b = temp + b;

                    //int c = a ; //First add the a and b
                    //a = b; //Set the value for next iteration
                    //b = c+b; //Set the value for next iteration
                    if(temp<=UserInput) 
                        fibonacci_numbers.Add(temp);  //Add the sum value to show output
                }
            }
            else
            {
                fibonacci_numbers.Add(UserInput);
            }
            return fibonacci_numbers;

        }


    }
}