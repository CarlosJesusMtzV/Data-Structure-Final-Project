using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class CombSort
    {
        public static async Task Sort(int[] array, Action<int[], int, int> displayCallback)
        {
            int gap = array.Length;
            const double shrinkFactor = 1.3;
            bool swapped = true;

            while (gap > 1 || swapped)
            {
                // Reduce el gap según el factor de reducción
                gap = (int)(gap / shrinkFactor);
                if (gap < 1)
                {
                    gap = 1;
                }

                swapped = false;

                // Compara los elementos con el gap actual
                for (int i = 0; i < array.Length - gap; i++)
                {
                    // Mostrar comparación entre los elementos con el gap
                    displayCallback(array, i, i + gap);
                    await Task.Delay(500); // Pausa para visualizar la comparación

                    if (array[i] > array[i + gap])
                    {
                        // Intercambiar los elementos si están fuera de orden
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;

                        // Mostrar el intercambio
                        displayCallback(array, i, i + gap);
                        await Task.Delay(500); // Pausa para visualizar el intercambio

                        swapped = true;
                    }
                }
            }

            // Visualización final después de ordenar
            displayCallback(array, -1, -1); // Indica que el proceso ha terminado
        }
    }
}
