using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Fatura:IEntity
    {
        public int Id { get; set; }
        public float Su { get; set; }
        public float Elektrik { get; set; }
        public float DogalGaz { get; set; }
        public float Telefon { get; set; }
    }
}
