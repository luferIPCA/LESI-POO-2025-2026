/*
*	<copyright file="Aula_4___Pilares.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/28/2025 3:22:11 PM</date>
*	<description></description>
**/
using System;
using System.Security.AccessControl;

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

        /// <summary>
        /// Converão de tipos
        /// VER: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast?devlangs=csharp&f1url=%3FappId%3DDev17IDEF1%26l%3DEN-US%26k%3Dk(typeof_CSharpKeyword)%3Bk(TargetFrameworkMoniker-.NETFramework%2CVersion%3Dv4.8.1)%3Bk(DevLang-csharp)%26rd%3Dtrue
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Pessoa aux;
            //if (obj.GetType() == typeof(Pessoa))
            if (obj is Pessoa)  //verifica antes de converter
            {
                aux = obj as Pessoa;     
                return (String.Compare(aux.Nome, this.Nome) == 0);
            }
            else return false;
        }


        public static bool operator==(Pessoa p1, Pessoa p2)
        {
            return (String.Compare(p1.Nome, p2.Nome) == 0);
            //return p1.Equals(p2);
        }

        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            return !(p1==p2);
            //return !p1.Equals(p2);
            //return (String.Compare(p1.Nome, p2.Nome) != 0);

        }

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
