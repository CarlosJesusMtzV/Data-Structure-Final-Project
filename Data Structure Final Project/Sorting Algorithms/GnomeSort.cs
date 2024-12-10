using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal static class GnomeSort
    {
        public static async Task Sort(int[] array, Action<int[], int, int> displayCallback)
        {
            int n = array.Length;
            int index = 0;


            while (index < n)
            {
                // Mostrar los números que estamos comparando
                displayCallback(array, index, index - 1);
                await Task.Delay(500); // Pausa para visualizar la comparación

                if (index == 0 || array[index] >= array[index - 1])
                {
                    index++;
                }
                else
                {
                    // Realizar el intercambio
                    int temp = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = temp;

                    // Mostrar los números después del intercambio
                    displayCallback(array, index, index - 1);
                    await Task.Delay(500); // Pausa para visualizar el intercambio

                    index--; // Retroceder índice
                }
            }

            displayCallback(array, -1, -1); // Visualización final
        }

    }
}
