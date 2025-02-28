using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCalificaciones
{
    // Interfaz para gestionar alumnos
    public interface IGestionAlumnos
    {
        List<string> MostrarAlumnos();
        void IntroducirAlumno(Alumno alumno);
        void EliminarAlumno(string dni);
        Alumno ConsultarAlumno(string dni);
        void ModificarNota(string dni, double nuevaNota);
        List<string> MostrarSuspensos();
        List<string> MostrarAprobados();
        List<string> MostrarCandidatosMH();
        void ModificarCalificacion(string dni, string nuevaCalificacion);
    }
}