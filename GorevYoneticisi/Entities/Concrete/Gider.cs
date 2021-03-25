using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Gider:IEntity
    {
        public int Id { get; set; }
        public int FaturaId { get; set; }
        public int EglenceId { get; set; }
        public int BorcId { get; set; }
        public float Kira { get; set; }
        public float Aidat { get; set; }
        public float YiyecekMarket { get; set; }
        public float EvEsyasi { get; set; }
    }
}
