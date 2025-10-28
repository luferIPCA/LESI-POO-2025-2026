/*
*	<copyright file="Aula_4___Pilares.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/28/2025 3:35:57 PM</date>
*	<description></description>
**/
using System;

namespace Aula_4___Pilares
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/28/2025 3:35:57 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Docente: Utilizador
    {
        #region Attributes
        DateTime inicio;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Docente()
        {
        }

        #endregion

        #region Properties
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods

        public override string GetData()
        {
            return base.GetData();
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Docente()
        {
        }
        #endregion

        #endregion
    }
}
