using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Institucion
    {
        string Nombre;
        string MatriculaMinisterio;
        List<Curso> ListaDeCursos;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string MatriculaMinisterio1 { get => MatriculaMinisterio; set => MatriculaMinisterio = value; }
        public List<Curso> ListaDeCursos1 { get => ListaDeCursos; set => ListaDeCursos = value; }
    }
}
