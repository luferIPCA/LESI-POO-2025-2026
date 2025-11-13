
using Aula_6___PessoaLib;
using Aula_6___PessoasLib;

namespace Aula_6___UsaLibraries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa(12);

            Morada m = new Morada();

            Pessoas t = new Pessoas();
            t.InserePessoa(p);
           
        }
    }
}
