using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class Automacao          
    {
        public void ServirCafe()
        {
            var cafeteira = new Cafeteira();
            cafeteira.Ligar();
            cafeteira.PrepararCafe();
            cafeteira.Desligar();
        }
    }
}
