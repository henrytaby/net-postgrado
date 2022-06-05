using static System.Console;

namespace Postgrado.Entidades
{
  public class Universidad
  {
    public string Nombre { get; set; }

    public List<Materia>? Materias { get; set; }

    public List<Docente>? Docentes { get; set; }

    public Universidad(string nombre)
    {
      this.Nombre = nombre;
    }

    public void Printer()
    {
      //WriteLine("====================");
      WriteLine($"--------------------------------------------[ UNIVERSIDAD: {this.Nombre} ] --------------------------------------------");
      //WriteLine("====================");
      WriteLine($"-----------------------------------------/// [ MATERIAS & ALUMNOS ] ///-----------------------------------------");
      if (this.Materias != null)
      {
        foreach (Materia mat in this.Materias)
        {
          mat.Printer();
        }
      }
      WriteLine($"-----------------------------------------/// [ DOCENTES ] ///-----------------------------------------");
       if (this.Docentes != null)
      {
        foreach (Docente doc in this.Docentes)
        {
          doc.Printer();
        }
      }

      WriteLine("====================");
    }
  }
}