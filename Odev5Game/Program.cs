using System;

namespace Odev5Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(123, "Serdar", "Aktolga", "34589065123");
            Console.WriteLine(Add(customer1));
    }

        private static bool Add(Customer customer1)
        {
            throw new NotImplementedException();
        }
    }
