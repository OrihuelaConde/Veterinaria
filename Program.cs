using System;
using System.Collections.Generic;

namespace Veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            List<Mascota> mascotas = new List<Mascota>();
            do
            {
                Console.WriteLine("1- Agregar mascota");
                Console.WriteLine("2- Mostrar mascotas");
                Console.WriteLine("0- Salir");
                Console.Write("\nSeleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Mascota nuevaMascota = new Mascota();
                        Console.Write("Nombre: ");
                        nuevaMascota.nombre = Console.ReadLine();
                        Console.Write("Tipo: ");
                        nuevaMascota.tipo = Console.ReadLine();
                        Console.Write("Año de nacimiento: ");
                        nuevaMascota.anioNacimiento = int.Parse(Console.ReadLine());
                        Console.Write("Mes de vencimiento de las vacunas: ");
                        nuevaMascota.mesVencimientoVacunas = int.Parse(Console.ReadLine());
                        mascotas.Add(nuevaMascota);
                        break;
                    case 2:
                        for(int i = 0; i < mascotas.Count; i++)
                        {
                            Console.WriteLine("Nombre: " + mascotas[i].nombre);
                            Console.WriteLine("Tipo: " + mascotas[i].tipo);
                            Console.WriteLine("Año de nacimiento: " + mascotas[i].anioNacimiento);
                            Console.WriteLine("Mes de vencimiento de las vacunas: " + mascotas[i].mesVencimientoVacunas);
                        }
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);
        }
    }
}
