using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.com.test
{
    public class ThreadTest
    {
        public void myTask()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Your task is running!");
            }
        }
        public void work()
        {
            // Sleep for 100 milliseconds
            Thread.Sleep(100);
        }
    }
}
