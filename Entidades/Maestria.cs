using static System.Console;

namespace Postgrado.Entidades
{
    public class Maestria: Educacion
    {
        public string? Licenciatura { get; set; }
        public int? Creditos { get; set; }

        public Maestria(){}
        public Maestria(string nombre, int duracion,string modalidad, int numeroBecasPermitidas, int costo, string objetivo, string licenciatura,int creditos): base(nombre, duracion, modalidad, numeroBecasPermitidas, costo, objetivo) 
        {
            this.Licenciatura = licenciatura;
            this.Creditos = creditos;
        }

        override public void Printer () {
            base.Printer();
            WriteLine($"Licenciatura : {this.Licenciatura} ");
            WriteLine($"Creditos : {this.Creditos} ");
            WriteLine("----------------------------------------------------------------------");
        }

    }
}