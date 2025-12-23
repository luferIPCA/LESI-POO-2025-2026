
using BO;
using Dados;
using Exceptions;

namespace Regras
{
    public class ControlaDados
    {
        public static bool InsereAlunoTurma(Aluno novo)
        {
            bool suc = false;
            try
            {
                suc = Alunos.InsereAluno(novo);
            }
            catch (AlunoNaoPagouPropinasException e)
            {
                throw new AlunoNaoPagouPropinasException("Não consegui Inserir...", e);
            }
            return suc;
            
        }
    }
}
