using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// Lazy instantiation of Singleton
    /// </summary>

    public class SingletonV3
    {
        private static class SingletonHolder
        {
            internal static readonly SingletonV3 instance = new SingletonV3();

            //Empty static constructor - Forces Lazinesss!
            static SingletonHolder() { }
        }

        private SingletonV3()
        {
            //Stuff that must only happen once.
            Console.WriteLine("Hello from SingletonV3 Constructor!");
        }

        public static SingletonV3 Instance { get { return SingletonHolder.instance; } }

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
 