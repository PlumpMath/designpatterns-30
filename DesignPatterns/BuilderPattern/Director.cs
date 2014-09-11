using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildCar();
            builder.PaintCar();
        }
    }
}
