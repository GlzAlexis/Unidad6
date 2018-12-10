using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_Busqueda_binaria
{
    class Despliegue
    {
        public void Menu()                       // Este es el menu principal
        {
            bool salir = true;
            while (salir)
            {
                try
                {
                    Console.WriteLine("    ~~~~~~~ Busqueda binario ~~~~~~~");
                    Console.Write("\n1.- Busqueda de numeros" +                      //Se hace del despligue del menu con las opciones que tendra
                        "\n2.- Busqueda de nombres" +
                        "\n3.- Salir" +
                        "\nTeclee el numero de la opcion que desea seleccionar: "); int menu = Convert.ToInt32(Console.ReadLine()); Console.Clear();
                    switch (menu)                                           
                    {                                                                 // Estas son las opciones que se encontraran disponibles dentro del menu
                        case 1: DespligueBinario(); Console.Clear(); break;           // Se mandan a llamar los metodos que necesitaremos
                        case 2: DespliegueLetras(); Console.Clear(); break;
                        case 3: Console.WriteLine("\nGracias por utilizar este precioso programa. \n\nHasta pronto!!!!"); Console.ReadKey(); salir = false; break;
                        default: Console.WriteLine("Esta opcion no es valida \n\nPor favor introdusca una opcion que se encuentre dentro del menu."); Console.ReadKey(); break;
                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message); Console.ReadKey(); Console.Clear(); }
            }
        }
        public void DespligueBinario()            // Este es el programa binario, en donde se busca un numero en especifico introducido en la lista
        {
            bool salir = true;
            while(salir)
            {
            try
            {
                Console.WriteLine("    ~~~~~~~ Busqueda binario ~~~~~~~");             // Se introducira el numero de elementos que se ingresaran
                Console.Write("\nNOTA: Solamente puede introducir numeros enteros \nIntrodusca el numero de elementos que desea ingresar en la lista: "); int noelementos = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[noelementos];
                Console.Clear();
                Console.WriteLine("    ~~~~~~~ Busqueda binario ~~~~~~~\n\n");
                for (int i = 0; i < noelementos; i++) 
                {                                                                      // Aqui se introduciran las cifras en su posicion respectiva
                    Console.WriteLine("Introdusca el elemento {0}.-  ", (i + 1));
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();
                Console.WriteLine("    ~~~~~~~ Busqueda binario ~~~~~~~\n\nEsta es la lista de numeros que ingreso: ");
                for (int i = 0; i < noelementos; i++) { Console.Write(array[i] + ", "); }                               // En este for despliega los numeros ingresados en la lista
                Array.Sort(array);                                                                                      // Esto los ordena de menor a mayor
                Console.Write("\n\nIntrodusca el numero que desee buscar: "); int numero = Convert.ToInt32(Console.ReadLine());    // Aqui se introduce la cifra que estamos buscando
                Proceso proceso = new Proceso();                     // Se instancia la clase
                proceso.Busqueda(numero, noelementos, array);        // Y se manda a llamar el metodo que ocuparemos
                Console.ReadKey();
                salir = false;
            }
            catch(Exception e) { Console.WriteLine(e.Message); Console.ReadKey(); Console.Clear(); }
            }
        }
        public void DespliegueLetras()            // Este es otro programa binario, a diferencia del otro este busca la posicion que estas buscando
        {                                         // Y te despliega el nombre que se encuentra en dicha posicion
            bool salir = true;
            while (salir)
            {
                try
                {
                    Console.WriteLine("    ~~~~~~~ Busqueda Binaria ~~~~~~~");                           // Se introduciran el numero de elementos que tendra el arreglo
                    Console.Write("Introdusca el numero de elementos que desea ingresar en la lista: "); int noelementos = Convert.ToInt32(Console.ReadLine());
                    string[] array = new string[noelementos];
                    Console.Clear();
                    Console.WriteLine("    ~~~~~~~ Busqueda Binaria ~~~~~~~\n");
                    for(int i = 0; i < noelementos; i++) { Console.Write("\n" + (i + 1) + ".- Introdusca un nombre: "); array[i] = Console.ReadLine(); } // En este for se introduciran los nombres en su respectiva posicion
                    Console.Clear();
                    Console.WriteLine("    ~~~~~~~ Busqueda Binaria ~~~~~~~\n\nLista de nombres ingresados:\n\n");
                    for (int i = 0; i < noelementos; i++) { Console.WriteLine((i + 1) + ".- " + array[i]); }                                             // Este for los desplegara
                    Console.Write("\nIntrodusca la posicion para saber que nombre se encuentra alli: "); int nombre = Convert.ToInt32(Console.ReadLine());// Aqui se introducira la posicion para averiguar que nombre se encuentra alli
                    Proceso proceso = new Proceso();                          // Se instancia la clase
                    proceso.busquedan(nombre, noelementos, array);            // Se manda a llamar al metodo
                    Console.ReadKey();
                    salir = false;
                }
                catch (Exception e) { Console.WriteLine(e.Message); Console.ReadKey(); Console.Clear(); }
            }
        }
    }
}
