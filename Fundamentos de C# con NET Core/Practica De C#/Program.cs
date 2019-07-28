﻿using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine = new EscuelaEngine();
            engine.Inicializar();
 
             ///<SUMMARY>  Hemos aprendido a que esto es una manera de documentar el codigo con ayuda de xml </SUMMARY>     
             ///
             ///

            WriteLine("==================");
            ImpimirCursosEscuela(engine.Escuela);

        }

        private static void ImpimirCursosEscuela(Escuela escuela)
        {
            WriteLine("====================");
            WriteLine("Cursos de la Escuela");
            WriteLine("====================");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
                }
            }
        }


        
    }
}
