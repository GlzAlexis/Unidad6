using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_Funcio_hash
{
    class Despliegue
    {
        public void Desplegar()
        {
            string array;   // Variable auxiliar

            Console.Write("Ingrese una palabra para verificar que se encuentre dentro de la lista: "); array = Console.ReadLine(); // Se ingresa la palabra
            Proceso proceso = new Proceso();  // Se instancia la clase y se manda a llamar al metodo
            proceso.FuncionHash(array);
        }
    }
}
