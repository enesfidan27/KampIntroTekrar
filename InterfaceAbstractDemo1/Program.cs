using InterfaceAbstractDemo1.Abstract;
using InterfaceAbstractDemo1.Concrete;

namespace InterfaceAbstractDemo1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new System.DateTime(2004, 4, 15), FirstName = "Enes", LastName = "Fidan", NationalityId = "2899053"  });
        }
    }
}
