using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab_6
{
    [Serializable]
    abstract class Division
    {
        string nombre;
        Persona encargado;
        protected Division(string nombre, Persona encargado)
        {
            this.nombre = nombre;
            this.encargado = encargado;
        }

        public abstract void Verinformacion();
        
        
    }
}
