using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class HeapSort
    {
        public static async Task Sort(int[] array, Action<int[], int, int> displayCallback)
        {

            int n = array.Length;

            // Construir el heap (reordenar el arreglo)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                await Heapify(array, n, i, displayCallback);
            }

            // Extraer elementos del heap uno por uno
            for (int i = n - 1; i > 0; i--)
            {
                // Mover la raíz actual al final
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                displayCallback(array, 0, i);
                await Task.Delay(500);

                // Aplicar Heapify al subárbol reducido
                await Heapify(array, i, 0, displayCallback);
            }

            displayCallback(array, -1, -1); // Visualización final
        }

        private static async Task Heapify(int[] array, int n, int i, Action<int[], int, int> displayCallback)
        {
            int largest = i; // Inicializar el nodo más grande como raíz
            int left = 2 * i + 1; // Hijo izquierdo
            int right = 2 * i + 2; // Hijo derecho

            // Comparar hijo izquierdo con la raíz
            if (left < n && array[left] > array[largest])
            {
                displayCallback(array, i, left);
                await Task.Delay(500);
                largest = left;
            }

            // Comparar hijo derecho con la raíz
            if (right < n && array[right] > array[largest])
            {
                displayCallback(array, i, right);
                await Task.Delay(500);
                largest = right;
            }

            // Si el nodo más grande no es la raíz
            if (largest != i)
            {
                // Realizar el intercambio
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                displayCallback(array, i, largest);
                await Task.Delay(500);

                // Aplicar Heapify recursivamente
                await Heapify(array, n, largest, displayCallback);
            }
        }
    }
}
