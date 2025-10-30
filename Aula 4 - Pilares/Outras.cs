/*
*	<copyright file="Aula_4___Pilares.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/28/2025 4:53:50 PM</date>
*	<description>Metodos Protected</description>
**/
using System;

namespace Aula_4___Pilares
{
    /// <summary>
    /// 
    /// </summary>
    public class Pai    
    {
        public void Api()
        {
            InternalMethod();
        }
        protected virtual void InternalMethod()
        {
            Console.WriteLine("Classe Pai");
        }

        
    }
    /// <summary>
    /// 
    /// </summary>
    public class Derived : Pai
    {

        protected override void InternalMethod()
        {
            Console.WriteLine("Classe Derivada");
        }
    }
}
