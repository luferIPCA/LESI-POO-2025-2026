/*
*	<copyright file="Aula_4___Pilares.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/28/2025 3:22:11 PM</date>
*	<description></description>
**/
using System;

namespace Aula_4___Pilares
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/28/2025 3:22:11 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Attributes
        string nome;
        protected int valorEra;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoa()
        {
            nome = "";
            valorEra = 1000;
        }

        public Pessoa(string n)
        {
            nome = n;
        }

        #endregion

        #region Properties

        public string Nome
        {
            get { return nome.ToUpper(); }
            set { nome = value; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string GetData()
        {
            return Nome.ToLower();
        }


        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoa()
        {
        }
        #endregion

        #endregion
    }
}
