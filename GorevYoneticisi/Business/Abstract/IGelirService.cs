using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGelirService
    {
        List<Gelir> GetAll();
        void Add();			
        void Update();				
        void Delete();
    }
}
