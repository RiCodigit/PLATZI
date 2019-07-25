using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                        ciudad: "Bogotá", pais: "Colombia"
                        );

            escuela.Cursos = new List<Curso>(){
                        new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana },
                        new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana},
                        new Curso{Nombre = "301", Jornada = TiposJornada.Mañana}
            };

            escuela.Cursos.Add(new Curso { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso { Nombre = "202", Jornada = TiposJornada.Tarde });

            var otrColeccion = new List<Curso>(){
                        new Curso(){ Nombre = "401", Jornada = TiposJornada.Mañana },
                        new Curso() {Nombre = "501", Jornada = TiposJornada.Mañana},
                        new Curso{Nombre = "501", Jornada = TiposJornada.Tarde}
            };
            
 
            escuela.Cursos.AddRange(otrColeccion);
            ImpimirCursosEscuela(escuela);

            
            escuela.Cursos.RemoveAll(delegate (Curso cur)
            {
                return cur.Nombre == "301";
            });

            //Expresion mas compacta que la de arriba (Expresion Lambda)
            // Lo que hace esto es lo mismo que arriba, cogemos el curs y lo comparamos con los los que tenemos y si coincide con el parametro
            //que estamos poniendo .Nombre="501" entonces los borrará.
            // escuela.Cursos.RemoveAll((Curso cur) => cur.Nombre == "501");

            //Si quisiera solo borrar uno de los dos cursos 501 , ya que hay dos TipoJornada .Mañana y .Tarde , podemos hacer mas grande la condicion
            escuela.Cursos.RemoveAll((Curso cur) => cur.Nombre == "501" && cur.Jornada == TiposJornada.Mañana);
            

             ///<SUMMARY>  Hemos aprendido a que esto es una manera de documentar el codigo con ayuda de xml </SUMMARY>     
             ///
             ///

            WriteLine("==================");
            ImpimirCursosEscuela(escuela);

        }

        /*
        En la clase 22 usamos esta funcion para aprender a usar los delegados y predicados con el ejemplo que se muestra en la misma
        pero en la clase 23 usamos otro tipo de expresiones para usar los delegados, las Expresiones Lambda , por tanto este metodo ya 
        no es util.

            private static bool Predicado(Curso curs)
            {
                return curs.Nombre == "301";
            } 
        */

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


        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre  }, Id  {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre  }, Id  {arregloCursos[contador].UniqueId}");
                contador++;
            } while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine($"Nombre {arregloCursos[i].Nombre  }, Id  {arregloCursos[i].UniqueId}");
            }
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                Console.WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
            }
        }
    }
}
