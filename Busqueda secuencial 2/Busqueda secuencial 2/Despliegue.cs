using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_secuencial_2
{
    class Despliegue
    {
        public void Desplegar()
        {
            Proceso proceso = new Proceso(); // Se instancia la clase
                proceso.Cargar();              // Se mandan a llamar los metdodos necesarios
            proceso.Imprimir();
                Console.Write("\n\nIntrodusca el numero de control del alumno que desea buscar: ");
                int num = int.Parse(Console.ReadLine());
                proceso.busqueda(num);
                Console.ReadKey();
        }
    }
}
