using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
   abstract class Animale
    {
        public void Epilogo()
        {
            Console.WriteLine(NomeAnim());
            Console.WriteLine(TipoAnim());
            Console.WriteLine(Habitat());
            Console.WriteLine(NumZampe());
            Console.WriteLine(SiMuove());

        }
        public abstract string NomeAnim();
        public abstract string TipoAnim();
        public abstract string Habitat();
        public abstract int NumZampe();
        public abstract string SiMuove();
    }
}
