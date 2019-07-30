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
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosRandom(int cantidad)
        {
            string[] nombre1 = {"Alba","Felipe","Eusebio","Donal"};
            string[] apellido1 = {"Ruiz","Sarmiento","Uribe","Maduro"};
            string[] nombre2 = {"Freddy","Anabel","Rick","Murty"};

            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno{ Nombre = $"{n1} {n2} {a1}"};
            
            return listaAlumnos.OrderBy( (al)=> al.UniqueId).Take(cantidad).ToList();
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

            Random rnd = new Random();

            foreach (var c in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 20); //Ponemos dentro del bucle este int para que cada vez que se recorra haya diferentes numero ramdom
                c.Alumnos = GenerarAlumnosRandom(cantRandom);
            }

        }

    }

}