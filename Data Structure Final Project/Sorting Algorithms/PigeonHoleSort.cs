using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class PigeonHoleSort
    {
        public static async Task Sort(int[] array, Action<int[], string> casillasDisplayCallback, Action<int[], string> sortedDisplayCallback)
        {
            // Paso 1: Encontrar el valor mínimo y máximo
            int min = array.Min();
            int max = array.Max();
            int range = max - min + 1;

            // Crear un arreglo de casillas
            int[] holes = new int[range];

            // Paso 2: Asignar los elementos a las casillas
            foreach (int num in array)
            {
                holes[num - min]++;  // Incrementa el contador para la casilla correspondiente

                // Mostrar cómo se va acomodando el número en su casilla
                casillasDisplayCallback(holes, $"Asignando {num} a la casilla {num - min}");
                await Task.Delay(500); // Pausa para mostrar el proceso
            }

            // Mostrar la distribución final de las casillas
            casillasDisplayCallback(holes, "Distribución final de las casillas: " + string.Join(", ", holes));

            // Paso 3: Recoger los elementos de las casillas en orden
            int index = 0;
            for (int i = 0; i < range; i++)
            {
                while (holes[i]-- > 0)
                {
                    array[index++] = i + min;

                    // Mostrar cómo se recogen los elementos y se van acomodando
                    sortedDisplayCallback(array, $"Recogiendo {i + min} de la casilla {i}...");
                    await Task.Delay(500); // Pausa para mostrar el proceso
                }
            }

            sortedDisplayCallback(array, "Ordenamiento completado");
        }
    }
}
