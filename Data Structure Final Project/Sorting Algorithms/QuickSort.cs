using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class QuickSort
    {
        public static async Task Sort(int[] array, int low, int high, Action<int[], int, int> displayCallback)
        {
            if (low < high)
            {
                // Encuentra el pivote
                int pivotIndex = await Partition(array, low, high, displayCallback);

                // Visualizar la partición actual
                displayCallback(array, low, high);
                await Task.Delay(500); // Pausa para visualizar la partición

                // Ordenar recursivamente las sublistas
                await Sort(array, low, pivotIndex - 1, displayCallback);
                await Sort(array, pivotIndex + 1, high, displayCallback);
            }
        }

        private static async Task<int> Partition(int[] array, int low, int high, Action<int[], int, int> displayCallback)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                // Mostrar la comparación entre array[j] y el pivote
                displayCallback(array, j, high);
                await Task.Delay(500); // Pausa para visualizar la comparación

                if (array[j] <= pivot)
                {
                    i++;
                    // Intercambiar array[i] y array[j]
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    // Mostrar el intercambio
                    displayCallback(array, i, j);
                    await Task.Delay(500); // Pausa para visualizar el intercambio
                }
            }

            // Colocar el pivote en su lugar correcto
            int pivotIndex = i + 1;
            int tempPivot = array[pivotIndex];
            array[pivotIndex] = array[high];
            array[high] = tempPivot;

            // Mostrar la colocación del pivote
            displayCallback(array, pivotIndex, high);
            await Task.Delay(500); // Pausa para visualizar el intercambio del pivote

            return pivotIndex;
        }
    }
}
