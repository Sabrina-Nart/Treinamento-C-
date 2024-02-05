using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public interface IRepositorio
    {
        void Adicionar(List<int> numeros);
        void Adicionar(int id);
    }
}
