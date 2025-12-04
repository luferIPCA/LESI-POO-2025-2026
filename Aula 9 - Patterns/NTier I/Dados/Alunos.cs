
using System.Collections.Generic;
using BO;

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
            turma.Add(a);
            return true;
        }
    }
}
