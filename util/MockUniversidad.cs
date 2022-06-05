using Postgrado.Entidades;

namespace Postgrado.util
{
  public class MockUniversidad
  {

public Universidad? Universidad { get; set; }

      public MockUniversidad() { }
      public void Inicializar()
      {
          this.Universidad = new Universidad("UCATEC");
          this.MockMaterias();
          this.MockDocentes();
      }
      /**
        * 
        **/
      private void MockMaterias()
      {
          if(this.Universidad !=null)
          {
              this.Universidad.Materias = new List<Materia>(){
                new Materia("ADM111", "ADMINISTRACION I") ,
                new Materia("CNT112", "CONTABILIDAD I"),
                new Materia("MAT113", "MATEMATICAS I"),
                new Materia("ECO114", "ECONOMIA GENERAL"),
                new Materia("ADM115", "LEGISLACION EMPRESARIAL I"),
              };

              Random random = new Random();
              foreach(var c in this.Universidad.Materias)
              {
                  int cantProfesional = random.Next(5,20);
                  c.Profesional = this.MockProfesional(cantProfesional);
              }
          }
      }


      public List<Profesional> MockProfesional(int cantidad)
      {
          string[] nombres = { "Joaquin", "Juan", "Luis", "Farid", "Enrique", "Alvaro", "Nicolás", "Thiago" };
          string[] apellidos = { "Ruiz", "Perez", "Huanca", "Nina", "Lopez", "Murillo", "Herrera", "Ticona" };
          string[] licenciatura = { "Ingenieria de Sistemas", "Diseno Grafico" };
          string[] email = { "uno@gmail.com", "versus@gmail.com","demo@gmail.com","dota@gmail.com", "platzi@gmail.com","datos@gmail.com" };
          string[] telefono = { "67072222", "60624858","707584215","71484652","72045689","41932578" };
          Random random = new Random();
          var listaProfesionales = from n in nombres
                             from a in apellidos
                             from l in licenciatura
                             from e in email
                             from t in telefono
                             select new Profesional() { Ci = random.NextInt64(8000000, 9000000).ToString(), Expedido = GetExpedido(), Nombres = n, Apellidos = a, Licenciatura = l, Email = e, Telefono = t };
          return listaProfesionales.OrderBy((e) => e.Id).Take(cantidad).ToList();
      }


    public void MockDocentes()
      {
          string[] nombres = { "Maria", "Fredy", "Pedro", "Rosa", "Mario", "Marco", "Christian", "Angela" };
          string[] apellidos = { "Ruiz", "Perez", "Huanca", "Nina", "Lopez", "Murillo", "Herrera", "Ticona" };
          string[] especialidad = { "ADMINISTRACION I", "CONTABILIDAD I", "MATEMATICAS I", "ECONOMIA GENERAL", "LEGISLACION EMPRESARIAL I" };
          string[] email = { "uno@gmail.com", "versus@gmail.com","demo@gmail.com","dota@gmail.com", "platzi@gmail.com","datos@gmail.com" };
          string[] telefono = { "67072222", "60624858","707584215","71484652","72045689","41932578" };
          Random random = new Random();

          var listaDocentes = from n in nombres
                             from a in apellidos
                             from es in especialidad
                             from e in email
                             from t in telefono
                             select new Docente() { Ci = random.NextInt64(8000000, 9000000).ToString(), Expedido = GetExpedido(), Nombres = n, Apellidos = a, Especialidad = es,Email = e, Telefono = t };

          if(this.Universidad !=null)
          {
              int cantDocentes = random.Next(5,20);
              this.Universidad.Docentes = listaDocentes.OrderBy((e) => e.Id).Take(cantDocentes).ToList();
          }
      }




      public Expedido GetExpedido()
      {
          Random random = new Random();
          Type type = typeof(Expedido);
          Array values = type.GetEnumValues();
          int index = random.Next(values.Length);
          Expedido randomExpedido = (Expedido)values.GetValue(index);
          return randomExpedido;
      }

      



  }
}