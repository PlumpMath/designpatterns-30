﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory factory = LoadFactory();

            PrintHeader("SPORTS CAR");
            var car = factory.CreateSportsCar();
            car.TurnOn();
            car.TurnOff();

            PrintHeader("LUXURY CAR");
            car = factory.CreateLuxuryCar();
            car.TurnOn();
            car.TurnOff();

            PrintHeader("ECONOMY CAR");
            car = factory.CreateEconomyCar();
            car.TurnOn();
            car.TurnOff();

        }

        static IAutoFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }

        static void PrintHeader(string title)
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++ {0} ++++++++++++++++++", title);
        }
    }
}
