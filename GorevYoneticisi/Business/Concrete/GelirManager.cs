using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GelirManager : IGelirService
    {
        IGelirDal _gelirDal;
        public GelirManager(IGelirDal gelirDal)
        {
            _gelirDal = gelirDal;
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Gelir> GetAll()
        {
           return _gelirDal.GetAll();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
