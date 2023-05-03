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

    }
}
