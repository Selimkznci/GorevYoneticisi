using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGiderService
    {
        IDataResult <List<GidersDetailDto>> GetGidersDetailDtos();
        IDataResult<List<Gider>> GetAll();
        IResult Add(Gider gider);
        IResult Delete(Gider gider);
        IResult Update(Gider gider);
    }
}
