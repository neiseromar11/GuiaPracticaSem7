using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPracticaSem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero del  1 a al 4 para ingresar : " +
                "\n 1: Ingrese ejercicio 1 " +
                "\n 2: Ingrese ejercicio 2 " +
                "\n 3: Ingrese ejercicio 3 " +
                "\n 4: Ingrese ejercicio 4 ");
              int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Ejercicio 1 ");
                    Ejercicio01();
                    break;
                case 2:
                    Console.WriteLine("Ejercicio 2 ");
                    Ejercicio02();
                    break;
                case 3:
                    Console.WriteLine("Ejercicio 3 ");
                    Ejercicio03();
                    break;
                case 4:
                    Console.WriteLine("Ejercicio 4 ");
                    Ejercicio04();
                    break;
                default:
                    break;
            }

            
        }
        static void Ejercicio01() {
            Console.Write("Ingrese el valor de n:");
            int n = int.Parse(Console.ReadLine());

            float resultado = 0f;
            float total=0f;
            for (int i = 1; i <= n; i++)
            {
                resultado = (16.0f - i) / (3.0f * i);
                total = total + resultado;
                Console.WriteLine( "resultado : \t\t"+ resultado);
            }
            Console.WriteLine("resultado total: \t"+ total);

            Console.ReadLine();

        }
        static void Ejercicio02() {


            Console.WriteLine("Números divisibles por 3 del 1 al 1000:");

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    int divisor = i / 3;
                    Console.WriteLine("divisor de Omar Orlandini "+divisor +" : "+i);
                }
            }

            Console.ReadKey();
        }
        
        static void Ejercicio03() {

            Console.WriteLine("Ingrese el año en que terminara :  ");
            int finAño=int.Parse(Console.ReadLine());
            int inicioAño = 1900;


            Console.WriteLine("Años bisiestos desde 1900 hasta "+ finAño+ " :");

            for (int i =inicioAño;i<=finAño;i++) {

                if ((i %4==0 && i % 100!=0)|| (i %400==0)) {

                    Console.WriteLine("Este es un año bisiesto: "+i+ "\n");
                }
            
            }




            Console.ReadKey();
        }
        static void Ejercicio04() {
            Console.Write("Ingrese numero de lineas: ");
            int lineas=int.Parse(Console.ReadLine());
            for (int i=0;i<lineas;i++)
            {
                Console.Write("Ingrese un numero: ");
                int numero=int.Parse(Console.ReadLine());
                for(int j=0;j<numero;j++){

                    for (int r=0;r<numero*2;r++) {
                        Console.Write("*");

                    }
                    Console.WriteLine();

                }
                

            }
            Console.ReadKey();

        }
       
    }
}
