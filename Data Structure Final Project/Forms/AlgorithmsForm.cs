using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structure_Final_Project
{
    public partial class AlgorithmsForm : ZBase
    {
        private int[] numbers;
        public AlgorithmsForm()
        {
            InitializeComponent();
            numbers = new int[] { };
            cmbAlgoritms.Items.AddRange(new string[] { "Gnome Sort", "Heap Sort", "Pigeonhole Sort", "Bubble Sort", "Cocktail Sort", "Insertion Sort", "Shell Sort", "Selection Sort", "Quick Sort", "Merge Sort", "Direct Merge", "Natural Merge", "Comb Sort", "Counting Sort", "Bucket Sort" });
            cmbAlgoritms.SelectedIndex = 0;
        }

        private void btnSetNumbers_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            numbers = Enumerable.Range(0, 10).Select(_ => random.Next(1, 100)).ToArray();
            DisplayNumbers(numbers);
        }

        private async void btnSort_Click(object sender, EventArgs e)
        {
            if (numbers == null || numbers.Length == 0)
            {
                MessageBox.Show("Por favor, genera los números primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedMethod = cmbAlgoritms.SelectedItem.ToString();

            switch (selectedMethod)
            {
                case "Bubble Sort":
                    await BubbleSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Gnome Sort":
                    await GnomeSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Comb Sort":
                    await CombSort.Sort(numbers, DisplayNumbers);
                    break;
                //case "Pigeonhole Sort":
                //    await PigeonHoleSort.Sort(numbers, UpdateCasillasListBox, UpdateSortedListBox);
                //    break;
                case "Cocktail Sort":
                    await CocktailSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Heap Sort":
                    await HeapSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Insertion Sort":
                    await InsertionSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Shell Sort":
                    await ShellSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Selection Sort":
                    await SelectionSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Counting Sort":
                    await CountingSort.Sort(numbers, DisplayNumbersMerge);
                    break;
                case "Bucket Sort":
                    await BucketSort.Sort(numbers, DisplayNumbersMerge);
                    break;
                case "Merge Sort":
                    await MergeAlgorithms.MergeSort(numbers, 0, numbers.Length - 1, DisplayNumbersMerge);
                    break;
                case "Natural Merge":
                    await MergeAlgorithms.NaturalMerge(numbers, DisplayNumbersMerge);
                    break;
                case "Direct Merge":
                    await MergeAlgorithms.DirectMerge(numbers, DisplayNumbersMerge);
                    break;
                case "Quick Sort":
                    //CHECAR BIEN ESTA MADRE
                    await QuickSort.Sort(numbers, 0, numbers.Length - 1, DisplayNumbers);
                    break;
                default:
                    MessageBox.Show("Método de ordenamiento no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }



            MessageBox.Show("¡Ordenamiento completado!", selectedMethod, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayNumbers(int[] array, int currentIndex = -1, int compareIndex = -1)
        {
            lstNumbersSort.Items.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                string itemText = array[i].ToString();
                if (i == currentIndex || i == compareIndex)
                {
                    itemText = $"[{itemText}]";
                }
                lstNumbersSort.Items.Add(itemText);
            }

        }
        private void DisplayNumbersMerge(int[] array, string message)
        {
            //lstNumbersSort.Items.Clear();
            lstNumbersSort.Items.Add(message);
            lstNumbersSort.Items.Add($"[{string.Join(", ", array)}]");
            lstNumbersSort.Items.Add(""); // Línea en blanco para separar pasos
        }
    }
}
