/*
*	<copyright file="Aula_4___Pilares.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/28/2025 4:53:50 PM</date>
*	<description></description>
**/
using System;

namespace Aula_4___Pilares
{
    /// <summary>
    /// 
    /// </summary>
    public class Base
    {
        public void Api()
        {
            InternalUtilityMethod();
        }
        protected virtual void InternalUtilityMethod()
        {
            Console.WriteLine("Classe Base");
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class Derived : Base
    {
        protected override void InternalUtilityMethod()
        {
            Console.WriteLine("Classe Derivada");
        }
    }
}
