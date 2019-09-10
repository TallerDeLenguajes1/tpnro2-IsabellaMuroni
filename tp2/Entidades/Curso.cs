using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        DateTime Turno;
        List<Alumno> ListaDeAlumnos;
        Empleado Docente;
        string Tema;
        float Cuota;
        float Inscripcion;

        public DateTime Turno1 { get => Turno; set => Turno = value; }
        public List<Alumno> ListaDeAlumnos1 { get => ListaDeAlumnos; set => ListaDeAlumnos = value; }
        public Empleado Docente1 { get => Docente; set => Docente = value; }
        public string Tema1 { get => Tema; set => Tema = value; }
        public float Cuota1 { get => Cuota; set => Cuota = value; }
        public float Inscripcion1 { get => Inscripcion; set => Inscripcion = value; }

        //Métodos
        //public float ValorCuota()
        //{

        //}

        public void CargarAlumno(Alumno NuevoAlmuno)
        {
            this.ListaDeAlumnos1.Add(NuevoAlmuno);
        }
    }

    public class Presencial: Curso { }
    public class SemiPresencial: Curso { }
    public class NoPresencial: Curso { }
}
