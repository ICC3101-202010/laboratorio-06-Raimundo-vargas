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

                            Console.Clear();
                            Console.WriteLine("CREAR DEPARTAMENTO...");
                            Thread.Sleep(2000);
                            Console.WriteLine("INGRESE EL NOMBRE DEL DEPARTAMENTO");
                            string nombredivision = Console.ReadLine();
                            Console.WriteLine("INGRESE EL NOMBRE DEL ENCARGADO DEL DEPARTAMENTO");
                            string nombreencargado = Console.ReadLine();
                            Console.WriteLine("INGRESE EL APELLIDO DEL ENCARGADO DEL DEPARTAMENTO");
                            string apellidoencargado = Console.ReadLine();
                            Console.WriteLine("INGRESE EL RUT DEL ENCARGADO DEL DEPARTAMENTO");
                            string rutencargado = Console.ReadLine();
                            String cargo = "Encargado";
                            empresa.Diviciones.Add(new Departamento(nombredivision, new Persona(nombreencargado, apellidoencargado, rutencargado, cargo)));

                            Console.Clear();
                            Console.WriteLine("CREAR SECCION...");
                            Thread.Sleep(2000);
                            Console.WriteLine("INGRESE EL NOMBRE DE LA SECCION");
                            nombredivision = Console.ReadLine();
                            Console.WriteLine("INGRESE EL NOMBRE DEL ENCARGADO DE LA SECCION");
                            nombreencargado = Console.ReadLine();
                            Console.WriteLine("INGRESE EL APELLIDO DEL ENCARGADO DE LA SECCION");
                            apellidoencargado = Console.ReadLine();
                            Console.WriteLine("INGRESE EL RUT DEL ENCARGADO DE LA SECCION");
                            rutencargado = Console.ReadLine();
                            cargo = "Encargado";
                            empresa.Diviciones.Add(new Seccion(nombredivision, new Persona(nombreencargado, apellidoencargado, rutencargado, cargo)));

                            Console.Clear();
                            Console.WriteLine("CREAR BLOQUE 1...");
                            Thread.Sleep(2000);
                            Console.WriteLine("INGRESE EL NOMBRE DEL BLOQUE");
                            nombredivision = Console.ReadLine();

                            Console.WriteLine("INGRESE EL NOMBRE DEL ENCARGADO DE LA SECCION");
                            nombreencargado = Console.ReadLine();
                            Console.WriteLine("INGRESE EL APELLIDO DEL ENCARGADO DE LA SECCION");
                            apellidoencargado = Console.ReadLine();
                            Console.WriteLine("INGRESE EL RUT DEL ENCARGADO DE LA SECCION");
                            rutencargado = Console.ReadLine();
                            string cargoencargado = "Encargado";

                            List<Persona> personal = new List<Persona>();

                            Console.WriteLine("INGRESE EL NOMBRE DEL PERSONAL 1 DEL BLOQUE");
                            string nombrepersonal = Console.ReadLine();
                            Console.WriteLine("INGRESE EL APELLIDO DEL PERSONAL 1 DEL BLOQUE");
                            string apellidopersonal = Console.ReadLine();
                            Console.WriteLine("INGRESE EL RUT DEL PERSONAL 1 DEL BLOQUE");
                            string rutpersonal = Console.ReadLine();
                            cargo = "Personal";
                            personal.Add(new Persona(nombrepersonal, apellidopersonal, rutpersonal, cargo));

                            Console.WriteLine("INGRESE EL NOMBRE DEL PERSONAL 2 DEL BLOQUE");
                            nombrepersonal = Console.ReadLine();
                            Console.WriteLine("INGRESE EL APELLIDO DEL PERSONAL 2 DEL BLOQUE");
                            apellidopersonal = Console.ReadLine();
                            Console.WriteLine("INGRESE EL RUT DEL PERSONAL 2 DEL BLOQUE");
                            rutpersonal = Console.ReadLine();
                            cargo = "Personal";
                            personal.Add(new Persona(nombrepersonal, apellidopersonal, rutpersonal, cargo));

                            empresa.Diviciones.Add(new Bloque(nombredivision, new Persona(nombreencargado, apellidoencargado, rutencargado, cargoencargado), personal));

                            Console.Clear();
                            Console.WriteLine("CREAR BLOQUE 2...");
                            Thread.Sleep(2000);
                            Console.WriteLine("INGRESE EL NOMBRE DEL BLOQUE");
                            nombredivision = Console.ReadLine();

                            Console.WriteLine("INGRESE EL NOMBRE DEL ENCARGADO DE LA SECCION");
                            nombreencargado = Console.ReadLine();
                            Console.WriteLine("INGRESE EL APELLIDO DEL ENCARGADO DE LA SECCION");
                            apellidoencargado = Console.ReadLine();
                            Console.WriteLine("INGRESE EL RUT DEL ENCARGADO DE LA SECCION");
                            rutencargado = Console.ReadLine();
                            cargoencargado = "Encargado";

                            List<Persona> personal2 = new List<Persona>();

                            Console.WriteLine("INGRESE EL NOMBRE DEL PERSONAL 1 DEL BLOQUE");
                            nombrepersonal = Console.ReadLine();
                            Console.WriteLine("INGRESE EL APELLIDO DEL PERSONAL 1 DEL BLOQUE");
                            apellidopersonal = Console.ReadLine();
                            Console.WriteLine("INGRESE EL RUT DEL PERSONAL 1 DEL BLOQUE");
                            rutpersonal = Console.ReadLine();
                            cargo = "Personal";
                            personal2.Add(new Persona(nombrepersonal, apellidopersonal, rutpersonal, cargo));

                            Console.WriteLine("INGRESE EL NOMBRE DEL PERSONAL 2 DEL BLOQUE");
                            nombrepersonal = Console.ReadLine();
                            Console.WriteLine("INGRESE EL APELLIDO DEL PERSONAL 2 DEL BLOQUE");
                            apellidopersonal = Console.ReadLine();
                            Console.WriteLine("INGRESE EL RUT DEL PERSONAL 2 DEL BLOQUE");
                            rutpersonal = Console.ReadLine();
                            cargo = "Personal";
                            personal2.Add(new Persona(nombrepersonal, apellidopersonal, rutpersonal, cargo));

                            empresa.Diviciones.Add(new Bloque(nombredivision, new Persona(nombreencargado, apellidoencargado, rutencargado, cargoencargado), personal2));

                            Almacenar(empresa);

                            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA SALIR");
                            Console.ReadLine();
                            salir = "1";
                            Thread.Sleep(2000);
                            break;
                        }
                    case "2":
                        {
                            try
                            {

                                Console.WriteLine("EMPRESA LEIDA");
                                Thread.Sleep(2000);
                                Empresa empresa = Cargar();
                                Console.WriteLine("NOMBRE EMPRESA:");
                                Console.WriteLine(empresa.nombre);
                                Thread.Sleep(2000);
                                Console.WriteLine("RUT EMPRESA:");
                                Console.WriteLine(empresa.rut);
                                Thread.Sleep(2000);
                                for (int i = 0; i < empresa.Diviciones.Count; i++)
                                {
                                    empresa.Diviciones[i].Verinformacion();
                                }
                                Console.WriteLine("PRESIONE CUALQUIER TECLA PARA SALIR");
                                Console.ReadLine();
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

                                Console.Clear();
                                Console.WriteLine("CREAR DEPARTAMENTO...");
                                Thread.Sleep(2000);
                                Console.WriteLine("INGRESE EL NOMBRE DEL DEPARTAMENTO");
                                string nombredivision = Console.ReadLine();
                                Console.WriteLine("INGRESE EL NOMBRE DEL ENCARGADO DEL DEPARTAMENTO");
                                string nombreencargado = Console.ReadLine();
                                Console.WriteLine("INGRESE EL APELLIDO DEL ENCARGADO DEL DEPARTAMENTO");
                                string apellidoencargado = Console.ReadLine();
                                Console.WriteLine("INGRESE EL RUT DEL ENCARGADO DEL DEPARTAMENTO");
                                string rutencargado = Console.ReadLine();
                                String cargo = "Encargado";
                                empresa.Diviciones.Add(new Departamento(nombredivision, new Persona(nombreencargado, apellidoencargado, rutencargado, cargo)));

                                Console.Clear();
                                Console.WriteLine("CREAR SECCION...");
                                Thread.Sleep(2000);
                                Console.WriteLine("INGRESE EL NOMBRE DE LA SECCION");
                                nombredivision = Console.ReadLine();
                                Console.WriteLine("INGRESE EL NOMBRE DEL ENCARGADO DE LA SECCION");
                                nombreencargado = Console.ReadLine();
                                Console.WriteLine("INGRESE EL APELLIDO DEL ENCARGADO DE LA SECCION");
                                apellidoencargado = Console.ReadLine();
                                Console.WriteLine("INGRESE EL RUT DEL ENCARGADO DE LA SECCION");
                                rutencargado = Console.ReadLine();
                                cargo = "Encargado";
                                empresa.Diviciones.Add(new Seccion(nombredivision, new Persona(nombreencargado, apellidoencargado, rutencargado, cargo)));

                                Console.Clear();
                                Console.WriteLine("CREAR BLOQUE 1...");
                                Thread.Sleep(2000);
                                Console.WriteLine("INGRESE EL NOMBRE DEL BLOQUE");
                                nombredivision = Console.ReadLine();

                                Console.WriteLine("INGRESE EL NOMBRE DEL ENCARGADO DE LA SECCION");
                                nombreencargado = Console.ReadLine();
                                Console.WriteLine("INGRESE EL APELLIDO DEL ENCARGADO DE LA SECCION");
                                apellidoencargado = Console.ReadLine();
                                Console.WriteLine("INGRESE EL RUT DEL ENCARGADO DE LA SECCION");
                                rutencargado = Console.ReadLine();
                                string cargoencargado = "Encargado";

                                List<Persona> personal = new List<Persona>();

                                Console.WriteLine("INGRESE EL NOMBRE DEL PERSONAL 1 DEL BLOQUE");
                                string nombrepersonal = Console.ReadLine();
                                Console.WriteLine("INGRESE EL APELLIDO DEL PERSONAL 1 DEL BLOQUE");
                                string apellidopersonal = Console.ReadLine();
                                Console.WriteLine("INGRESE EL RUT DEL PERSONAL 1 DEL BLOQUE");
                                string rutpersonal = Console.ReadLine();
                                cargo = "Personal";
                                personal.Add(new Persona(nombrepersonal, apellidopersonal, rutpersonal, cargo));

                                Console.WriteLine("INGRESE EL NOMBRE DEL PERSONAL 2 DEL BLOQUE");
                                nombrepersonal = Console.ReadLine();
                                Console.WriteLine("INGRESE EL APELLIDO DEL PERSONAL 2 DEL BLOQUE");
                                apellidopersonal = Console.ReadLine();
                                Console.WriteLine("INGRESE EL RUT DEL PERSONAL 2 DEL BLOQUE");
                                rutpersonal = Console.ReadLine();
                                cargo = "Personal";
                                personal.Add(new Persona(nombrepersonal, apellidopersonal, rutpersonal, cargo));

                                empresa.Diviciones.Add(new Bloque(nombredivision, new Persona(nombreencargado, apellidoencargado, rutencargado, cargoencargado), personal));

                                Console.Clear();
                                Console.WriteLine("CREAR BLOQUE 2...");
                                Thread.Sleep(2000);
                                Console.WriteLine("INGRESE EL NOMBRE DEL BLOQUE");
                                nombredivision = Console.ReadLine();

                                Console.WriteLine("INGRESE EL NOMBRE DEL ENCARGADO DE LA SECCION");
                                nombreencargado = Console.ReadLine();
                                Console.WriteLine("INGRESE EL APELLIDO DEL ENCARGADO DE LA SECCION");
                                apellidoencargado = Console.ReadLine();
                                Console.WriteLine("INGRESE EL RUT DEL ENCARGADO DE LA SECCION");
                                rutencargado = Console.ReadLine();
                                cargoencargado = "Encargado";

                                List<Persona> personal2 = new List<Persona>();

                                Console.WriteLine("INGRESE EL NOMBRE DEL PERSONAL 1 DEL BLOQUE");
                                nombrepersonal = Console.ReadLine();
                                Console.WriteLine("INGRESE EL APELLIDO DEL PERSONAL 1 DEL BLOQUE");
                                apellidopersonal = Console.ReadLine();
                                Console.WriteLine("INGRESE EL RUT DEL PERSONAL 1 DEL BLOQUE");
                                rutpersonal = Console.ReadLine();
                                cargo = "Personal";
                                personal2.Add(new Persona(nombrepersonal, apellidopersonal, rutpersonal, cargo));

                                Console.WriteLine("INGRESE EL NOMBRE DEL PERSONAL 2 DEL BLOQUE");
                                nombrepersonal = Console.ReadLine();
                                Console.WriteLine("INGRESE EL APELLIDO DEL PERSONAL 2 DEL BLOQUE");
                                apellidopersonal = Console.ReadLine();
                                Console.WriteLine("INGRESE EL RUT DEL PERSONAL 2 DEL BLOQUE");
                                rutpersonal = Console.ReadLine();
                                cargo = "Personal";
                                personal2.Add(new Persona(nombrepersonal, apellidopersonal, rutpersonal, cargo));

                                empresa.Diviciones.Add(new Bloque(nombredivision, new Persona(nombreencargado, apellidoencargado, rutencargado, cargoencargado), personal2));

                                Almacenar(empresa);
                                salir = "1";
                                Console.WriteLine("EMPRESA CREADA");
                                Thread.Sleep(2000);
                                Console.WriteLine("PRESIONE CUALQUIER TECLA PARA SALIR");
                                Console.ReadLine();
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
        }
        static void Almacenar(Empresa empresa)
        {
            BinaryFormatter formatter2 = new BinaryFormatter();
            Stream mistream2 = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter2.Serialize(mistream2, empresa);
            mistream2.Close();
        }
        static Empresa Cargar()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream mistream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            Empresa empresa = (Empresa)formatter.Deserialize(mistream);
            mistream.Close();
            return empresa;
            
        }
    }
}
