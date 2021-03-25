using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Concrete
{
    public class GiderManager : IGiderService
    {
        IGiderDal _giderDal;
        public GiderManager(IGiderDal giderDal)
        {
            _giderDal = giderDal;
        }

        public IResult Add(Gider gider)
        {
            _giderDal.Add(gider);
            return new SuccessResult(Messages.GiderAdded);
        }

        public IResult Delete(Gider gider)
        {
            _giderDal.Delete(gider);
            return new SuccessResult(Messages.GiderDeleted);
        }

        public IDataResult<List<Gider>> GetAll()
        {
            return new DataResult<List<Gider>>(_giderDal.GetAll(), true, Messages.GiderListed);
        }

        public IDataResult<List<GidersDetailDto>> GetGidersDetailDtos()
        {
            return new SuccessDataResult<List<GidersDetailDto>>(_giderDal.GetGidersDetailDtos());
        }

        public IResult Update(Gider gider)
        {
            _giderDal.Update(gider);
            return new SuccessResult();
        }
    }
}
