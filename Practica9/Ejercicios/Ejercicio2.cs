using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9.Ejercicios
{
    class Ejercicio2
    {
        public struct Alumnos
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private double cum;


            public void setCum(double cum)
            {
                if (cum >= 0)
                {
                    if (cum <= 10)
                    {
                        this.cum = cum;
                    }


                }
            }

            public double getCum()
            {
                return cum;
            }


        }



        static void Main(string[] args)
        {

            Dictionary<string, Alumnos> datosA = new Dictionary<string, Alumnos>();


            int opc;
            Console.WriteLine("  Menu Principal.");
            Console.WriteLine("  [1].Agregar Alumno ");
            Console.WriteLine("  [2].Mostrar Alumnos ");
            Console.WriteLine("  [3].Eliminar Alumno ");
            Console.WriteLine("  [4].Buscar Alumno ");
            Console.WriteLine("  [6].Vaciar Diccionario ");
            Console.WriteLine("  [7].Salir ");
            Console.WriteLine("-------------------------");
            opc = Convert.ToInt32(Console.ReadLine());
            int cant;

            switch (opc)
            {
                //Agregar alumno
                case 1:
                    Console.Clear();
                    Console.Write("Cuantos alumnos desea ingresar: ");
                    cant = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    for (int i = 0; i < cant; i++)
                    {
                        Alumnos A = new Alumnos();
                        Console.WriteLine("Alumno #{0}", i + 1);
                        do
                        {
                            Console.Write("Ingrese el carnet del alumno: ");
                            A.carnet = Console.ReadLine();
                            if (datosA.ContainsKey(A.carnet))
                            {
                                Console.WriteLine("El carnet: {0} ya existe...", A.carnet);
                            }

                        } while (datosA.ContainsKey(A.carnet));


                        Console.Write("Ingrese el nombre del Alumno: ");
                        A.nombre = Console.ReadLine();
                        Console.Write("Ingrese la carrera del Alumno: ");
                        A.carrera = Console.ReadLine();
                        Console.WriteLine("Ingrese el CUM del Alumno: ");
                        A.setCum(Convert.ToDouble(Console.ReadLine()));
                        datosA.Add(A.carnet, A);





                    }



                    break;

                //Mostrar alumnos
                case 2:
                    Console.Clear();
                    foreach (KeyValuePair<string, Alumnos> datos in datosA)
                    {
                        Console.WriteLine(datos);
                    }
                    break;

                //Eliminar alumno
                case 3:
                    Console.Clear();
                    string e;
                    Console.WriteLine("Ingrese el carnet del alumno que desea eliminar");
                    e = Console.ReadLine();
                    datosA.Remove(e);
                    foreach (KeyValuePair<string, Alumnos> datos in datosA)
                    {
                        Console.WriteLine(datos);
                    }

                    break;

                //Buscar alumno
                case 4:
                    Console.Clear();
                    string b;
                    Console.WriteLine("Ingrese el alumno que desea buscar");
                    b = Console.ReadLine();

                    do
                    {

                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("El alumno se encuentra en la lista.");


                    } while ((datosA.ContainsKey(b)));
                    break;

                //Vaciar diccionario
                case 5:
                    Console.Clear();
                    datosA.Clear();
                    break;

                //Salir
                case 6:
                    Console.Clear();
                    Console.WriteLine("Presione <Enter> para salir");
                    break;



            }





        }


    }
}
