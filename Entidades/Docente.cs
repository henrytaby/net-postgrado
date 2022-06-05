using static System.Console;

namespace Postgrado.Entidades
{
    public class Docente: Persona
    {
        public string? Especialidad { get; set; }
        public string? FechaRegistro { get; set; }

        public Docente(){}
        public Docente(string ci, Expedido expedido, string nombres, string apellidos,string email,string telefono, string especialidad,string fechaRegistro): base(ci,expedido,nombres,apellidos,email,telefono) 
        {
            this.Especialidad = especialidad;
            this.FechaRegistro = fechaRegistro;
        }

        override public void Printer () {
            base.Printer();
            WriteLine($"Especialidad : {this.Especialidad} ");
            WriteLine("----------------------------------------------------------------------");
        }

    }
}