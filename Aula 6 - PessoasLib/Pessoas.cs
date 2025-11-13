/*
*	<copyright file="Aula_6___PessoasLib.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/13/2025 10:28:04 AM</date>
*	<description></description>
**/
using Aula_6___PessoaLib;   //bliboteca externa

namespace Aula_6___PessoasLib
{
        /// <summary>
        /// Purpose:
        /// Created by: mustl
        /// Created on: 11/13/2025 10:28:04 AM
        /// </summary>
        /// <remarks></remarks>
        /// <example></example>
        public class Pessoas
        {
            #region Attributes

            Pessoa[] turma;
            int tot = 0;

            #endregion

            #region Methods

            #region Constructors

            /// <summary>
            /// The default Constructor.
            /// </summary>
            public Pessoas()
            {
                turma = new Pessoa[40];
            }

            #endregion

            #region Properties
            #endregion



            #region Overrides
            #endregion

            #region OtherMethods

            //InserePessoa

            public bool InserePessoa(Pessoa p)
            {
                turma[tot++] = p;
                return true;
            }
            //Remove
            #endregion

            #region Destructor
            /// <summary>
            /// The destructor.
            /// </summary>
            ~Pessoas()
            {
            }
            #endregion

            #endregion
        }
    }
