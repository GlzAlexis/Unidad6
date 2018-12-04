using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_secuencial_2
{
    class Proceso
    {
        private int[] vector;
        public void Cargar()                                            // En este metodo se ingresaran los numero de control de los alumnos
        {
            Console.WriteLine("      ~~~~~ Busqueda Binaria ~~~~~");
            Console.WriteLine("\nIngrese el numero de alumnos que desea capturar su numero de control");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string linea;
            vector = new int[cantidad];
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Alumno " + (f + 1) + ": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
            Console.Clear();
        }

        public void busqueda(int num) // Este es el metodo para buscar el numero de control deseado
        {
            int l = 0, h = 9;
            int m = 0;
            bool found = false;
                while (l <= h && found == false) // Aqui se va buscando el numero de control introducido
            {
                    m = (l + h) / 2;
                    if (vector[m] == num)
                        found = true;
                    if (vector[m] > num)
                        h = m - 1;
                    else
                        l = m + 1;
                }
                if (found == false)
                { Console.Write("\nEste alumno no se encuentra con nosotros"); }
                else                                                                                     // Aqui se despliegua el numero de alumno y el numero de control
                { Console.Write("\nEl numero de control {0} corresponde al alumno {1}", num, m + 1); }
        }

        public void Imprimir()
        {
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");       // Se despliegan todos los numeros de control introducidos
            }
        }
    }
}
