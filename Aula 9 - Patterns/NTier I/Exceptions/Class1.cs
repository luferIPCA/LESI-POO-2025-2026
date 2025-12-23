using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class AlunoNaoPagouPropinasException : ApplicationException
    {
        public AlunoNaoPagouPropinasException() : base("Algo se passa")
        {

        }

        public AlunoNaoPagouPropinasException(string s): base("Alguém disso isto " + s)
        {

        }

        public AlunoNaoPagouPropinasException(string s, Exception e)
        {
            //throw new Exception("ERRO");
            //throw new Exception(s + " - " + e.Message);
            throw new AlunoNaoPagouPropinasException(s + " - " + e.Message);
        }
    }
}
