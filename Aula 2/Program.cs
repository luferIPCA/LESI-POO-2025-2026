/*
 * */

using System;

namespace Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Pessoa p = new Pessoa();
            int tot = Pessoa.TotalPessoas();

            Console.WriteLine("TOT:" + tot.ToString());

            Pessoa p2 = new Pessoa(12,"ola");

            tot = Pessoa.TotalPessoas();        //static

            Console.WriteLine("TOT:" + tot.ToString());

            //p.Idade = 23;                       //instância ou objeto
            //p.Nome = "Ola";

            Pessoa.ShowPessoas();
            Console.ReadKey();

        }
    }
}
