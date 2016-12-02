using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Cavallo:Quadrupede
    {
        public override string  NomeAnim()
        {
            return "Cucci";
        }
        public override string TipoAnim()
        {
            return "Cavallo";
        }
        public override string Habitat()
        {
            return "Prateria";
        }
        public override int NumZampe()
        {
            return 4;
        }
        public override string SiMuove()
        {
            return "Trotta";
        }
    }
}
