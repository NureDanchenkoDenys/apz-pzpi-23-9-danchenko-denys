using System;

namespace FactoryMethodExample
{
    // Абстрактний продукт
    abstract class Transport
    {
        public abstract string Deliver();
    }

    // Конкретний продукт 1
    class Truck : Transport
    {
        public override string Deliver()
        {
            return "Доставка вантажу здiйснюється автомобiльним транспортом.";
        }
    }

    // Конкретний продукт 2
    class Ship : Transport
    {
        public override string Deliver()
        {
            return "Доставка вантажу здiйснюється морським транспортом.";
        }
    }

    // Абстрактний творець
    abstract class Logistics
    {
        public abstract Transport CreateTransport();

        public string PlanDelivery()
        {
            Transport transport = CreateTransport();
            return "Логiстична операцiя: " + transport.Deliver();
        }
    }

    // Конкретний творець 1
    class RoadLogistics : Logistics
    {
        public override Transport CreateTransport()
        {
            return new Truck();
        }
    }

    // Конкретний творець 2
    class SeaLogistics : Logistics
    {
        public override Transport CreateTransport()
        {
            return new Ship();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Logistics logistics;

            logistics = new RoadLogistics();
            Console.WriteLine(logistics.PlanDelivery());

            logistics = new SeaLogistics();
            Console.WriteLine(logistics.PlanDelivery());
        }
    }
}
