using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Gelir:IEntity
    {
        public int GelirId { get; set; }
        public float Maas { get; set; }
        public float KiraGeliri { get; set; }
        public float Harclik { get; set; }
        public float Burs { get; set; }
        public float StajGeliri { get; set; }
        public float EkGelirler { get; set; }
    }
}
