using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class Cafeteira : Eletrodomestico
    {
        public override void Ligar()
        {
            
        }

        private void AquecerAgua()
        {

        }

        private void Moer()
        {

        }

        public void PrepararCafe()
        {
            AquecerAgua();
            Moer();
        }
    }
}
