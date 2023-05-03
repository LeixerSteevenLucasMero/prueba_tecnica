using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        const int VECTOR_SIZE = 50;
        const int MATRIX_SIZE = 5;

        static void Main(string[] args)
        {
            //paso1: Generar un menú
            int opcion;
            do
            {
                Console.WriteLine("1. Mostrar vector");
                Console.WriteLine("2. Mostrar matriz");
                Console.WriteLine("3. Ordenar vector");
                Console.WriteLine("4. Suma total vector");
                Console.WriteLine("5. Suma total matriz");
                Console.WriteLine("6. Imprimir números primos del vector");
                Console.WriteLine("7. Imprimir números impares de la matriz");
                Console.WriteLine("8. Ordenar matriz");
                Console.WriteLine("9. Salir");
                Console.Write("Ingrese una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //paso2: Generar un vector de 50 posiciones y una matriz de 5x5

                int[] vector = new int[VECTOR_SIZE];
                int[,] matriz = new int[MATRIX_SIZE, MATRIX_SIZE];
                Random random = new Random();

                for (int i = 0; i < VECTOR_SIZE; i++)
                {
                    vector[i] = random.Next(1, 501);
                }

                for (int i = 0; i < MATRIX_SIZE; i++)
                {
                    for (int j = 0; j < MATRIX_SIZE; j++)
                    {
                        matriz[i, j] = random.Next(1, 501);
                    }
                }

                switch (opcion)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:


                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    case 9:

                        break;
                    default:
                        break;
                }
                Console.WriteLine();

            } while (opcion != 9);
    }
}
