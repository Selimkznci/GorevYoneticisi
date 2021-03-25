using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfGiderDal : EfEntityRepositoryBase<Gider, ButceHesaplaContext>, IGiderDal
    {
        public List<Gider> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Gider> GetAllFatura(int faturaId)
        {
            throw new NotImplementedException();
        }

        public List<GidersDetailDto> GetGidersDetailDtos()
        {
            using (ButceHesaplaContext context = new ButceHesaplaContext())
            {
                var results = from g in context.Giderler
                              join b in context.Borclar on g.BorcId equals b.Id
                              join e in context.Eglenceler on g.EglenceId equals e.Id
                              join f in context.Faturalar on g.FaturaId equals f.Id
                              select new GidersDetailDto
                              {
                                  Kira = g.Kira,
                                  Aidat =g.Aidat,
                                  YiyecekMarket = g.YiyecekMarket,
                                  EvEsyasi = g.EvEsyasi,
                                  Su = f.Su,
                                  Elektrik = f.Elektrik,
                                  DogalGaz = f.DogalGaz,
                                  Telefon = f.Telefon,
                                  Sinema = e.Sinema,
                                  Tatil = e.Tatil,
                                  Spor = e.Spor,
                                  Hobi = e.Hobi,
                                  KrediKarti = b.KrediKarti,
                                  Taksit = b.Taksit
                              };
                return results.ToList();
            }
        }
    }
}
