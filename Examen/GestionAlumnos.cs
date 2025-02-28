using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionCalificaciones
{
    // Clase que implementa la interfaz IGestionAlumnos
    public class GestionAlumnos : IGestionAlumnos
    {
        private List<Alumno> alumnos = new List<Alumno>();

        // Mostrar todos los alumnos
        public List<string> MostrarAlumnos()
        {
            if (alumnos.Count == 0)
            {
                return new List<string> { "No hay alumnos registrados." };
            }

            return alumnos.Select(a => a.MostrarInformacion()).ToList();
        }

        // Introducir un nuevo alumno
        public void IntroducirAlumno(Alumno alumno)
        {
            if (alumnos.Any(a => a.DNI == alumno.DNI))
            {
                throw new Exception("Error: Ya existe un alumno con ese DNI.");
            }

            alumnos.Add(alumno);
        }

        // Eliminar un alumno por DNI
        public void EliminarAlumno(string dni)
        {
            var alumno = alumnos.FirstOrDefault(a => a.DNI == dni);
            if (alumno == null)
            {
                throw new Exception("Error: No se encontró ningún alumno con ese DNI.");
            }

            alumnos.Remove(alumno);
        }

        // Consultar un alumno por DNI
        public Alumno ConsultarAlumno(string dni)
        {
            var alumno = alumnos.FirstOrDefault(a => a.DNI == dni);
            if (alumno == null)
            {
                throw new Exception("Error: No se encontró ningún alumno con ese DNI.");
            }

            return alumno;
        }

        // Modificar la nota de un alumno por DNI
        public void ModificarNota(string dni, double nuevaNota)
        {
            var alumno = alumnos.FirstOrDefault(a => a.DNI == dni);
            if (alumno == null)
            {
                throw new Exception("Error: No se encontró ningún alumno con ese DNI.");
            }

            alumno.Nota = nuevaNota;
        }

        // Mostrar alumnos suspensos
        public List<string> MostrarSuspensos()
        {
            var suspensos = alumnos.Where(a => a.Nota < 5).ToList();
            if (suspensos.Count == 0)
            {
                return new List<string> { "No hay alumnos suspensos." };
            }

            return suspensos.Select(a => a.MostrarInformacion()).ToList();
        }

        // Mostrar alumnos aprobados
        public List<string> MostrarAprobados()
        {
            var aprobados = alumnos.Where(a => a.Nota >= 5).ToList();
            if (aprobados.Count == 0)
            {
                return new List<string> { "No hay alumnos aprobados." };
            }

            return aprobados.Select(a => a.MostrarInformacion()).ToList();
        }

        // Mostrar candidatos a MH (Matrícula de Honor)
        public List<string> MostrarCandidatosMH()
        {
            var mh = alumnos.Where(a => a.Nota == 10).ToList();
            if (mh.Count == 0)
            {
                return new List<string> { "No hay candidatos a Matrícula de Honor." };
            }

            return mh.Select(a => a.MostrarInformacion()).ToList();
        }

        // Modificar la calificación manualmente
        public void ModificarCalificacion(string dni, string nuevaCalificacion)
        {
            var alumno = alumnos.FirstOrDefault(a => a.DNI == dni);
            if (alumno == null)
            {
                throw new Exception("Error: No se encontró ningún alumno con ese DNI.");
            }

        }
    }
}