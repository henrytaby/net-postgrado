using static System.Console;

namespace Postgrado.Entidades
{
    public class Curso: Educacion
    {
        public string? Categoria { get; set; }

        public Curso(){}
        public Curso(string nombre, int duracion,string modalidad, int numeroBecasPermitidas, int costo, string objetivo, string categoria): base(nombre, duracion, modalidad, numeroBecasPermitidas, costo, objetivo) 
        {
            this.Categoria = categoria;
        }

        override public void Printer () {
            base.Printer();
            WriteLine($"Categoría del Curso : {this.Categoria} ");
            WriteLine("----------------------------------------------------------------------");
        }

    }
}