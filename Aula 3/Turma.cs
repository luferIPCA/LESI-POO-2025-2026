/*
*	<copyright file="Aula_3.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/9/2025 10:44:57 AM</date>
*	<description></description>
**/
using System;

namespace Aula_3
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/9/2025 10:44:57 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Turma
    {
        #region Attributes
        int totStudents;
        int numero;
        Student[] alunos;
        static int numeroGlobalTurma = 0;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Turma()
        {
            totStudents = 0;
            alunos = new Student[100];
            numero = numeroGlobalTurma;
            numeroGlobalTurma++;
        }

        public Turma(int size)
        {
            totStudents = 0;
            if (size < 0 || size > 100) size = 100; //business rule!!!
            alunos = new Student[size];
            numero = numeroGlobalTurma;
            numeroGlobalTurma++;
        }

        #endregion

        #region Properties
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public static int NumeroGlobalTurma
        {
            get { return numeroGlobalTurma; }
        }

        public int TotStudents
        {
            get { return totStudents; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public bool InsertStudent(Student s)
        {
            //validations
            //return false;
            alunos[totStudents++] = s;
            return true;
        }


        public void ShowTurma()
        {
            foreach(Student s in alunos)
            {
                //check totalStudents..use break!!!
                Console.WriteLine("Numero: " + s.Number);
            }
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Turma()
        {
        }
        #endregion

        #endregion
    }
}
