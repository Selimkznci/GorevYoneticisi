using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Eglence:IEntity
    {
        public int Id { get; set; }
        public float Sinema { get; set; }
        public float Tatil { get; set; }
        public float Spor { get; set; }
        public float Hobi { get; set; }
    }
}
