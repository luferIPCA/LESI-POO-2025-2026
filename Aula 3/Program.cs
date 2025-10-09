using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(12, "Ana");
            //s1.number = 23;   //Impossible..."number" is private
            s1.Number = 27;

            Turma t1 = new Turma(30);
            //Turma t2 = new Turma(-10);    //What?
            t1.InsertStudent(s1);

            Turmas ts = new Turmas();
            ts.InsertTurma(t1);

        }
    }
}
