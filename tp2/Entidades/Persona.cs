using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        string Nombre;
        string Apellido;
        DateTime FechaDeNacimiento;
        long DNI;

        //Persona() { }//constructor

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public DateTime FechaDeNacimiento1 { get => FechaDeNacimiento; set => FechaDeNacimiento = value; }
        public long DNI1 { get => DNI; set => DNI = value; }

        //Métodos

        public int Edad()
        {
            DateTime FechaActual = DateTime.Today;
            int edad = (FechaActual.Year - FechaDeNacimiento.Year);

            return edad;
        }
    }

    public enum Cargo { Profesor, Preceptor }
    public class Empleado: Persona
    {
        DateTime FechaDeAlta;
        Cargo Cargo;
        float Sueldo;

        public DateTime FechaDeAlta1 { get => FechaDeAlta; set => FechaDeAlta = value; }
        public Cargo Cargo1 { get => Cargo; set => Cargo = value; }
        public float Sueldo1 { get => Sueldo; set => Sueldo = value; }

        //Métodos

        public int Antiguedad()
        {
            DateTime FechaActual = DateTime.Today;
            int antiguedad = (FechaActual.Year - FechaDeAlta.Year);

            return antiguedad;
        }
    }

    public class Alumno: Persona
    {

    }
}
