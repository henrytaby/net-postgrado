using static System.Console;

namespace Postgrado.Entidades
{
    public class Master: Educacion
    {
        public string? TipoMaster { get; set; }

        public Master(){}
        public Master(string nombre, int duracion,string modalidad, int numeroBecasPermitidas, int costo, string objetivo, string tipoMaster): base(nombre, duracion, modalidad, numeroBecasPermitidas, costo, objetivo) 
        {
            this.TipoMaster = tipoMaster;
        }

        override public void Printer () {
            base.Printer();
            WriteLine($"Especialidad : {this.TipoMaster} ");
            WriteLine("----------------------------------------------------------------------");
        }

    }
}