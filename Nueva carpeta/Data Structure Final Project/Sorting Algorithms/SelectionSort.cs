using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class SelectionSort
    {
        public static async Task Sort(int[] array, Action<int[], int, int> displayCallback)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                // Visualizar el inicio de una nueva iteración con el índice mínimo actual
                displayCallback(array, i, minIndex);
                await Task.Delay(500); // Pausa para visualizar

                for (int j = i + 1; j < n; j++)
                {
                    // Mostrar comparación entre el elemento actual y el mínimo
                    displayCallback(array, j, minIndex);
                    await Task.Delay(500); // Pausa para visualizar la comparación

                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;

                        // Visualizar el nuevo índice mínimo
                        displayCallback(array, j, minIndex);
                        await Task.Delay(500); // Pausa para visualizar el cambio del índice mínimo
                    }
                }

                // Intercambiar el elemento mínimo con el elemento actual
                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;

                    // Visualizar el intercambio
                    displayCallback(array, i, minIndex);
                    await Task.Delay(500); // Pausa para observar el intercambio
                }
            }

            displayCallback(array, -1, -1); // Visualización final
        }
    }
}
