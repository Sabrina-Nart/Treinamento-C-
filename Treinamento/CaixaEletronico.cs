using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class CaixaEletronico
    {
        public decimal SaldoTotal { get; set; }
        
        private void ValidarValorMinimoParaSaque(decimal valorSaque)
        {
            if (valorSaque < 10)
            {
                throw new Exception("Não há cédulas no sistema para essa operação");
            };
        }

        private bool ValidarMultiploDeDez(decimal valorSaque)
        {
            return valorSaque % 10 == 0;

        }

        private int CalcularCedulas(decimal valorRestante, int valorDaCedula)
        {
            decimal x = valorRestante / valorDaCedula;
            int numeroDeCedulas = (int)Math.Truncate(x);
            return numeroDeCedulas;
        }
            
        private int CalcularValorRestante(decimal valorRestante, int valorDaCedula)
        {
            return (int) valorRestante % valorDaCedula;
        }
        
        public void Sacar(decimal valorSaque)
        {
            var resto = new decimal();

            ValidarValorMinimoParaSaque(valorSaque);

            if (!ValidarMultiploDeDez(valorSaque))
            {
                resto = valorSaque % 10;
                valorSaque -= resto;
            }

            var numeroDeCedulasDeCinquenta = CalcularCedulas(valorSaque, 50);
            var valorRestante = CalcularValorRestante(valorSaque, 50);

            var numeroDeCedulasDeVinte = CalcularCedulas(valorRestante, 20);
            valorRestante = CalcularValorRestante(valorRestante, 20);

            var numeroDeCedulasDeDez = CalcularCedulas(valorRestante, 10);

            Console.WriteLine($"Quantidade de notas de 50:  {numeroDeCedulasDeCinquenta}");
            Console.WriteLine($"Quantidade de notas de 20:  {numeroDeCedulasDeVinte}");
            Console.WriteLine($"Quantidade de notas de 10:  {numeroDeCedulasDeDez}");
            Console.WriteLine($"Valor restante: {resto}");
        }
    }
}
