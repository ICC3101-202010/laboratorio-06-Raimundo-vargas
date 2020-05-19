using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab_6
{
    [Serializable]
    class Departamento : Division
    {
        string Nombre;
        Persona Encargado;

        public Departamento(string nombre, Persona encargado) : base(nombre, encargado)
        {
            Nombre = nombre;
            Encargado = encargado;
        }

        public override void Verinformacion()
        {
            Console.WriteLine("NOMBRE DE ESTE DEPARTAMENTO:");
            Console.WriteLine(Nombre);
            Thread.Sleep(2000);
            Console.WriteLine("NOMBRE ENCARGADO DE ESTE DEPARTAMENTO:");
            Console.WriteLine(Encargado.nombre);
            Thread.Sleep(2000);
        }
    }
}
