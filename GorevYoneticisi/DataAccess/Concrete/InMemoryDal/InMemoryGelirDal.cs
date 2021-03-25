using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemoryDal
{
    public class InMemoryGelirDal : IGelirDal
    {
         public List<Gelir> _gelirs;
        public InMemoryGelirDal()
        {
            _gelirs = new List<Gelir> { new Gelir { GelirId = 1, Maas = 2500, KiraGeliri = 700, Harclik = 500, Burs = 350, StajGeliri = 0, EkGelirler = 0 } };
            _gelirs = new List<Gelir> { new Gelir { GelirId = 2, Maas = 4500, KiraGeliri = 0, Harclik = 0, Burs = 0, StajGeliri = 0, EkGelirler = 1200 } };
            _gelirs = new List<Gelir> { new Gelir { GelirId = 3, Maas = 3000, KiraGeliri = 1100, Harclik = 0, Burs = 0, StajGeliri = 0, EkGelirler = 500 } };
            _gelirs = new List<Gelir> { new Gelir { GelirId = 4, Maas = 5100, KiraGeliri = 500, Harclik = 0, Burs = 0, StajGeliri = 0, EkGelirler = 2500 } };
            _gelirs = new List<Gelir> { new Gelir { GelirId = 5, Maas = 1800, KiraGeliri = 900, Harclik = 350, Burs = 500, StajGeliri = 480, EkGelirler = 0 } };
        }
        public void Add(Gelir gelir)
        {
            _gelirs.Add(gelir);
        }

        public void Delete(Gelir gelir)
        {
            Gelir GelirToDelete = null;

            GelirToDelete = _gelirs.SingleOrDefault(ge => ge.GelirId == ge.GelirId);
            _gelirs.Remove(GelirToDelete);
        }

        public Gelir Get(Expression<Func<Gelir, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Gelir> GetAll()
        {
            return _gelirs;
        }

        public List<Gelir> GetAll(Expression<Func<Gelir, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Gelir gelir)
        {
            Gelir GelirToUpdate = null;
            GelirToUpdate = _gelirs.SingleOrDefault(ge => ge.GelirId == ge.GelirId);
            GelirToUpdate.Maas = gelir.Maas;
            GelirToUpdate.KiraGeliri = gelir.KiraGeliri;
            GelirToUpdate.Harclik = gelir.Harclik;
            GelirToUpdate.Burs = gelir.Burs;
            GelirToUpdate.StajGeliri = gelir.StajGeliri;
            GelirToUpdate.EkGelirler = gelir.EkGelirler;
        }
    }
}
