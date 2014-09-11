using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SingletonPattern
{
    [TestFixture]
    public class SingletonClient
    {
        [Test]
        public void UseSingletonV1()
        {
            Console.WriteLine("Start of test!");
            var singleton1 = SingletonV1.Instance;
            var singleton2 = SingletonV1.Instance;

            Assert.AreSame(singleton1, singleton2);
        }

        [Test]
        public void UseSingletonV2()
        {
            SingletonV2.SayHello();
            Console.WriteLine("Start of test!");
            var singleton1 = SingletonV2.Instance;
            var singleton2 = SingletonV2.Instance;

            Assert.AreSame(singleton1, singleton2);
        }

        [Test]
        public void UseSingletonV3()
        {
            SingletonV3.SayHello();
            Console.WriteLine("Start of test!");
            var singleton1 = SingletonV3.Instance;
            var singleton2 = SingletonV3.Instance;

            Assert.AreSame(singleton1, singleton2);
        }
    }
}
