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
        Student[] alunos;

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
        }

        public Turma(int size)
        {
            totStudents = 0;
            if (size < 0 || size > 100) size = 100; //business rule!!!
            alunos = new Student[size];
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public bool InsertStudent(Student s)
        {
            //validations
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
