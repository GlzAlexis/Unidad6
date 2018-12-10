using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_Busqueda_binaria
{
    class Proceso
    {
        public void Busqueda(int numero, int noelementos, int[] array)       // Este es el metodo de busqueda binaria que busca por cifras que se encuentran dentro del arreglo
        {
            int centro = 0, menor = 0, mayor = noelementos;                  // Se declaran las variables que necesitaremos y a mayor le damos el largo que tiene el arreglo
            bool encontrar = false;
            while(menor <= mayor && encontrar == false)                      // Este while nos dice que si la variable menor es menor o igual a mayor entonces la variable encontrar sera falsa
            {
                centro = (menor + mayor) / 2;                                // Se calcula el centro sumando el menor mas el mayor y dividiendo el resultado entre 2
                if (array[centro] == numero) { encontrar = true; }           // Si la posicion centro es igual al numero que estamos buscando entonces la variable encontrar sera cierta
                else if (array[centro] < numero) { menor = (centro + 1); }   // Si la posicion del centro es menor al numero que estamos buscando entonces nos recorreremos una posicion para adelante
                else { mayor = (centro - 1); }                               // De lo contrario se recorrera
            }
            if(encontrar == false) { Console.WriteLine("\nEl elemento no se encontro"); }        // Si encontrar es igual a false entonces se desplegara lo siguiente
            else { Console.WriteLine("\nEl elemento se encuentra en la posicion: " + centro); }  // De lo contrario se desplegara que si se encontro
        } 
        public void busquedan(int nombre, int noelementos, string[] array)   // Este es el metodo de busqueda binaria que busca por medio de la posicion del arreglo
        {
            nombre = array.Length;                                           // Se le asigna al nombre el tamano del arreglo
            int centro = 0, menor = 0, mayor = noelementos;                  // Se declaran las variables que necesitaremos, a mayor le damos el largo que tiene el arreglo
            bool encontrar = false;
            while(menor <= mayor && encontrar == false)                      // Este while nos dice que si la variable menor es menor o igual a mayor entonces la variable encontrar sera falsa
            {
                centro = (menor + mayor) / 2;                                // Se calcula el centro sumando el menor mas el mayor y dividiendo el resultado entre 2
                if (array.Length == nombre) { encontrar = true; }            // Si el tamano del arreglo es igual a nombre entonces la variable encontrar sera cierta
                else if(array.Length < centro) { menor = (centro + 1); }     // Si el tamano del arreglo es menor a centro entonces a menor se le asigna la sumatoria de centro mas 1
                else { mayor = (centro - 1); }                               // De lo contrario a mayor se le asignara la sumatoria de centro menos 1
            }
            if (encontrar == false) { Console.WriteLine("\nEl elemento no se encontro"); }        // Si encontrar es igual a false entonces se desplegara lo siguiente
            else { Console.WriteLine("\nEl elemento es el siguiente: " + array[centro + 1]); }    // De lo contrario se desplegara que si se encontro y se le sumara uno para encontrar la posicion real
        }
    }
}
