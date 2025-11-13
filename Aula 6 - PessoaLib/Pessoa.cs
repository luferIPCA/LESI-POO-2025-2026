/*
 * */

namespace Aula_6___PessoaLib
{
    /// <summary>
    /// 
    /// </summary>
    public class Pessoa
    {
        int idade;
        Morada moradaPessoa;

        public Pessoa()
        {
            idade = 20;
        }

        public Pessoa(int i)
        {
            idade = i;
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        internal Morada MoradaPessoa {
            get { return moradaPessoa; }
            set { moradaPessoa = value; }
        }
    }
}
