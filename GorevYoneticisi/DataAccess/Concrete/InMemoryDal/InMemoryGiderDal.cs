using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemoryDal
{
    public class InMemoryGiderDal : IGiderDal
    {
        List<Gider> _giders;
        public InMemoryGiderDal()
        {
            _giders = new List<Gider> { new Gider { Id = 1, FaturaId = 1, EglenceId = 1, BorcId = 1, Kira = 850, Aidat = 70, YiyecekMarket = 450, EvEsyasi = 200 } };
            _giders = new List<Gider> { new Gider { Id = 2, FaturaId = 2, EglenceId = 2, BorcId = 2, Kira = 1250, Aidat = 150, YiyecekMarket = 380, EvEsyasi = 300 } };
            _giders = new List<Gider> { new Gider { Id = 3, FaturaId = 3, EglenceId = 3, BorcId = 3, Kira = 1100, Aidat = 100, YiyecekMarket = 640, EvEsyasi = 300 } };
            _giders = new List<Gider> { new Gider { Id = 4, FaturaId = 4, EglenceId = 4, BorcId = 4, Kira = 1600, Aidat = 180, YiyecekMarket = 900, EvEsyasi = 700 } };
            _giders = new List<Gider> { new Gider { Id = 5, FaturaId = 5, EglenceId = 5, BorcId = 5, Kira = 600, Aidat = 40, YiyecekMarket = 260, EvEsyasi = 150 } };
        }
        public void Add(Gider gider)
        {
            _giders.Add(gider);
        }

        public void Delete(Gider gider)
        {
            Gider GiderToDelete = null;

            GiderToDelete = _giders.SingleOrDefault(gi => gi.Id == gi.Id);
            _giders.Remove(GiderToDelete);
        }

        public Gider Get(Expression<Func<Gider, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Gider> GetAll()
        {
            return _giders;
        }

        public List<Gider> GetAll(Expression<Func<Gider, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Gider> GetAllFatura(int faturaId)
        {
            return _giders.Where(gi => gi.FaturaId == faturaId).ToList();
        }

        public List<GidersDetailDto> GetGidersDetailDtos()
        {
            throw new NotImplementedException();
        }

        public void Update(Gider gider)
        {
            Gider GiderToUpdate = null;
            GiderToUpdate = _giders.SingleOrDefault(gi => gi.Id == gi.Id);
            GiderToUpdate.FaturaId = gider.FaturaId;
            GiderToUpdate.EglenceId = gider.EglenceId;
            GiderToUpdate.BorcId = gider.BorcId;
            GiderToUpdate.Kira = gider.Kira;
            GiderToUpdate.Aidat = gider.Aidat;
            GiderToUpdate.YiyecekMarket = gider.YiyecekMarket;
            GiderToUpdate.EvEsyasi = gider.EvEsyasi;
        }
    }
}
