using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity.Concrete;
using Core.Utility.Results.Abstract;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<User> GetById(int id);
    }
}
