using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Uomo:Bipede
    {
        public override string NomeAnim()
        {
            return "Pippo";
        }
        public override string TipoAnim()
        {
            return "Uomo";
        }
        public override string Habitat()
        {
            return "Tutto";
        }
        public override int NumZampe()
        {
            return 2;
        }
        public override string SiMuove()
        {
            return "Cammina";
        }
    }
}
