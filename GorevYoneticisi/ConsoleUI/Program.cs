using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryDal;
using System;

namespace ConsoleUI
{

    class Program
    {
        
        static void Main(string[] args)
        {
            GiderManager giderManager = new GiderManager(new EfGiderDal());
            foreach (var item in giderManager.GetGidersDetailDtos().Data)
            {
                Console.WriteLine("----------------------   GİDERLER TABLOSU   ---------------------------");
                Console.WriteLine("Kira : " + item.Kira + "Aidat : " + item.Aidat + "YiyecekMarket : " + item.YiyecekMarket + "EvEsyasi : "+ item.EvEsyasi);
            }


            // GelirListelemeTest();

        }

        private static void GelirListelemeTest()
        {
            GelirManager gelirManager = new GelirManager(new InMemoryGelirDal());
            foreach (var gelir in gelirManager.GetAll())
            {
                Console.WriteLine(gelir.StajGeliri + gelir.Maas + gelir.Burs + gelir.GelirId);
            }
        }
    }
}
