/*
*	<copyright file="Aula_2.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>9/30/2025 3:43:11 PM</date>
*	<description></description>
**/
using System;

namespace Aula_2
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 9/30/2025 3:43:11 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        const int MAX = 100;
        static int totalPessoas;

        static Pessoa[] turma;

        #region ESTADO

        private int idade;
        string nome;

        #endregion

        #region COMPORTAMENTO

        #region CONST

        static Pessoa()
        {
            turma = new Pessoa[MAX];
        }
        /// <summary>
        /// Inicializa os atributos...
        /// </summary>
        public Pessoa()
        {
            idade = -1;
            nome = String.Empty;    //equivalente a =""; public static Empty
            turma[totalPessoas++]=this;
        }

        public Pessoa(int i, string n)
        {
            this.idade = i;
            this.nome = n;
            turma[totalPessoas++] = this;
        }

        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// 
        /// </summary>
        public int Idade
        {
            get { return idade; }
            set { if (!(value < 0 || value> 150))  idade = value; }

        }

        public string Nome
        {
            get { return nome.ToLower(); }
            set { 
                if (String.Compare(value, "ATAQUE") == 0) 
                    nome = String.Empty; 
                else 
                    nome = value; }
        }

        #endregion

        #region METODOS_CLASSE

        public static int TotalPessoas()
        {
            return totalPessoas;
        }


        public static void ShowPessoas()
        {
            int i = 0;
            foreach(Pessoa p in turma)
            {
                if (i >= totalPessoas) break;
                Console.WriteLine("Nome:" + p.Nome + " Idade: " + p.Idade.ToString());
                i++;
            }

        }
        #endregion

        #endregion


    }
}
