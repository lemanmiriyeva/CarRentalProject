using System;
using System.Collections.Generic;
using System.Text;
using Core.Utility.Results.Abstract;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IDataResult<Customer> GetById(int id);
    }
}
