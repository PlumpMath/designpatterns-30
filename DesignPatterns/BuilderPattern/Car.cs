using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Car
    {
        List<string> parts = new List<string>();

        public string Model { get; set; }

        public string Color { get; set; }

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Display()
        {
            Console.WriteLine("\n"+ Model +" Parts ---------");
            foreach (string part in parts)
                Console.Write(part);
            Console.WriteLine("\n" + Model + " Color ---------");
            Console.Write(Color);
            Console.WriteLine();
        }
    }
}
