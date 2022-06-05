using static System.Console;
namespace Postgrado.Entidades
{
    public class Profesional:Persona
    {
        public string? Licenciatura { get; set;}
        
        public Profesional() { }
        public Profesional(string ci, Expedido expedido, string nombres, string apellidos,string email,string telefono, string licenciatura):base(ci,expedido,nombres,apellidos,email,telefono) 
        {
            this.Licenciatura = licenciatura;
        }

        override public void Printer () {
            base.Printer();
            WriteLine($"Licenciatura : {this.Licenciatura} ");
            WriteLine("-------------------------------<<<<<<<<<<<<<<<<<<<<<<<");
        }

    }
}