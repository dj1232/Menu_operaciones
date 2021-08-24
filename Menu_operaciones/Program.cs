using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_operaciones
{
    class Program
    {
        //funcion del menu
        static void menu()
        {
            Int16 op,centinela = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("     Menu de opciones     ");
                Console.WriteLine(" 1-----Dividir            ");
                Console.WriteLine(" 2-----Obtener Cubo       ");
                Console.WriteLine(" 3-----Obtener IMC        ");
                Console.WriteLine(" 4-----Salir              ");
                Console.WriteLine(" \n Seleccione una opcion");

                //obtencion y validacion de opcion
                op = Convert.ToInt16(Console.ReadLine());
                while (op < 1 || op > 4)
                {
                    Console.WriteLine(" Seleccione una opcion valida");
                    op = Convert.ToInt16(Console.ReadLine());
                }

                //comienzo del switch
                switch (op)
                {
                    case 1:
                        division();
                        break;
                    case 2:
                        cubo();
                        break;
                    case 3:
                        imc();
                        break;
                    case 4:
                        salir();
                        centinela = 1;
                        break;
                }//fin switch
            } while (centinela != 1);

        }//fin funcion menu

        static void division()
        {
            Double dividendo, divisor , resultado;

            Console.Clear();
            Console.WriteLine("Ingrese el dividendo: ");
            dividendo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el divisor: ");
            divisor = Double.Parse(Console.ReadLine());
            while(divisor == 0)
            {
                Console.WriteLine("Ingrese un valor distinto de 0: ");
                divisor = Convert.ToDouble(Console.ReadLine());
            }

            resultado = dividendo / divisor;

            Console.WriteLine("El resultado de la division de {0} entre {1} es: {2}", dividendo, divisor, resultado);

            Console.ReadKey();
        }//fin funcion division

        static void cubo()
        {
            Double num, resultado;

            Console.Clear();
            Console.WriteLine("Ingrese el numero que desea elevar al cubo: ");
            num = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Pow(num, 3);

            Console.WriteLine("El resultado de elevar {0} al cubo es: {1}", num, resultado);

            Console.ReadKey();
        }//fin funcion cubo

        static void imc()
        {
            Console.Clear();
            Double peso, altura, resultado;

            Console.Clear();
            Console.WriteLine("Ingrese su peso en Kg: ");
            peso = Convert.ToDouble(Console.ReadLine());
            while (peso <= 0)
            {
                Console.WriteLine("Ingrese un valor positivo: ");
                peso = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Ingrese su altura en metros: ");
            altura = Convert.ToDouble(Console.ReadLine());
            while (altura <= 0)
            {
                Console.WriteLine("Ingrese un valor positivo: ");
                altura = Convert.ToDouble(Console.ReadLine());
            }

            resultado = peso / (altura * altura);

            Console.WriteLine("Su Indice de Masa Corporal es de: " + resultado);
            Console.ReadKey();
        }//fin funcion imc

        static void salir()
        {
            Console.Clear();
            Console.WriteLine("Pase un buen dia. \n ....Saliendo....");
            Console.ReadKey();
        }//fin funcion salir

        static void Main(string[] args)
        {
            menu();
        }
    }
}
