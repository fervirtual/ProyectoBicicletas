using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoBicicletas
{
    interface IAlquileres
    {
        int CalcularAlquileres(int precio,int horas,int personas);
        void PersistirDatos(int precio, int horas, int personas);
    }
}
