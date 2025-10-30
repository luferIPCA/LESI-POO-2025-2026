/**
 * Pilares de POO
 * lufer
 * 2025-2026
 * 
 * NOTA: Completar código e Documentar devidamente todo o código
 * */
using System;


namespace Aula_4___Pilares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Herança

            //Pessoa p = new Pessoa();
            //p.Nome = "ok";

            //Pessoa p2 = new Pessoa("ok");

            Utilizador u = new Utilizador(12);
            //u.Nome = "ok";
            //u.NumUser = 12;
            Console.WriteLine(u.GetData());

            u.NumUser.ToString();

            Pessoa p = new Pessoa();

            Docente d = new Docente();

            Aluno a = new Aluno();

            //Aluno x = (Aluno)p;     //Conversão Não Permitida..ANALISAR

            Pessoa p4 = (Pessoa)a;    //Conversão Permitida. Analisar

            #endregion

            #region Protected

            Pai b = new Pai();
            b.Api();  // returns "Classe Pai"
            Derived d1 = new Derived();
            d1.Api(); // returns "Classe Derivada"

            #endregion

            #region Operadores

            Pessoa pes1 = new Pessoa("João");
            Pessoa pes2 = new Pessoa("João");

            if (pes1 == pes2)
            {
                Console.WriteLine("Iguais");
            }
            else
            {
                Console.WriteLine("Quase Iguais");
            }


            if (pes1.Equals(pes2)==true)
            {
                Console.WriteLine("Iguais");
            }

            

            #endregion
        }
    }
}
