using System;
using System.Collections.Generic;
using System.Text;
using Core.Utility.Results.Abstract;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
        IDataResult<Color> GetById(int id);
    }
}
