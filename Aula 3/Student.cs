/*
*	<copyright file="Aula_3.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/9/2025 10:40:12 AM</date>
*	<description></description>
**/
using System;

namespace Aula_3
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/9/2025 10:40:12 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Student
    {
        #region Attributes
        int number;
        string name;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Student()
        {
            number = -1;
            name = String.Empty;
        }

        /// <summary>
        /// Cria um...
        /// </summary>
        /// <param name="n">Número do Estudante</param>
        /// <param name="no">Nome do...</param>
        public Student(int n, string  no)
        {
            number = n;
            name = no;
        }

        #endregion

        #region Properties

        public int Number
        {
            get { return number; }  
            set { number = value; } //number=>value;
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Student()
        {
        }
        #endregion

        #endregion
    }
}
