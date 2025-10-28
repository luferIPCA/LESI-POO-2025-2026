/*
*	<copyright file="Aula_4___Pilares.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/28/2025 3:25:01 PM</date>
*	<description></description>
**/
using System;

namespace Aula_4___Pilares
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/28/2025 3:25:01 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Utilizador : Pessoa
    {
        #region Attributes

        int numUser;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Utilizador()
        {
            numUser = -1;
            valorEra++;
        }

        public Utilizador(int n)
        {
            numUser = n;
            Nome = "";      //atributo da classe pai!
        }

        public Utilizador(int n, string nome) : base(nome)
        {
            numUser = n;
            //Nome = nome;      //atributo da classe pai!
        }

        #endregion

        #region Properties

        public int NumUser
        {
            get { return numUser; }
            set { if (value > 0) numUser = value; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        //public override string GetData()
        //{
        //    return "ok";
        //}
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Utilizador()
        {
        }
        #endregion


        public override string GetData()
        {
            return Nome.ToUpper();
        }
        public override string ToString()
        {

            return base.ToString();
        }

        #endregion
    }
}
