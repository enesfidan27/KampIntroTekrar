﻿using InterfaceAbstractDemo1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo1.Concrete
{
    public class CustomerCheckManager : ICostumerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
