using System.Collections.Generic;
using System;

namespace ProyectoBicicletas
{
    class Program
    {
        static void Main(string[] args)
        {
            int _precio = 20;
            int _horas = 24;
            int _cantitdad = 2;

            Queue<int> _miqeue = new Queue<int>(); //FIFO
            IAlquileres _alquiler = new Personas();
            _miqeue.Enqueue(_alquiler.CalcularAlquileres(_precio, _horas, _cantitdad));
            IAlquileres _alquilerFamily = new FamilyRental();
            _miqeue.Enqueue(_alquiler.CalcularAlquileres(_precio, _horas, _cantitdad));

            //Aca se muestra lo que está cargado, con dequeue
            foreach (int datos in _miqeue)
            {
                Console.WriteLine("Dequeue {0}", _miqeue.Dequeue());
            }

            // Cantidad de objetos en la cola
            Console.Write("Cantidad de objetos en la cola :", _miqeue.Count);
        }
    }
}