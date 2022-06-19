using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digito_separado1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* digito_Separado();
             dosDigitos();
            tresDigitos();*/
            niños();
 
        }
        /*
        static void digito_Separado()
        {
            int variables = 0;

            int resultado1 = 0;

            int resultado2 = 0;

            Console.WriteLine("Escriba los numeros a separar"); 

            variables = int.Parse(Console.ReadLine());

            resultado1 = variables / 10;

            resultado2 = variables % 10;

            Console.WriteLine($"el resultado es: {resultado1} {resultado2}");
            Console.ReadKey();
        }


        static void dosDigitos()
        {
            int variables = 0;

            int resultado1 = 0;

            int resultado2 = 0;

            int suma = 0;

            Console.WriteLine("Escriba los numeros a separar");

            variables = int.Parse(Console.ReadLine());

            resultado1 = variables / 10;

            resultado2 = variables % 10;

            Console.WriteLine($"el resultado es: {resultado1} {resultado2}");

            suma = resultado1 + resultado2;

            Console.WriteLine($"La suma de los digitos separado es {suma}");
            Console.ReadKey ();

        }
        static void tresDigitos()
        {
            int variables = 0;

            int resultado1 = 0;

            int resultado2 = 0;

            int resultado3 = 0;

            int resultado4 = 0;

            int suma = 0;

            Console.WriteLine("Escriba los numeros a separar");

            variables = int.Parse(Console.ReadLine());

            resultado1 = variables % 10;

            resultado2 =  variables / 10;

            resultado3 = resultado2 / 10;
            
            resultado4 = resultado2 % 10;

            Console.WriteLine($"el resultado es: {resultado3} {resultado4} {resultado1}");

            suma = resultado3 + resultado4 + resultado1;

            Console.WriteLine($"La suma de los digitos separado es {suma}");
            Console.ReadKey(); 

        }

        static void tresDigitos()
        {
            int variables = 0;

            int resultado1 = 0;

            int resultado2 = 0;

            int resultado3 = 0;

            int resultado4 = 0;

            int resultado5 = 0;

            int resultado6 = 0;

            int resultado7 = 0;

            int suma = 0;

            Console.WriteLine("Escriba los numeros a separar");

            variables = int.Parse(Console.ReadLine());

            resultado1 = variables % 10;

            resultado2 = variables / 10;

            resultado3 = resultado2 % 10;

            resultado4 = resultado2 / 10;

            resultado5 = resultado4 % 10;

            resultado6 = resultado4 / 10;

            resultado7 = resultado6 % 10;

            Console.WriteLine($"el resultado es: {resultado7} {resultado5} {resultado3} {resultado1}");

            suma = resultado7 + resultado5 + resultado3 + resultado1;

            Console.WriteLine($"La suma de los digitos separado es {suma}");
            Console.ReadKey();

        }*/

        static void niños()
        {
            int niño1 = 0;
            int niño2 = 0;
            int niño3 = 0;
            int suma = 0;
            int promedio = 0;

            Console.WriteLine("Introduzca la edad del primer niño");

            niño1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la edad del segundo niño");

            niño2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la edad del tercer niño");

            niño3 = int.Parse(Console.ReadLine());

            suma = niño1 + niño2 + niño3;
            promedio = niño1 + niño2 + niño3 / 3;

            Console.WriteLine($"la suma de las edades es {suma}");
            Console.ReadKey();
            Console.WriteLine("===================================");
            Console.WriteLine($"el promedio de las edades es {promedio}");
            Console.ReadKey();

            if (niño1 > niño2 & niño1 > niño3) {
                    Console.WriteLine($"{niño1} es la mayor edad de todas");
                    Console.ReadKey();

            } if  (niño2 > niño1 & niño2 > niño3) { 
            
              Console.WriteLine($"{niño2} es la mayor edad de todas");
              Console.ReadKey();

            } if (niño3 > niño1 & niño3 > niño2 ) {

              Console.WriteLine($"{niño3} es la mayor edad de todas");
                Console.ReadKey();
            }

            if (niño1 < niño2 & niño1 < niño3)
            {
                Console.WriteLine($"{niño1} es la menor edad de todas");
                Console.ReadKey();
            }
            if (niño2 < niño1 & niño2 < niño3)
            {

                Console.WriteLine($"{niño2} es la menor edad de todas");
                Console.ReadKey();
            }
            if (niño3 < niño1 & niño3 < niño2)
            {
                Console.WriteLine($"{niño3} es la menor edad de todas");
                Console.ReadKey();
            }
        }
    }


}
