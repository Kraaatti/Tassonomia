using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Pinguino:Uccello
    {
        public override string NomeAnim()
        {
            return "Sdvogo";
        }
        public override string TipoAnim()
        {
            return "Pinguino";
        }
        public override string Habitat()
        {
            return "Polo nord";
        }
        public override int NumZampe()
        {
            return 2;
        }
        public override string SiMuove()
        {
            return "Zampetta";
        }
    }
}
