using System;

namespace ChainOfResposibility
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesMan salesman = new SalesMan();
            Manager manager = new Manager();
            Owner owner = new Owner();

            salesman.SetSucessor(manager);
            manager.SetSucessor(owner);

            salesman.HandleDiscount(10);

            Console.ReadKey();

        }
    }
}
