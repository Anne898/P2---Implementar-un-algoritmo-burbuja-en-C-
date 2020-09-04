using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P2___Implementar_un_algoritmo_burbuja_en_C_
{
    class Burbuja
    {

        private int[] numeros; //arreglo de numeros

        public void Inicio() // Pedir n numeros y llenar el arreglo
        {
            String num; //string que se convierte a int para llenar arreglo

            Console.Write("Cuantos numeros desea ordenar: ");

            int cantidadNumeros;
            cantidadNumeros = Convert.ToInt32(Console.ReadLine());

            numeros = new int[cantidadNumeros]; //Inicializamos el arreglo dependiendo de la cantidad de numeros

            for (int i = 0; i < cantidadNumeros; i++) //pedir numeros
            {
                Console.Write("Ingrese un numero: ");
                num = Console.ReadLine();
                numeros[i] = int.Parse(num); //llenar el arreglo 
            }
        }

       public void MetodoBurbuja() //metodo burbuja
        {
            int a;
            for (int j = 1; j < numeros.Length; j++) 

                for (int k = numeros.Length - 1; k >= j; k--)
                {
                    if (numeros[k - 1] > numeros[k])
                    {
                        a = numeros[k - 1];
                        numeros[k - 1] = numeros[k];
                        numeros[k] = a;
                    }
                }
        }

        public void Imprimir()  //imprimir metodo burbuja
        {
            Console.WriteLine("Metodo Burbuja:");
            for (int f = 0; f< numeros.Length; f++)
            {
                Console.Write(numeros[f]+"  ");
            }
        }

        static void Main(string[] args)
        {
            Burbuja metodoBurbuja = new Burbuja();
            metodoBurbuja.Inicio();
            metodoBurbuja.MetodoBurbuja();
            metodoBurbuja.Imprimir();
        }
    }
}
