using System;
using System.Collections.Generic;
using System.Text;
using Core.Utility.Results.Abstract;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
        IDataResult<Brand> GetById(int id);
    }
}
