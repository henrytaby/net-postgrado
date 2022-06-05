using static System.Console;

namespace Postgrado.Entidades
{
    public class Diplomado: Educacion
    {
        public string? TipoDiplomado { get; set; }

        public Diplomado(){}
        public Diplomado(string nombre, int duracion,string modalidad, int numeroBecasPermitidas, int costo, string objetivo, string tipoDiplomado): base(nombre, duracion, modalidad, numeroBecasPermitidas, costo, objetivo) 
        {
            this.TipoDiplomado = tipoDiplomado;
        }

        override public void Printer () {
            base.Printer();
            WriteLine($"Tipo Diplomado : {this.TipoDiplomado} ");
            WriteLine("----------------------------------------------------------------------");
        }

    }
}