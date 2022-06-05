using static System.Console;

namespace Postgrado.Entidades
{
    public class Educacion
    {
        public string Id {get; set; }
        public string? Nombre { get; set; }
        public int? Duracion { get; set; } // meses
        public string? Modalidad { get; set; }
        public int? NumeroBecasPermitidas { get; set; }
        public int? Costo { get; set; }
        public string? Objetivo { get; set; }


        public Educacion() => Id = Guid.NewGuid().ToString();
        public Educacion(string nombre, int duracion,string modalidad, int numeroBecasPermitidas, int costo, string objetivo) 
        => (this.Id,  this.Nombre, this.Duracion, this.Modalidad, this.NumeroBecasPermitidas, this.Costo, this.Objetivo) = (Guid.NewGuid().ToString(), nombre, duracion, modalidad, numeroBecasPermitidas, costo, objetivo);

        public virtual void Printer() {
            WriteLine($"Nombre: {this.Nombre}");
            WriteLine($"Duración: {this.Duracion}");
            WriteLine($"Modalidad: {this.Modalidad}");
            WriteLine($"Numero de Becas Permitidas: {this.NumeroBecasPermitidas}");
            WriteLine($"Costo: {this.Costo}");
            WriteLine($"Objetivo: {this.Objetivo}");
            //WriteLine("\n");
        }
    }
}
