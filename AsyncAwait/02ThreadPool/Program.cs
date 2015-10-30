using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _02ThreadPool
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("我是主线程：Thread Id {0}", Thread.CurrentThread.ManagedThreadId);
            ThreadPool.QueueUserWorkItem(Go);
            Console.ReadKey();

            //线程的创建是比较占用资源的一件事情asp.net为我们提供了线程池来帮助 我们创建和管理线程 Task是默认会直接使用线程池 但是Thread不会  如果我们不使用Task 又想用线程池的话  可以使用ThreadPool类
        }

        public static void Go(object data)
        {            
            Console.WriteLine("我是另一个线程：Thread Id {0}",Thread.CurrentThread.ManagedThreadId);
        }
    }


    public class test
    {
        public string Test { get; set; } = "Hello World";
    }
}
