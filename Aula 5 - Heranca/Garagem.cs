/*
*	<copyright file="Aula_5___Heranca.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/6/2025 10:29:43 AM</date>
*	<description></description>
**/
using System;

namespace Aula_5___Heranca
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 11/6/2025 10:29:43 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Garagem
    {
        #region Attributes

        IVeiculo[] veiculos;
        int totCarros=0;
        
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Garagem()
        {
            veiculos = new Veiculo[200];
        }

        public Garagem(int size)
        {
            veiculos = new Veiculo[size];
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        public bool Estaciona (IVeiculo x)
        {
            if (!x.EstaPago()) return false;
            if (x.QuantosKms(20) > 100)
                return false;
            else
            {
                veiculos[totCarros++] = x;
                return true;
            }
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Garagem()
        {
        }
        #endregion

        #endregion
    }
}
