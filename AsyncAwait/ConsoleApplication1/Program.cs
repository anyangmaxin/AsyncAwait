using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(Go).Start();  // .NET 1.0开始就有的
            Task.Factory.StartNew(Go); // .NET 4.0 引入了 TPL
            Task.Run(new Action(Go)); // .NET 4.5 新增了一个Run的方法
            Console.ReadKey();
            //这里面需要注意的是，创建Thread的实例之后，需要手动调用它的Start方法将其启动。但是对于Task来说，StartNew和Run的同时，既会创建新的线程，并且会立即启动它

        }

        public static void Go()
        {
            Console.WriteLine("我是另一个线程");
        }
    }
}
