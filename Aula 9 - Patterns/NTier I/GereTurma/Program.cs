

using BO;
using Regras;
using System;
using Exceptions;

namespace GereTurma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool suc = false;
            Aluno a = new Aluno();
            try
            {
                suc = ControlaDados.InsereAlunoTurma(a);
            }
            catch(AlunoNaoPagouPropinasException e)
            {
                Console.Write("Impossivel pois " + e.Message);
            }

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
