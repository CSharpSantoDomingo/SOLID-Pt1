using System;
using System.Collections.Generic;
using ISP.Common;

namespace ISP.Bad
{
    public class CustomerDal : IDalContract<Customer>
    {
        public Customer Add(Customer entity)
        {
            //Logic to Add Customer
            return entity;
        }

        public void Update(Customer entity)
        {
            //Logic to Update Customer
        }

        public void Delete(Customer entity)
        {
            //Upsssss, JIUTON, we have problems. Customers, can't be deleted, at this point start the violation of ISP
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            //Logic to Get Customer by Id
            return new Customer();
        }

        public IEnumerable<Customer> GetAll()
        {
            //Logic to Get Array of Customers
            return new List<Customer>();
        }
    }
}
