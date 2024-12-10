using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class ShellSort
    {
        public static async Task Sort(int[] array, Action<int[], int, int> displayCallback)
        {
            int n = array.Length;

            // Empezar con un intervalo grande y reducirlo en cada iteración
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Ordenar los subarreglos con el intervalo actual
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;

                    // Mostrar el elemento actual y el elemento con el que se compara
                    displayCallback(array, i, i - gap);
                    await Task.Delay(500); // Pausa para visualizar la comparación

                    // Desplazar los elementos del subarreglo hacia la derecha
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap];

                        // Mostrar el movimiento de los elementos
                        displayCallback(array, j, j - gap);
                        await Task.Delay(500); // Pausa para visualizar el movimiento
                    }

                    // Insertar el elemento en su posición correcta
                    array[j] = temp;

                    // Visualizar la inserción del elemento
                    displayCallback(array, j, i);
                    await Task.Delay(500); // Pausa para visualizar la inserción
                }
            }

            displayCallback(array, -1, -1); // Visualización final
        }
    }
}
