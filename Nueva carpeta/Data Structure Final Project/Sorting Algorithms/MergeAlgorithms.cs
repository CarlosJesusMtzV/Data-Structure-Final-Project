using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class MergeAlgorithms
    {
        public static async Task MergeSort(int[] array, int left, int right, Action<int[], string> displayCallback)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                // Mostrar división
                displayCallback(array[left..(right + 1)], $"División: {left} - {right}");

                // Dividir de manera recursiva
                await MergeSort(array, left, middle, displayCallback);
                await MergeSort(array, middle + 1, right, displayCallback);

                // Combinar los subarreglos
                await Merge(array, left, middle, right, displayCallback);
            }
        }

        private static async Task Merge(int[] array, int left, int middle, int right, Action<int[], string> displayCallback)
        {
            // Crear copias de las mitades
            int[] leftArray = array[left..(middle + 1)];
            int[] rightArray = array[(middle + 1)..(right + 1)];

            int i = 0, j = 0, k = left;

            // Combinar elementos en orden
            while (i < leftArray.Length && j < rightArray.Length)
            {
                array[k++] = (leftArray[i] <= rightArray[j]) ? leftArray[i++] : rightArray[j++];
                await Task.Delay(50); // Pausa para simular paso visual
                displayCallback(array, "Actualizando mezcla...");
            }

            // Copiar elementos restantes
            while (i < leftArray.Length)
            {
                array[k++] = leftArray[i++];
                await Task.Delay(50);
                displayCallback(array, "Agregando elementos restantes de la izquierda...");
            }

            while (j < rightArray.Length)
            {
                array[k++] = rightArray[j++];
                await Task.Delay(50);
                displayCallback(array, "Agregando elementos restantes de la derecha...");
            }

            displayCallback(array[left..(right + 1)], $"Merge completado: {left} - {right}");
        }


        public static async Task DirectMerge(int[] array, Action<int[], string> displayCallback)
        {
            int n = array.Length; // Obtener el tamaño del arreglo
            int[] temp = new int[n]; // Crear un arreglo temporal del mismo tamaño

            for (int width = 1; width < n; width *= 2)
            {
                displayCallback(array.ToArray(), "División con width = " + width);

                // Iterar sobre los subarreglos de tamaño 2*width
                for (int i = 0; i < n; i += 2 * width)
                {
                    int left = i; // Índice inicial del subarreglo izquierdo
                    int middle = Math.Min(i + width, n); // Índice del último elemento del subarreglo izquierdo
                    int right = Math.Min(i + 2 * width, n); // Índice del último elemento del subarreglo derecho

                    int l = left, r = middle, k = left;

                    // Fusionar los subarreglos izquierdo y derecho en el arreglo temporal
                    while (l < middle && r < right)
                        temp[k++] = array[l] <= array[r] ? array[l++] : array[r++];

                    while (l < middle)
                        temp[k++] = array[l++];

                    while (r < right)
                        temp[k++] = array[r++];

                    // Copiar el arreglo temporal de vuelta al arreglo original
                    Array.Copy(temp, left, array, left, right - left);
                }

                displayCallback(array.ToArray(), "Mezcla después de width = " + width);
                await Task.Delay(200); // Pausa para simular paso visual
            }
        }

        // Natural Merge Sort
        public static async Task NaturalMerge(int[] array, Action<int[], string> displayCallback)
        {
            bool ordenado = false;
            int[] temp = new int[array.Length];

            while (!ordenado)
            {
                ordenado = true;
                int i = 0;
                displayCallback(array, "División en sub-secuencias");

                while (i < array.Length)
                {
                    int start = i;

                    // Encuentra el final de la primera secuencia ordenada
                    while (i < array.Length - 1 && array[i] <= array[i + 1])
                        i++;
                    i++;

                    int j = i;

                    // Encuentra el final de la segunda secuencia ordenada
                    while (i < array.Length - 1 && array[i] <= array[i + 1])
                        i++;
                    i++;

                    if (j < array.Length)
                    {
                        MergeNatural(array, start, j, Math.Min(i, array.Length), temp);
                        ordenado = false;
                    }
                }

                Array.Copy(temp, 0, array, 0, array.Length);

                displayCallback(array, "Mezcla completa");
                await Task.Delay(200); // Pausa para simular paso visual
            }
        }

        // Merge Natural Helper
        private static void MergeNatural(int[] array, int left, int middle, int right, int[] temp)
        {
            int i = left, j = middle, k = left;
            while (i < middle && j < right)
                temp[k++] = array[i] <= array[j] ? array[i++] : array[j++];

            while (i < middle) temp[k++] = array[i++];
            while (j < right) temp[k++] = array[j++];
        }
    }
}
