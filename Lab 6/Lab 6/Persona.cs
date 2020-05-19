using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    [Serializable]
    public class Persona
    {
        public string nombre;
        public string apellido;
        public string rut;
        public string cargo;

        public Persona(string nombre, string apellido, string rut, string cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.rut = rut;
            this.cargo = cargo;
        }
    }
}
