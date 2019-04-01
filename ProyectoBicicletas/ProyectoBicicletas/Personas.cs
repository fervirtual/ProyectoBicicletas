using System.IO;
namespace ProyectoBicicletas
{
    public class Personas : IAlquileres
    {
        private int _precioalquiler;
        private string _nombre;
        private string _apellido;

        public int CalcularAlquileres(int precio, int horas, int personas)
        {
           return _precioalquiler = (horas * precio) * personas;
        }

        void IAlquileres.PersistirDatos(int precio, int horas, int personas)
        {
            using (Stream fs = new FileStream("./PersistirDatos.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"{precio}", horas, personas);
                }
            }
        }

        //Aca las propiedades para los nombres y apellidos
        public string Nombre => _nombre;
        public string Apellido => _apellido;
    }
}
