using static System.Console;

namespace Postgrado.Entidades
{
    public class Materia
    {
        public string Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public List<Profesional>? Profesional {get; set;}
        
        public Materia(String codigo, string nombre) => (this.Id, this.Codigo, this.Nombre) = (Guid.NewGuid().ToString(), codigo, nombre);
        
        public Materia() => this.Id = Guid.NewGuid().ToString();
        public void Printer()
        {
            WriteLine("=================================================================");
            WriteLine($"Nombre de la Materia: [- {this.Nombre} -]");
            WriteLine($"id: {this.Id}. Código: {this.Codigo}");
            WriteLine("=================================================================");

            WriteLine("-------------------------------------------");
            WriteLine("Lista de Estudiantes (Profesionales)");
            WriteLine("-------------------------------------------");

            if(this.Profesional != null)
            {
                foreach(Profesional est in this.Profesional)
                {
                    est.Printer();
                }
            }

            WriteLine("-------------------------------");
        }
    }
}