using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_Funcio_hash
{
    class Proceso
    {
        public void FuncionHash(string array2)
        {
            string opc1 = "casa", opc2 = "mesa", opc3 = "cocina", opc4 = "trastes", opc5 = "sala"; // Se declaran las variables con las 5 palabras que contendra el programa
            byte[] temparray;
            temparray = ASCIIEncoding.ASCII.GetBytes(opc1);                              // Se crea una matriz con bytes de los datos de origen
            byte[] palabra1 = new MD5CryptoServiceProvider().ComputeHash(temparray);     // Se calcula el hash con los datos de origen
            temparray = ASCIIEncoding.ASCII.GetBytes(opc2);
            byte[] palabra2 = new MD5CryptoServiceProvider().ComputeHash(temparray);     // Se hace lo mismo con cada una de las palabras 
            temparray = ASCIIEncoding.ASCII.GetBytes(opc3);
            byte[] palabra3 = new MD5CryptoServiceProvider().ComputeHash(temparray);
            temparray = ASCIIEncoding.ASCII.GetBytes(opc4);
            byte[] palabra4 = new MD5CryptoServiceProvider().ComputeHash(temparray);
            temparray = ASCIIEncoding.ASCII.GetBytes(opc5);
            byte[] palabra5 = new MD5CryptoServiceProvider().ComputeHash(temparray);

            temparray = ASCIIEncoding.ASCII.GetBytes(array2);
            byte[] palabrafuera = new MD5CryptoServiceProvider().ComputeHash(temparray);

            bool igual = false;                          // Se utilizara para comprobrar si la palabra ingresada es igual a alguna de ls que ya se encuentran dentro
            if(palabrafuera.Length == palabra1.Length)   // Si la longitud palabra ingresada es igual a alguna de las palabras que se encuentran dentro se compararan cada uno de los valores
            {
                int cont1 = 0;
                while((cont1 < palabrafuera.Length) && (palabrafuera[cont1] == palabra1[cont1])) // Mientras el contador sea menor a la palabra y mientras los valores iguales, se sumara el contador
                {
                    cont1 += 1;
                    if(cont1 == palabrafuera.Length) { igual = true; }  // Si al final de la evaluacion todos los elementos fueron iguales entonces se tomara como verdadero
                }
            }
            if (palabrafuera.Length == palabra2.Length)                                                 // Se realizara la misma accion con cada palabra hasta encontrar la que concuerde
            {
                int cont2 = 0;
                while ((cont2 < palabrafuera.Length) && (palabrafuera[cont2] == palabra2[cont2]))
                {
                    cont2 += 1;
                    if (cont2 == palabrafuera.Length) { igual = true; }
                }
            }
            if (palabrafuera.Length == palabra3.Length)
            {
                int cont3 = 0;
                while ((cont3 < palabrafuera.Length) && (palabrafuera[cont3] == palabra3[cont3]))
                {
                    cont3 += 1;
                    if (cont3 == palabrafuera.Length) { igual = true; }
                }
            }
            if (palabrafuera.Length == palabra4.Length)
            {
                int cont4 = 0;
                while ((cont4 < palabrafuera.Length) && (palabrafuera[cont4] == palabra4[cont4]))
                {
                    cont4 += 1;
                    if (cont4 == palabrafuera.Length) { igual = true; }
                }
            }
            if (palabrafuera.Length == palabra5.Length)
            {
                int cont5 = 0;
                while ((cont5 < palabrafuera.Length) && (palabrafuera[cont5] == palabra5[cont5]))
                {
                    cont5 += 1;
                    if (cont5 == palabrafuera.Length) { igual = true; }
                }
            }
            if (igual) { Console.WriteLine("Si se encuentra dentro de la lista"); }  // Si igual es verdadero entonces se desplegara el siguiente mensaje
            else { Console.WriteLine("No se encuentra dentro de la lista"); }        // De lo contrario se desplegara este
            Console.ReadKey(); 
        }
    }
}
