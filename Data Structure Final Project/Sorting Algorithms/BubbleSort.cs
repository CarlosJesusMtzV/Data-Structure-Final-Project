using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class BubbleSort
    {
        public static async Task Sort(int[] arr, Action<int[], int, int> displayCallback)
        {
            int n = arr.Length;
            int i, j, temp;
            bool swapped;

            // Recorre el arreglo para realizar las comparaciones e intercambios
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (j = 0; j < n - i - 1; j++)
                { // Incrementa el contador de comparaciones

                    // Mostrar los números que se están comparando
                    displayCallback(arr, j, j + 1);

                    // Esperar para mostrar la comparación
                    await Task.Delay(400);

                    if (arr[j] > arr[j + 1])
                    {
                        // Intercambiar los elementos
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;// Incrementa el contador de intercambios

                        // Mostrar los números después de intercambiarlos
                        displayCallback(arr, j, j + 1);
                        await Task.Delay(400);
                    }
                }

                // Si no se hicieron intercambios, el arreglo está ordenado
                if (!swapped)
                    break;
            }
        }
    }
}
