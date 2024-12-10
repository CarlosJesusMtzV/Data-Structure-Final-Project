using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structure_Final_Project
{
    internal class BucketSort
    {
        public static async Task Sort(int[] array, Action<int[], string> displayCallback)
        {
            int n = array.Length;
            if (n <= 1) return;

            int minValue = array.Min();
            int maxValue = array.Max();
            int bucketCount = n;

            // Crear los "buckets" vacíos
            List<int[]> buckets = new List<int[]>(bucketCount);
            for (int i = 0; i < bucketCount; i++)
            {
                buckets.Add(new int[0]);
            }

            // Distribuir los elementos en los "buckets"
            displayCallback(array, "Distribuyendo los elementos en los buckets...");
            for (int i = 0; i < n; i++)
            {
                int bucketIndex = (array[i] - minValue) * (bucketCount - 1) / (maxValue - minValue);
                buckets[bucketIndex] = buckets[bucketIndex].Concat(new int[] { array[i] }).ToArray();
            }

            // Mostrar los buckets con su rango, incluyendo los vacíos
            for (int i = 0; i < bucketCount; i++)
            {
                if (buckets[i].Length > 0)
                {
                    int bucketMin = buckets[i].Min();
                    int bucketMax = buckets[i].Max();
                    displayCallback(buckets[i], $"Bucket {i + 1}: Rango: [{bucketMin}, {bucketMax}] - Elementos: {string.Join(", ", buckets[i])}");
                }
                else
                {
                    displayCallback(new int[0], $"Bucket {i + 1}: Vacío");
                }
            }

            // Ordenar los "buckets" individualmente usando InsertionSort
            for (int i = 0; i < bucketCount; i++)
            {
                await InsertionSort(buckets[i], displayCallback);
            }

            // Concatenar los resultados
            int index = 0;
            foreach (var bucket in buckets)
            {
                foreach (var item in bucket)
                {
                    array[index++] = item;
                }
            }

            // Mostrar el arreglo final
            displayCallback(array, "Arreglo final ordenado: " + string.Join(", ", array));
        }

        // Método InsertionSort para ordenar cada bucket
        private static async Task InsertionSort(int[] array, Action<int[], string> displayCallback)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;

                // Mostrar el arreglo después de cada paso de InsertionSort
                displayCallback(array, "Paso de InsertionSort: " + string.Join(", ", array));
                await Task.Delay(500); // Añadir una pequeña demora para visualizar los pasos
            }
        }
    }
}
