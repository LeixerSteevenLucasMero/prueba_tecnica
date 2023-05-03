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
                        try
                        {
                        MostrarVector(vector);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: la opción debe ser un número entero.");
                        }
                        break;
                    case 2:
                        try
                        {
                        MostrarMatriz(matriz);

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: la opción debe ser un número entero.");

                        }
                        break;
                    case 3:

                        try
                        {
                        OrdenarVector(vector);
                        Console.WriteLine("Vector ordenado de forma descendente:");
                        MostrarVector(vector);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: la opción debe ser un número entero.");
                        }
                        break;
                    case 4:
                        try
                        {
                        Console.WriteLine("Suma total del vector: {0}", SumaTotalVector(vector));

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: la opción debe ser un número entero.");

                        }
                        break;
                    case 5:
                        try
                        {
                        Console.WriteLine("Suma total de la matriz: {0}", SumaTotalMatriz(matriz));
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: la opción debe ser un número entero.");
                        }
                        break;
                    case 6:

                        try
                        {
                        Console.WriteLine("Números primos del vector:");
                        ImprimirPrimos(vector);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: la opción debe ser un número entero.");

                        }
                        break;
                    case 7:
                        try
                        {
                        Console.WriteLine("Números impares de la matriz:");
                        ImprimirImpares(matriz);

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: la opción debe ser un número entero.");

                        }
                        break;
                    case 8:
                        try
                        {
                        OrdenarMatriz(matriz);
                        Console.WriteLine("Matriz ordenada de izquierda a derecha de forma ascendente:");
                        MostrarMatriz(matriz);

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: la opción debe ser un número entero.");

                        }
                        break;
                    case 9:
                        try
                        {
                        Console.WriteLine("Saliendo del programa...");

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: la opción debe ser un número entero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
                Console.WriteLine();

            } while (opcion != 9);
        }
        static void MostrarVector(int[] vector)
        {
            for (int i = 0; i < VECTOR_SIZE; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }

        static void MostrarMatriz(int[,] matriz)
        {
            for (int i = 0; i < MATRIX_SIZE; i++)
            {
                for (int j = 0; j < MATRIX_SIZE; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //paso3: Aplicar un algoritmo de ordenamiento en el vector y ordenarlo de forma descendente
        static void OrdenarVector(int[] vector)
        {
            for (int i = 0; i < VECTOR_SIZE - 1; i++)
            {
                for (int j = i + 1; j < VECTOR_SIZE; j++)
                {
                    if (vector[i] < vector[j])
                    {
                        int temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                    }
                }
            }
        }
        //paso4:Calcular la suma total del vector
        static int SumaTotalVector(int[] vector)
        {
            int suma = 0;
            for (int i = 0; i < VECTOR_SIZE; i++)
            {
                suma += vector[i];
            }
            return suma;
        }

        //paso5:Calcular la suma total de la matriz.
        static int SumaTotalMatriz(int[,] matriz)
        {
            int suma = 0;
            for (int i = 0; i < MATRIX_SIZE; i++)
            {
                for (int j = 0; j < MATRIX_SIZE; j++)
                {
                    suma += matriz[i, j];
                }
            }
            return suma;
        }


        static bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //paso6:Imprimir los números primos del vector y la posición

        static void ImprimirPrimos(int[] vector)
        {
            for (int i = 0; i < VECTOR_SIZE; i++)
            {
                if (EsPrimo(vector[i]))
                {
                    Console.WriteLine("Posición {0}: {1}", i, vector[i]);
                }
            }
        }

        //paso7:Imprimir los números impares de la matriz.
        static void ImprimirImpares(int[,] matriz)
        {
            for (int i = 0; i < MATRIX_SIZE; i++)
            {
                for (int j = 0; j < MATRIX_SIZE; j++)
                {
                    if (matriz[i, j] % 2 != 0)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        //paso8:Ordenar la matriz de izquierda a derecha de forma ascendente

        static void OrdenarMatriz(int[,] matriz)
        {
            for (int i = 0; i < MATRIX_SIZE; i++)
            {
                for (int j = 0; j < MATRIX_SIZE - 1; j++)
                {
                    for (int k = j + 1; k < MATRIX_SIZE; k++)
                    {
                        if (matriz[i, j] > matriz[i, k])
                        {
                            int temp = matriz[i, j];
                            matriz[i, j] = matriz[i, k];
                            matriz[i, k] = temp;
                        }
                    }
                }
            }
        }
    }
}
        
