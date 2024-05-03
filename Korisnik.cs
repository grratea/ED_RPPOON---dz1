using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_RPPOON___dz1
{
    public class Korisnik : Osoba, IBankovniRacun
    {
        private int id;
        private double iznos;

        public Korisnik(int id, double iznos, string ime, string prezime) 
            : base(ime, prezime)
        {
            this.id = id;
            this.iznos = iznos;
        }

        public void ProvjeriStanje()
        {
            Console.WriteLine($"Osoba {ime} {prezime} - {id} - iznos na racunu: {iznos}");
        }

        public void PodigniNovac(double zeljeniIznos)
        {
            // moze otic u minus?
            /*iznos = iznos - zeljeniIznos;
            if( iznos < 0 )
            {
                Console.WriteLine($"Osoba {ime} {prezime} je otisla u minus.");
            }*/


            // ne moze otic u minus
            if (zeljeniIznos <= iznos )
            {
                iznos = iznos - zeljeniIznos;
            }
            else
            {
                Console.WriteLine($"Osoba {ime} {prezime} ne moze podici {zeljeniIznos}");
            }
            
        }

        public void UplatiNovac(double zeljeniIznos)
        {
            iznos = iznos + zeljeniIznos;
        }
    }
}
