using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading;


namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string salir="";
            while (salir != "1")
            {
                Console.WriteLine("DESEA UTILIZAR UN ARCHIVO PARA CARGAR LA INFORMACION DE LA EMPRESA?");
                Console.WriteLine("1. NO");
                Console.WriteLine("2. SI");
                string respuesta = Console.ReadLine();
                switch (respuesta)
                {
                    case "1":
                        {
                            Console.WriteLine("INGRESE NOMBRE DE LA EMPRESA");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("INGRESE RUT DE LA EMPRESA");
                            string rut = Console.ReadLine();
                            Empresa empresa = new Empresa(nombre, rut);
                            BinaryFormatter formatter2 = new BinaryFormatter();
                            Stream mistream2 = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter2.Serialize(mistream2,empresa);
                            mistream2.Close();
                            salir = "1";
                            Thread.Sleep(2000);
                            break;
                        }
                    case "2":
                        {
                            try
                            {
                                BinaryFormatter formatter = new BinaryFormatter();
                                Stream mistream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                                Empresa empresa = (Empresa)formatter.Deserialize(mistream);
                                mistream.Close();
                                Console.WriteLine("EMPRESA LEIDA");
                                Thread.Sleep(2000);
                                salir = "1";
                            }
                            catch(Exception)
                            {
                                Console.WriteLine("No se encuentra ninguna empresa en el archivo empresas.bin");
                                Console.WriteLine("Procederemos a crear empresa");
                                Console.WriteLine("INGRESE NOMBRE DE LA EMPRESA");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("INGRESE RUT DE LA EMPRESA");
                                string rut = Console.ReadLine();
                                Empresa empresa = new Empresa(nombre, rut);
                                BinaryFormatter formatter2 = new BinaryFormatter();
                                Stream mistream2 = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                                formatter2.Serialize(mistream2, empresa);
                                mistream2.Close();
                                Console.WriteLine("EMPRESA CREADA");
                                Thread.Sleep(2000);
                                salir = "1";
                                break;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("RESPUESTA ERRONEA, SI DESEA SALIR PRESIONE 1");
                            salir = Console.ReadLine();
                            break;
                        }

                }
            }
            //Para leer
            //BinaryFormatter formatter = new BinaryFormatter();
            //Stream mistream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            //List<Empresa> listadeempresas = (List<Empresa>)formatter.Deserialize(mistream);
            //mistream.Close();
        }
    }
}
