using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class TesteLink
    {
        public List<int> Numeros { get; set; }

        public void MostrarOrderBy()
        {
            Numeros = new List<int> { 2, 5, 6, 7, 9, 1 };

            foreach (var numero in Numeros.OrderBy(x => x))
            {
                Console.WriteLine($"OrderBy: {numero}");
            }

            foreach (var numero in Numeros.OrderByDescending(x => x))
            {
                Console.WriteLine($"OrderBy Descending: {numero}");
            }

            foreach (var numero in Numeros.Take(2))
            {
                Console.WriteLine($"Take: {numero}");
            }

            foreach (var numero in Numeros.Skip(2))
            {
                Console.WriteLine($"Skip: {numero}");
            }
        }
    }
}
