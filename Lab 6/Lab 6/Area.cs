using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab_6
{
    [Serializable]
    class Area : Division
    {
        string Nombre;
        Persona Encargado;

        public Area(string nombre, Persona encargado) : base(nombre, encargado)
        {
            Nombre = nombre;
            Encargado = encargado;
        }

        public override void Verinformacion()
        {
            Console.WriteLine("NOMBRE DE ESTA AREA:");
            Console.WriteLine(Nombre);
            Thread.Sleep(2000);
            Console.WriteLine("NOMBRE ENCARGADO DE ESTA AREA:");
            Console.WriteLine(Encargado.nombre);
            Thread.Sleep(2000);
        }
    }
}
