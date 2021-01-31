using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5Game
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Hesap Oluşturuldu : " + customer.FirstName + customer.Surname);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Hesap Güncellendi : " + customer.FirstName + customer.Surname);
        } 
        public void Delete(Customer customer)
        {
            Console.WriteLine("Hesap Silindi : " + customer.FirstName + customer.Surname);
        }


    }
}
