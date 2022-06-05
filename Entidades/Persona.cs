using static System.Console;

namespace Postgrado.Entidades
{
    public class Persona
    {
        public string Id {get; set; }
        public string? Ci { get; set; }
        public Expedido? Expedido { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }

        public Persona() => Id = Guid.NewGuid().ToString();
        public Persona(string ci, Expedido expedido, string nombres, string apellidos,string email,string telefono) 
        => (this.Id, this.Ci, this.Expedido, this.Nombres, this.Apellidos,this.Email, this.Telefono) = (Guid.NewGuid().ToString(), ci, expedido, nombres, apellidos,email,telefono);

        public virtual void Printer() {
            WriteLine($"Id: {this.Id}, CI: {this.Ci} {this.Expedido}");
            WriteLine($"Nombre Completo: {this.Nombres} {this.Apellidos}");
            WriteLine($"Email: {this.Email} ");
            WriteLine($"Teléfono: {this.Telefono} ");
        }
    }
}