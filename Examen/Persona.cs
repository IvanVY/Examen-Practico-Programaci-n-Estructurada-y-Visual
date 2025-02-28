using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCalificaciones
{
    // Clase base Persona
    public class Persona
    {
        public string DNI { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }

        // Constructor
        public Persona(string dni, string apellidos, string nombre)
        {
            DNI = dni;
            Apellidos = apellidos;
            Nombre = nombre;
        }

        // Método para mostrar información básica
        public virtual string MostrarInformacion()
        {
            return $"{DNI} {Apellidos}, {Nombre}";
        }
    }
}
