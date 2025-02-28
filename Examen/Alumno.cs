namespace GestionCalificaciones
{
    // Clase Alumno que hereda de Persona
    public class Alumno : Persona
    {
        public double Nota { get; set; }

        // Propiedad de solo lectura para la calificación
        public string Calificacion
        {
            get
            {
                if (Nota < 5) return "SS"; // Suspenso
                else if (Nota >= 5 && Nota < 7) return "AP"; // Aprobado
                else if (Nota >= 7 && Nota < 9) return "NT"; // Notable
                else if (Nota >= 9 && Nota < 10) return "SB"; // Sobresaliente
                else return "MH"; // Matrícula de Honor
            }
        }

        // Constructor
        public Alumno(string dni, string apellidos, string nombre, double nota)
            : base(dni, apellidos, nombre)
        {
            Nota = nota;
        }

        // Sobrescribir el método MostrarInformacion
        public override string MostrarInformacion()
        {
            return $"{base.MostrarInformacion()} {Nota} {Calificacion}";
        }
    }
}