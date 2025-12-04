
using BO;
using Dados;

namespace Regras
{
    public class ControlaDados
    {

        public static bool InsereAlunoTurma(Aluno novo)
        {

            bool suc = Alunos.InsereAluno(novo);
            return suc;
            
        }
    }
}
