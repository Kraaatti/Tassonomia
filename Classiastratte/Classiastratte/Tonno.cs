using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Tonno:Pesce
    {
        public override string NomeAnim()
        {
            return "Ton";
        }
        public override string TipoAnim()
        {
            return "Tonno";
        }
        public override string Habitat()
        {
            return "Mare";
        }
        public override int NumZampe()
        {
            return 0;
        }
        public override string SiMuove()
        {
            return "Nuota";
        }
    }
}
