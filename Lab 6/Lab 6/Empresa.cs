﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    [Serializable]
    class Empresa 
    {
        public string nombre;
        public string rut;
        public List<Division> Diviciones= new List<Division>();

        public Empresa(string nombre, string rut)
        {
            this.nombre = nombre;
            this.rut = rut;
        }
    }
}
