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
        int totTurmas;
        Turma[] turmas; //tentar static
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Turmas()
        {
            turmas = new Turma[20];
            totTurmas = 0;
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public bool InsertTurma(Turma t)
        {
            //CUIDADO
            turmas[totTurmas++] = t;
            return true;
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
