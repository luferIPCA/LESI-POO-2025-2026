
using System.Collections.Generic;
using BO;
using Exceptions;

namespace Dados
{
    public class Alunos
    {
        static List<Aluno> turma;

        static Alunos()
        {
            turma = new List<Aluno>();
        }

        public static bool InsereAluno(Aluno a)
        {

            if (turma.Contains(a)) return false;
            if (a.Num < 0) 
                throw new AlunoNaoPagouPropinasException("Que número estranho!!");
            turma.Add(a);
            return true;
        }
    }
}
