﻿namespace CoreApp.com.test
{
    public class TestDelegateSimple
    {        
        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }

        // "area" method
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }

        // "perimeter" method
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }

        public int DoubleValue(int num)
        {
            return num + num;
        }

        public void SubtractNumbers(int p, int q)
        {
            Console.WriteLine(p - q);
        }

        public bool myfun(string mystring)
        {
            if (mystring.Length < 7)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        


    }
}
