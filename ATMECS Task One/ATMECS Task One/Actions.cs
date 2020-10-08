using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ATMECS_Task_One
{
    
    internal static class Actions
    {
        public static Semaphore _semaphore = new Semaphore(1,1);
        // Action 1
        public static void Action1()
        {
            _semaphore.WaitOne();
            Console.WriteLine($"Action 1 Started");            
            // For Checking
            Thread.Sleep(3000);
            Console.WriteLine($"Action 1 Completed");
            _semaphore.Release();
        }
        // Action 2
        public static void Action2()
        {
            _semaphore.WaitOne();
            Console.WriteLine($"Action 2 Started");
            
            // For Checking
            Thread.Sleep(3000);
            Console.WriteLine($"Action 2 Completed");
            _semaphore.Release();
        }
        // Action 3
        public static void Action3()
        {
            _semaphore.WaitOne();
            Console.WriteLine($"Action 3 Started");
            
            // For Checking
            Thread.Sleep(3000);
            Console.WriteLine($"Action 3 Completed");
            _semaphore.Release();
        }
        // Action 4
        public static void Action4()
        {
            _semaphore.WaitOne();
            Console.WriteLine($"Action 4 Started");
            
            // For Checking
            Thread.Sleep(3000);
            Console.WriteLine($"Action 4 Completed");
            _semaphore.Release();
        }
    }
}
