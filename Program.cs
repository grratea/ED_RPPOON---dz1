namespace ED_RPPOON___dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banka banka = new Banka();
            Korisnik prvi = new Korisnik(1, 500,"Tea", "Grahovac");
            Korisnik drugi = new Korisnik(2, 1000, "Petar", "Petric");
            Korisnik treci = new Korisnik(3, 750, "Ivan", "Ivanic");

            banka.DodajKorisnika(prvi);
            banka.DodajKorisnika(drugi);
            banka.DodajKorisnika(treci);

            prvi.ProvjeriStanje();
            prvi.UplatiNovac(1000.0);
            prvi.ProvjeriStanje();

            Console.WriteLine();

            prvi.PodigniNovac(2000.0);
            prvi.ProvjeriStanje();

            Console.WriteLine();

            Console.WriteLine("Stanje prije transakcije: ");

            drugi.ProvjeriStanje();
            treci.ProvjeriStanje();

            Transakcija transakcija = new Transakcija(drugi, treci, 55);

            transakcija.IzvrsiTransakciju();

            Console.WriteLine();

            Console.WriteLine("Stanje poslije transakcije: ");
            drugi.ProvjeriStanje();
            treci.ProvjeriStanje();
        }
    }
}