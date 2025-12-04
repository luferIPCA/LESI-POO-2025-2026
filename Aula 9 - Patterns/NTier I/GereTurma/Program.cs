

using BO;
using Regras;
using System;

namespace GereTurma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno a = new Aluno();

            bool suc = ControlaDados.InsereAlunoTurma(a);

            if (suc == true)
            {
                Console.Write("inserido!");
            }

            suc = ControlaDados.InsereAlunoTurma(a);
            if (suc == true)
            {
                Console.Write("inserido!");
            }
            else
                Console.Write("Erro!");
        }
    }
}
