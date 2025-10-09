/*!
 *  @file Program.cs
 *  @author lufer
 *  @date 2025-09-25
 *  @project Aula 1
 *  
 */

using Aula_1_1;
using System;

namespace Aula_1
{
    /// <summary>
    /// Em C# também existem structs!!!
    /// </summary>
    struct Pessoa
    {
        public int idade;
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //Calculadora x;  //declrara x como objeto do tipo Calculadora
            //int k = x.Soma(2, 3);
            //Falta criar objeto x

            //Usar apenas métodos static
            int k = Calculadora.Soma(2, 3);

            Console.WriteLine("ola"); //printf("%s", "ola\n");

            Console.ReadKey();
        }
    }
}
