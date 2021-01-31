using InterfaceAbstractDemo1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo1.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICostumerCheckService _costumerCheckService;

        public StarbucksCustomerManager(ICostumerCheckService costumerCheckService)
        {
            _costumerCheckService = costumerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_costumerCheckService.CheckIfRealPerson(customer))
            {
               base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
           
        }
    }
}
