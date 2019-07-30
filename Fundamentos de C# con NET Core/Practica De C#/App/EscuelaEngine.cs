using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{

    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public List<Evaluaciones> Evaluaciones{get; set;}

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

            List<string> NameEvaluacion = new List<string>(){"Evaluacion1","Evaluacion2","Evaluacion3","Evaluacion4","Evaluacion5"};

            foreach (var curso in Escuela.Cursos)
            {
                List<Alumno> listaAlumnos = curso.Alumnos;
                List<Asignatura> listaAsignatura = curso.Asignaturas;

                var listaEvaluaciones = from listAlum in listaAlumnos
                                        from listAsig in listaAsignatura
                                        from nameEva in NameEvaluacion
                                        select new Evaluaciones{Nombre = nameEva, Alumno = listAlum, Asignatura = listAsig};
                
                Evaluaciones = listaEvaluaciones.ToList();

            }
            

            /*
            
            Solucion del profesor:

                foreach (var curso in Escuela.Cursos)
                {
                        foreach (var asignatura in curso.Asignaturas)
                            {
                                foreach (var alumno in curso.Alumnos)
                                {
                                    
                                    var r = new Random(Environment.TickCount);
                                    
                                    for (int i = 0; i < 5; i++)
                                    {
                                        
                                        var Evalu = new Evaluaciones
                                        {
                                            Asignatura = asignatura,
                                            Nombre = $"{asignatura.Nombre} Evaluación#{i + 1}",
                                            Nota = (float)(5*r.NextDouble()),
                                            Alumno = alumno
                                        };

                                        alumno.Evaluaciones.Add(Evalu);

                                    }
                                }
                            }
                }
             */
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