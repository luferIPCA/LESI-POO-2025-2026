/*
*	<copyright file="Aula_3.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/9/2025 10:53:00 AM</date>
*	<description></description>
**/
using System;
using System.Runtime.Remoting.Messaging;

namespace Aula_3
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/9/2025 10:53:00 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Turmas
    {
        #region Attributes
        const int SIZE = 100;
        string escola;
        static int totTurmas;
        static Turma[] conjTurmas; //tentar static
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Turmas()
        {
            conjTurmas = new Turma[SIZE];
            totTurmas = 0;
            escola = "SEM NOME";
        }
        public Turmas(int s, string n)
        {
            conjTurmas = (s <= 0 && s > SIZE) ? new Turma[SIZE] : new Turma[s];
            totTurmas = 0;
            escola = n;
        }
        #endregion

        #region Properties

        public static int TotAlunos
        {
            get { return totTurmas; }
            //set;                  //não é admitido
        }

       public string Escola
        {
            get { return escola; }
            set { if (value.ToString().Length>0) escola = value; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool InsertTurma(Turma t)
        {
            if (Turmas.ExisteTurma(t.Numero) == true) return false;
            if(totTurmas<SIZE)
                conjTurmas[totTurmas++] = t;
            return true;
        }

        /// <summary>
        /// Verifia se determinada turma existe
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool ExisteTurma(int num)
        {
            for(int i=0; i < totTurmas; i++)
            {
                if (conjTurmas[i].Numero == num) return true;
            }
            return false;
        }

        public static Turma QueTurma(int num)
        {
            for (int i = 0; i < totTurmas; i++)
            {
                if (conjTurmas[i].Numero == num) return conjTurmas[i];
            }
            return null;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Turmas()
        {
        }
        #endregion

        #endregion
    }
}
