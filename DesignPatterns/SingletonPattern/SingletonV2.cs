using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// Let the core framework(.Net) manage the locking, mutex and volatile stuff for you...
    /// </summary>

    public class SingletonV2
    {
        private static readonly SingletonV2 instance = new SingletonV2();

        private SingletonV2()
        {
            //Stuff that must only happen once.
            Console.WriteLine("Hello from SingletonV2 Constructor!");
        }

        public static SingletonV2 Instance { get { return instance; } }

        public static void SayHello()
        {
            Console.WriteLine("Hello there!");
        }

        public void DoSomething()
        {
            //Must be thread-safe!
        }

    }
}
 