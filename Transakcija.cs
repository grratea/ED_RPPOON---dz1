using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_RPPOON___dz1
{
    public class Transakcija : ITransakcija
    {
        private Korisnik sender;
        private Korisnik receiver;
        private double iznos;

        public Transakcija(Korisnik sender, Korisnik receiver, double iznos)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.iznos = iznos;
        }

        public void IzvrsiTransakciju()
        {
            sender.PodigniNovac(iznos);
            receiver.UplatiNovac(iznos);
        }
    }
}
