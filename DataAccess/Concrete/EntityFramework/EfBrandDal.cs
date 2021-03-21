using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal:EfEntityRepositoryBase<Brand,CarRentalProjectContext>,IBrandDal
    {
    }
}
