using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Corvo:Uccello
    {
        public override string NomeAnim()
        {
            return "Cuccino";
        }
        public override string TipoAnim()
        {
            return "Uccello";
        }
        public override string Habitat()
        {
            return "Cielo";
        }
        public override int NumZampe()
        {
            return 2;
        }
        public override string SiMuove()
        {
            return "Battito ali";
        }
    }
}
