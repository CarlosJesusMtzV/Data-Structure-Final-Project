using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class InsertionSort
    {
        public static async Task Sort(int[] array, Action<int[], int, int> displayCallback)
        {
            int n = array.Length;


            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Visualizar la comparación inicial
                displayCallback(array, i, j);
                await Task.Delay(500); // Pausa para observar

                // Mover los elementos del array que son mayores que la clave
                // a una posición adelante de su posición actual
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];

                    // Visualizar el movimiento
                    displayCallback(array, j, j + 1);
                    await Task.Delay(500); // Pausa para observar

                    j--;
                }
                array[j + 1] = key;

                // Visualizar la inserción del elemento
                displayCallback(array, j + 1, i);
                await Task.Delay(500); // Pausa para observar
            }

            displayCallback(array, -1, -1); // Visualización final
        }
    }
}
