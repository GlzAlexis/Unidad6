using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_secuencial_1
{
    class Proceso
    {
        private int[] vector;
        public void Cargar()                                             // En este metodo se ingresaran los elementos deseados
        {
            Console.WriteLine("      ~~~~~ Busqueda Binaria ~~~~~");
            Console.WriteLine("Ingrese 10 Elementos\n");
            string linea;
            vector = new int[10];
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingrese elemento " + (f + 1) + ": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
        }

        public void busqueda(int num)          // Este es el metodo para buscar el elemento que se desea
        {
            int l = 0, h = 9;
            int m = 0;
            bool found = false;

            while (l <= h && found == false)   // Aqui se va buscando el valor introducido
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
            { Console.Write("\nEl elemento {0} no esta en el arreglo", num); }            // Aqui se despliega la posicion y el valor que se introdujo
            else                                                               
            { Console.Write("\nEl elemento {0} esta en la posicion: {1}", num, m + 1); } 
        }

        public void Imprimir()                       // Se imprime el arreglo que se introdujo
        {
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
        }
    }
}
