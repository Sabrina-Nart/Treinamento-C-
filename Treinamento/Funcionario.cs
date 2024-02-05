namespace Treinamento
{
    public class Funcionario : Pesssoa
    {
        public DateTime DataAdm { get; set; }
        public List<string> Nomes {  get; set; }

        public int MostrarIdade(DateTime dataNascimento)
        {
            return DateTime.Now.Year - dataNascimento.Year;
        }
    }
}

