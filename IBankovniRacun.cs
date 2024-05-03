using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_RPPOON___dz1
{
    public interface IBankovniRacun
    {
        void ProvjeriStanje();
        void UplatiNovac(double zeljeniIznos);
        void PodigniNovac(double zeljeniIznos);
    }
}
