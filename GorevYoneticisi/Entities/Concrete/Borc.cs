using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Borc:IEntity
    {
        public int Id { get; set; }
        public float KrediKarti { get; set; }
        public float Taksit { get; set; }
    }
}
