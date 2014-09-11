using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonV1
    {
        private static readonly object mutex = new object();
        private static SingletonV1 instance;

        private SingletonV1()
        {
            //Stuff that must only happen once.
            Console.WriteLine("Hello from SingletonV1 Constructor!");
        }

        public static SingletonV1 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (mutex)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonV1();
                        }
                    }
                }

                return instance;
            }
        }

        public void DoSomething()
        {
            //Must be thread-safe!
        }

    }
}
