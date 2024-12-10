using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class CountingSort
    {
        public static async Task Sort(int[] array, Action<int[], string> displayCallback)
        {
            int n = array.Length;
            if (n <= 1) return;

            // Encontrar el valor mínimo y máximo en el arreglo
            int minValue = array.Min();
            int maxValue = array.Max();

            // Crear el arreglo de conteo
            int[] countArray = new int[maxValue - minValue + 1];

            // Contar las ocurrencias de cada número
            for (int i = 0; i < n; i++)
            {
                countArray[array[i] - minValue]++;
            }

            // Reconstruir el arreglo ordenado a partir del conteo
            int index = 0;
            for (int i = 0; i < countArray.Length; i++)
            {
                while (countArray[i] > 0)
                {
                    array[index++] = i + minValue;

                    // Mostrar el arreglo en su estado actual
                    displayCallback(array, "Ordenando: ");
                    await Task.Delay(500); // Añadir una pequeña demora para visualizar los pasos

                    countArray[i]--;
                }
            }

            // Mostrar el arreglo final ordenado
            displayCallback(array, "Arreglo ordenado: ");
        }
    }
}
