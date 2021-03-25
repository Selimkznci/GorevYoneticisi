using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfGelirDal : EfEntityRepositoryBase<Gelir, ButceHesaplaContext>, IGelirDal
    {
        public List<Gelir> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
