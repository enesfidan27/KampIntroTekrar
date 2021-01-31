using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer { DateOfBirth = new System.DateTime(2004, 4, 15), FirstName = "Engin", LastName = "Demiroğ",NationalityId ="28861478" });

        }
    }
}
