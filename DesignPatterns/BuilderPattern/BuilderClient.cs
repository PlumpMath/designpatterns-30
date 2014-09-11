using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BuilderPattern
{
    [TestFixture]
    public class BuilderClient
    {
        [Test]
        public void ClientTest()
        {
            var director = new Director();

            IBuilder economy = new EconomyClassBuilder();
            IBuilder medium = new MediumClassBuilder();
            IBuilder luxury = new LuxuryClassBuilder();

            director.Construct(economy);
            Car car1 = economy.GetCar();
            car1.Display();


            director.Construct(medium);
            Car car2 = medium.GetCar();
            car2.Display();

            director.Construct(luxury);
            Car car3 = luxury.GetCar();
            car3.Display();
        }
    }
}
