using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Concrete;
using Core.Entity.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,CarRentalProjectContext>,IUserDal
    {
    }
}
