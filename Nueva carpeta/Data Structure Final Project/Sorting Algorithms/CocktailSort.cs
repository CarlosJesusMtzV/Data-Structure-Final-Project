using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class CocktailSort
    {
        public static async Task Sort(int[] array, Action<int[], int, int> displayCallback)
        {
            int n = array.Length;
            bool swapped;
            do
            {
                swapped = false;

                // Recorrido de izquierda a derecha
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        displayCallback(array, i, i + 1);  // Resaltamos los números que estamos intercambiando
                        await Task.Delay(500);  // Pausa para visualizar el intercambio

                        // Intercambio
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        swapped = true;
                    }
                }

                // Recorrido de derecha a izquierda
                for (int i = n - 2; i >= 0; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        displayCallback(array, i, i + 1);  // Resaltamos los números que estamos intercambiando
                        await Task.Delay(500);  // Pausa para visualizar el intercambio

                        // Intercambio
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        swapped = true;
                    }
                }

                n--;  // Reducir el tamaño de la zona no ordenada
            } while (swapped);

            displayCallback(array, -1, -1); // Visualización final
        }
    }
}
