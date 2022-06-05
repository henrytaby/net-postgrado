using static System.Console;

namespace Postgrado.Entidades
{
    public class Doctorado: Educacion
    {
        public string? Licenciatura { get; set; }
        public string? Maestria { get; set; }
        public int? Creditos { get; set; }
        public Doctorado(){}
        public Doctorado(string nombre, int duracion,string modalidad, int numeroBecasPermitidas, int costo, string objetivo, string licenciatura,string maestria,int creditos): base(nombre, duracion, modalidad, numeroBecasPermitidas, costo, objetivo) 
        {
            this.Licenciatura = licenciatura;
            this.Creditos = creditos;
            this.Maestria = maestria;
        }

        override public void Printer () {
            base.Printer();
            WriteLine($"Licenciatura : {this.Licenciatura} ");
            WriteLine($"Maestria : {this.Maestria} ");
            WriteLine($"Creditos : {this.Creditos} ");
            WriteLine("----------------------------------------------------------------------");
        }

    }
}