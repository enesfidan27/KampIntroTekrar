using System;

namespace KampIntroTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer{Id=1,FirstName="Serdar",LastName="Aktolga",City="Şaşkınbakkal" };
            Customer customer2 = new Customer(2,"Ege","Cinel","Las Vegas") ;

            Console.WriteLine(customer1.FirstName +" "+customer1.LastName+" "+customer1.City);
            Console.WriteLine(customer2.FirstName);
            
        }
        class Customer
        {
            public Customer()
            {

            }
            public Customer(int id, string firstName, string lastName, string city)
            {
                FirstName = firstName;
                LastName = lastName;
                Id = id;
                City = city;
            }    
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }

        }
    }

}
