/*
*	<copyright file="Aula_6___PessoaLib.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/13/2025 10:10:10 AM</date>
*	<description></description>
**/
using System;

namespace Aula_6___PessoaLib
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 11/13/2025 10:10:10 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    internal class Morada
    {
        string cidade;

        public Morada()
        {
            cidade = "Barcelos";
        }

        public Morada(string c)
        {
            cidade = c;
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
    }
}
