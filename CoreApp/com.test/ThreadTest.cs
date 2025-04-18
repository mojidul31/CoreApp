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

        public void worker()
        {
            Console.WriteLine("Worker thread doing some work");
            // Sleep for 5000 milliseconds
            Thread.Sleep(5000);
        }

        public void method1()
        {

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Method1 is : {0}", i);

                // sleep for 100 milliseconds
                if (i == 2)
                {
                    Thread.Sleep(100);
                }
            }
        }

        public void method2()
        {
            // It prints numbers from 0 to 10
            for (int j = 1; j < 5; j++)
            {
                Console.WriteLine("Method2 is : {0}", j);
            }
        }

        public void PrintNumbers()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }

        public void task(string threadName)
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"{threadName} print: {i}");
                Thread.Sleep(100); // Simulate work
            }
        }

        public async Task RunAsyncTasks()
        {
            Task task1 = Task.Run(() => task("Task 1"));
            Task task2 = Task.Run(() => task("Task 2"));

            await Task.WhenAll(task1, task2);
        }

        public void Worker1(object state)
        {
            string message = (string)state;

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(message);
                Thread.Sleep(100);
            }
        }
    }
}
