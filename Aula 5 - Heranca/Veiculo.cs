/*
*	<copyright file="Aula_5___Heranca.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/6/2025 10:13:27 AM</date>
*	<description></description>
**/
using System;

namespace Aula_5___Heranca
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 11/6/2025 10:13:27 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class AbsVeiculo : IVeiculo
    {
        #region Attributes
        int ano;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public AbsVeiculo()
        {
        }

        #endregion

        #region Properties

        public int Ano
        {
            get { return ano; }
            set { ano = (value > 0) ? value : 0; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public int QuantosKms(int x)
        {
            return x * 2;
        }

        public int QuantosKmsGerais( IVeiculo x)
        {
            return (x.QuantosKms(20) + 200);
        }

        public bool EstaPago()
        {
            if (ano == 2025) return true;
            return false;
        }

        public abstract bool CarroBom();
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~AbsVeiculo()
        {
        }
        #endregion

        #endregion
    }


    public class Veiculo : AbsVeiculo
    {
        //TEM DE IMPLEMENTAR TODOS OS METODS ABSTRACT HERDADOS

        public override bool CarroBom()
        {
            return true;
        }
    }
}
