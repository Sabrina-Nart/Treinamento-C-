using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Treinamento
{
    class Programan
    {
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a data de nascimento: ");

            var dataNascimento = DateTime.Parse (Console.ReadLine());

            var idade = new Funcionario().MostrarIdade(dataNascimento);
            
            Console.WriteLine(idade);
        }
        */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor inteiro: ");
            var numero  = int.Parse(Console.ReadLine());
            try
            {
                int result = numero / 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        */
        /*
        static void Main(string[] args)
        {
            var soma = 20 + 10;
            var subtracao = 20 - 10;
            var multiplicacao = 20 * 10;
            var divisao = 20 / 10;

            Console.WriteLine("Soma = " + soma);
            Console.WriteLine("Subtração = " + subtracao);
            Console.WriteLine("Multiplicação = " + multiplicacao);
            Console.WriteLine("Divisão = " + divisao);

            Console.WriteLine("Informe a idade: ");
            var idade = int.Parse(Console.ReadLine());

            if (idade >= 17)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                Console.Write(idade);
            }
        }
        */
        /*
        static void Main(string[] args)
        {
         
            Console.WriteLine("Informe a idade: ");
            var idade = int.Parse(Console.ReadLine());

            var resultado = idade > 17 ? "Maior de idade" : "Menor de idade";
            Console.Write(resultado);
        }
        */

        //

        /*Um caixa eletrônico dispensa cédulas de 50, 20 e 10 reais.
           Considerando que a quantia seja multipla de 10, fazer um algoritmo
           que exiba um relatório com quantas cédulas de cada são necessários para
           compor a quantia*/
        /*
        static void Main(string[] args)
        {
            var caixaEletronico = new CaixaEletronico();
            caixaEletronico.Sacar(12); 
        }
        */

        static void Main(string[] args)
        {
            new TesteLink().MostrarOrderBy();

        }

    }


}