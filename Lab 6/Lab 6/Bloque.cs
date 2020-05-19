using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab_6
{
    [Serializable]
    class Bloque : Division
    {
        List<Persona> Listapersonal;
        string Nombre;
        Persona Encargado;
        public Bloque(string nombre, Persona encargado, List<Persona> listapersonal) : base(nombre, encargado)
        {
            Nombre = nombre;
            Encargado = encargado;
            Listapersonal = listapersonal;
        }


        public override void Verinformacion()
        {
            Console.WriteLine("NOMBRE DE ESTE BLOQUE:");
            Console.WriteLine(Nombre);
            Thread.Sleep(2000);
            Console.WriteLine("NOMBRE ENCARGADO DE ESTE BLOQUE:");
            Console.WriteLine(Encargado.nombre);
            Thread.Sleep(2000);
            for (int i = 0; i < Listapersonal.Count; i++)
            {
                Console.WriteLine("NOMBRE DEL PERSONAL " + i);
                Console.WriteLine(Listapersonal[i].nombre);
                Thread.Sleep(2000);
            }




        }
    }
}
