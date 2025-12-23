using System.Collections.Generic;

namespace BO
{
    /// <summary>
    /// 
    /// </summary>
    public class Aluno
    {
        int num;            
        public string nome; //CUIDADO
        List<string> contactos;

        /// <summary>
        /// Const
        /// </summary>
        public Aluno()
        {

        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

    }
}
