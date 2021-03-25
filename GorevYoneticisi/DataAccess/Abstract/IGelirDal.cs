using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IGelirDal:IEntityRepository<Gelir>
    {
        List<Gelir> GetAll();
        void Update(Gelir gelir);
        void Delete(Gelir gelir);
        void Add(Gelir gelir);
    }
}
