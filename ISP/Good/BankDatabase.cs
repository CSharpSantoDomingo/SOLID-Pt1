using System;
using System.Collections.Generic;
using ISP.Common;

namespace ISP.Good
{
    public class BankDal : IBankDal
    {
        public Bank Add(Bank entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Bank entity)
        {
            throw new NotImplementedException();
        }

        public Bank GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bank> GetAll()
        {
            throw new NotImplementedException();
        }

        #region IBankDatabase Members
        
        public void Delete(Bank bank)
        {
            throw new NotImplementedException();
        } 

        #endregion
    }
}
