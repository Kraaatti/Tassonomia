using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Salmone:Animale_mar
    {
        public override string NomeAnim()
        {
            return "Salmo";
        }
        public override string TipoAnim()
        {
            return "Salmone";
        }
        public override int NumZampe()
        {
            return 0;
        }
        public override string Habitat()
        {
            return "Fiume";
        }
        public override string SiMuove()
        {
            return "Nuota";
        }
    }
}
