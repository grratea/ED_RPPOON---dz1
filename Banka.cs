using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_RPPOON___dz1
{
    public class Banka
    {
        private List<Korisnik> korisnici;

        public Banka()
        {
            korisnici = new List<Korisnik>();
        }

        public Banka(List<Korisnik> korisnici)
        {
            korisnici = korisnici.ToList();
        }

        public void DodajKorisnika(Korisnik korisnik)
        {
            korisnici.Add(korisnik);
        }

        public void MakniKorisnika(Korisnik korisnik)
        {
            korisnici.Remove(korisnik);
        }

        public void ObaviTranksakciju(Transakcija transakcija)
        {
            transakcija.IzvrsiTransakciju();
        }

    }
}
