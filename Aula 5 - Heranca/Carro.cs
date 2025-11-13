/*
*	<copyright file="Aula_5___Heranca.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/6/2025 10:22:13 AM</date>
*	<description></description>
**/
using System;

namespace Aula_5___Heranca
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 11/6/2025 10:22:13 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Carro : Veiculo
    {
        #region Attributes
        public int portas;      //ATENÇÃO
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Carro()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        public int QuantasPortas()
        {
            return portas;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Carro()
        {
        }
        #endregion

        #endregion
    }


    public class Carro2 : Veiculo
    {
        #region Attributes
        public int portas;      //ATENÇÃO
        public float consumo;   //
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Carro2()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        public int QuantasPortas()
        {
            return portas;
        }

        public float QuantosKms(float x)
        {
            return consumo * x;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Carro2()
        {
        }
        #endregion

        #endregion
    }
}
