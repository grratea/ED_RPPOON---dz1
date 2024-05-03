using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_RPPOON___dz1
{
    public abstract class Osoba
    {
        protected string ime;
        protected string prezime;

        protected Osoba(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
    }
}
