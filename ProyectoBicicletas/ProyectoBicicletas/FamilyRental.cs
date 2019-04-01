using System;
using System.IO;

namespace ProyectoBicicletas
{
    class FamilyRental : IAlquileres
    {
        private int _precioalquiler;
        private int _personas;
        private int _horas;
        private double _descuento = 0.30;


        public int CalcularAlquileres(int precio, int horas, int personas)
        {
            if (personas >= 3 && personas <= 5)
            {
                _precioalquiler = (horas * precio) * personas;
                _precioalquiler = Convert.ToInt32(_precioalquiler * _descuento);
            }
            else
            {
                _precioalquiler = (horas * precio) * personas;
            }
            return _precioalquiler;
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

        //Aca las propiedades
        public int Precio => _precioalquiler;
        public int Horas => _horas;
        public int Personas => _personas;
    }
}