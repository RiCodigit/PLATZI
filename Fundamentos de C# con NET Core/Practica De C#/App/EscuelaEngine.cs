using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{

    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }


        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                        ciudad: "Bogotá", pais: "Colombia"
                        );

            CargarCursos();
            CargarAsignaturas();
            
            foreach (var curso in Escuela.Cursos)
            {
                //Estamos Añadiendo los alumnos del curso al iniciar el program, en la lista de alumnos de Curso.cs
                curso.Alumnos.AddRange(CargarAlumnos());            
            }
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {

        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                //List<Asignatura> es lo mismo que var
                var listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre = "Matemáticas"},
                    new Asignatura{Nombre = "Educación Física"},
                    new Asignatura{Nombre = "Castellano"},
                    new Asignatura{Nombre = "Ciencias Naturales"}
                };
                curso.Asignaturas.AddRange(listaAsignaturas);
            }
        }

        private IEnumerable<Alumno> CargarAlumnos()
        {
            string[] nombre1 = {"Alba","Felipe","Eusebio","Donal"};
            string[] apellido1 = {"Ruiz","Sarmiento","Uribe","Maduro"};
            string[] nombre2 = {"Freddy","Anabel","Rick","Murty"};

            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno{ Nombre = $"{n1} {n2} {a1}"};
            
            return listaAlumnos;
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                        new Curso() {Nombre = "101", Jornada = TiposJornada.Mañana },
                        new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana},
                        new Curso() {Nombre = "301", Jornada = TiposJornada.Mañana},
                        new Curso() {Nombre = "401", Jornada = TiposJornada.Tarde },
                        new Curso() {Nombre = "501", Jornada = TiposJornada.Tarde}
            };
        }

    }

}