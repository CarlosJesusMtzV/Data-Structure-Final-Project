using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Data_Structure_Final_Project.DoubleQueues;
using static Data_Structure_Final_Project.Lists;
using static Data_Structure_Final_Project.PriorityQueues;
using static Data_Structure_Final_Project.Queues;
using static Data_Structure_Final_Project.Stacks;

namespace Data_Structure_Final_Project
{
    public partial class QueuesForm : ZBase
    {
        private StaticQueue staticQueue;
        private DynamicQueue dynamicQueue;
        private CircularQueue circularQueue;
        private DoubleEndedStaticQueue doubleEndedStaticQueue;
        private DoubleEndedDynamicQueue doubleEndedDynamicQueue;
        private VectorOfVectors_PQ<int> vectorOfVectorsPQ;
        private VectorOfLists_PQ<int> vectorOfListsPQ;
        private ListOfLists_PQ<int> listOfListsPQ;
        private ListOfVectors_PQ<int> listOfVectorsPQ;
        public QueuesForm()
        {
            InitializeComponent();
            staticQueue = new StaticQueue(5);
            dynamicQueue = new DynamicQueue();
            circularQueue = new CircularQueue(5);
            doubleEndedStaticQueue = new DoubleEndedStaticQueue(5);
            doubleEndedDynamicQueue = new DoubleEndedDynamicQueue();
            vectorOfVectorsPQ = new VectorOfVectors_PQ<int>(3);
            vectorOfListsPQ = new VectorOfLists_PQ<int>(3);
            listOfListsPQ = new ListOfLists_PQ<int>(3);
            listOfVectorsPQ = new ListOfVectors_PQ<int>(3);
            cmbQueueType.SelectedIndex = 0;
            cmbDQType.SelectedIndex = 0;
            cmbTypeOfPQ.SelectedIndex = 0;
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQueueValue.Text, out int value))
            {
                string selectedList = cmbQueueType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Static":
                        staticQueue.Enqueue(value);
                        UpdateQueueDisplay(staticQueue, lstQueues);
                        break;
                    case "Dynamic":
                        dynamicQueue.Enqueue(value);
                        UpdateQueueDisplay(dynamicQueue, lstQueues);
                        break;
                    case "Circular":
                        circularQueue.Enqueue(value);
                        UpdateQueueDisplay(circularQueue, lstQueues);
                        break;
                    default:
                        MessageBox.Show("Please select a queue type.");
                        break;
                }

                txtQueueValue.Clear();
                txtQueueValue.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.");
            }
        }

        private void UpdateQueueDisplay(object queue, ListBox listBox)
        {
            listBox.Items.Clear();

            if (queue is StaticQueue staticQueue)
            {
                StaticQueue tempQueue = new StaticQueue(staticQueue.Capacity);

                while (!staticQueue.IsEmpty())
                {
                    int value = staticQueue.Dequeue();
                    listBox.Items.Add(value);
                    tempQueue.Enqueue(value);
                }

                // Restaurar los elementos a la cola estática
                while (!tempQueue.IsEmpty())
                {
                    staticQueue.Enqueue(tempQueue.Dequeue());
                }
            }
            else if (queue is DynamicQueue dynamicQueue)
            {
                DynamicQueue tempQueue = new DynamicQueue();

                while (!dynamicQueue.IsEmpty())
                {
                    int value = dynamicQueue.Dequeue();
                    listBox.Items.Add(value);
                    tempQueue.Enqueue(value);
                }

                // Restaurar los elementos a la cola dinámica
                while (!tempQueue.IsEmpty())
                {
                    dynamicQueue.Enqueue(tempQueue.Dequeue());
                }
            }
            else if (queue is CircularQueue circularQueue)
            {
                CircularQueue tempQueue = new CircularQueue(circularQueue.Capacity);

                while (!circularQueue.IsEmpty())
                {
                    int value = circularQueue.Dequeue();
                    listBox.Items.Add(value);
                    tempQueue.Enqueue(value);
                }

                // Restaurar los elementos a la cola circular
                while (!tempQueue.IsEmpty())
                {
                    circularQueue.Enqueue(tempQueue.Dequeue());
                }
            }
        }

        private void cmbQueueType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstQueues.Items.Clear();
            string selectedList = cmbQueueType.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Static":
                    UpdateQueueDisplay(staticQueue, lstQueues);
                    break;
                case "Dynamic":
                    UpdateQueueDisplay(dynamicQueue, lstQueues);
                    break;
                case "Circular":
                    UpdateQueueDisplay(circularQueue, lstQueues);
                    break;
                default:
                    MessageBox.Show("Please select a queue type.");
                    break;
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedList = cmbQueueType.SelectedItem.ToString();

                switch (selectedList)
                {
                    case "Static":
                        if (staticQueue.IsEmpty()) // Método personalizado para verificar si la cola está vacía
                        {
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value removed from the queue is: " + staticQueue.Dequeue());
                        UpdateQueueDisplay(staticQueue, lstQueues);
                        break;

                    case "Dynamic":
                        if (dynamicQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value removed from the queue is: " + dynamicQueue.Dequeue());
                        UpdateQueueDisplay(dynamicQueue, lstQueues);
                        break;

                    case "Circular":
                        if (circularQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value removed from the queue is: " + circularQueue.Dequeue());
                        UpdateQueueDisplay(circularQueue, lstQueues);
                        break;
                }

                txtQueueValue.Clear();
                txtQueueValue.Focus();
            }
            catch (Exception ex)
            {
                // Manejo general de errores inesperados
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQueuePeek_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedList = cmbQueueType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Static":
                        if (staticQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value at the front of the queue is: " + staticQueue.Peek());
                        break;
                    case "Dynamic":
                        if (dynamicQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value at the front of the queue is: " + dynamicQueue.Peek());
                        break;
                    case "Circular":
                        if (circularQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value at the front of the queue is: " + circularQueue.Peek());
                        break;
                }
            }
            catch (Exception ex)
            {
                // Manejo general de errores inesperados
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQueueSize_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedList = cmbQueueType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Static":
                        MessageBox.Show("The size of the queue is: " + staticQueue.Size());
                        break;
                    case "Dynamic":
                        MessageBox.Show("The size of the queue is: " + dynamicQueue.Size());
                        break;
                    case "Circular":
                        MessageBox.Show("The size of the queue is: " + circularQueue.Size());
                        break;
                }
            }
            catch (Exception ex)
            {
                // Manejo general de errores inesperados
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserFront_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDQValue.Text, out int value))
            {
                string selectedList = cmbDQType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Static":
                        doubleEndedStaticQueue.InsertFront(value); // Insertar al final de la cola estática

                        // Limpiar y actualizar el ListBox para la cola estática
                        lstDoubleQueues.Items.Clear();
                        foreach (var item in doubleEndedStaticQueue.GetQueueElements()) // Obtener elementos de la cola estática
                        {
                            lstDoubleQueues.Items.Add(item);  // Agregar cada elemento al ListBox de la cola estática
                        }
                        break;
                    case "Dynamic":
                        doubleEndedDynamicQueue.InsertFront(value); // Inserta el valor al frente de la cola dinámica

                        // Limpiar y actualizar el ListBox para la cola dinámica
                        lstDoubleQueues.Items.Clear();
                        foreach (var item in doubleEndedDynamicQueue.GetQueueElements())
                        {
                            lstDoubleQueues.Items.Add(item);  // Agregar cada elemento al ListBox de la cola dinámica
                        }
                        break;
                    default:
                        MessageBox.Show("Please select a double queue type.");
                        break;
                }

                txtDQValue.Clear();
                txtDQValue.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.");
            }
        }

        private void cmbDQType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDoubleQueues.Items.Clear();
            string selectedList = cmbDQType.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Static":
                    foreach (var item in doubleEndedStaticQueue.GetQueueElements())
                    {
                        lstDoubleQueues.Items.Add(item);
                    }
                    break;
                case "Dynamic":
                    foreach (var item in doubleEndedDynamicQueue.GetQueueElements())
                    {
                        lstDoubleQueues.Items.Add(item);
                    }
                    break;
            }
        }

        private void btnInsertRear_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDQValue.Text, out int value))
            {
                string selectedList = cmbDQType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Static":
                        doubleEndedStaticQueue.InsertRear(value); // Insertar al final de la cola estática
                        // Limpiar y actualizar el ListBox para la cola estática
                        lstDoubleQueues.Items.Clear();
                        foreach (var item in doubleEndedStaticQueue.GetQueueElements()) // Obtener elementos de la cola estática
                        {
                            lstDoubleQueues.Items.Add(item);  // Agregar cada elemento al ListBox de la cola estática
                        }
                        break;
                    case "Dynamic":
                        doubleEndedDynamicQueue.InsertRear(value); // Inserta el valor al frente de la cola dinámica
                        // Limpiar y actualizar el ListBox para la cola dinámica
                        lstDoubleQueues.Items.Clear();
                        foreach (var item in doubleEndedDynamicQueue.GetQueueElements())
                        {
                            lstDoubleQueues.Items.Add(item);  // Agregar cada elemento al ListBox de la cola dinámica
                        }
                        break;
                    default:
                        MessageBox.Show("Please select a double queue type.");
                        break;
                }
                txtDQValue.Clear();
                txtDQValue.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.");
            }
        }

        private void btnDeleteFront_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedList = cmbDQType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Static":
                        if (doubleEndedStaticQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value removed from the queue is: " + doubleEndedStaticQueue.DeleteFront());
                        lstDoubleQueues.Items.Clear();
                        foreach (var item in doubleEndedStaticQueue.GetQueueElements())
                        {
                            lstDoubleQueues.Items.Add(item);
                        }
                        break;
                    case "Dynamic":
                        if (doubleEndedDynamicQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value removed from the queue is: " + doubleEndedDynamicQueue.DeleteFront());
                        lstDoubleQueues.Items.Clear();
                        foreach (var item in doubleEndedDynamicQueue.GetQueueElements())
                        {
                            lstDoubleQueues.Items.Add(item);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                // Manejo general de errores inesperados
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRear_Click(object sender, EventArgs e)
        {
            string selectedList = cmbDQType.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Static":
                    if (doubleEndedStaticQueue.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value removed from the queue is: " + doubleEndedStaticQueue.DeleteRear());
                    lstDoubleQueues.Items.Clear();
                    foreach (var item in doubleEndedStaticQueue.GetQueueElements())
                    {
                        lstDoubleQueues.Items.Add(item);
                    }
                    break;
                case "Dynamic":
                    if (doubleEndedDynamicQueue.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value removed from the queue is: " + doubleEndedDynamicQueue.DeleteRear());
                    lstDoubleQueues.Items.Clear();
                    foreach (var item in doubleEndedDynamicQueue.GetQueueElements())
                    {
                        lstDoubleQueues.Items.Add(item);
                    }
                    break;
            }

        }

        private void btnGetFront_Click(object sender, EventArgs e)
        {
            string selectedList = cmbDQType.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Static":
                    if (doubleEndedStaticQueue.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the front of the queue is: " + doubleEndedStaticQueue.GetFront());
                    break;
                case "Dynamic":
                    if (doubleEndedDynamicQueue.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the front of the queue is: " + doubleEndedDynamicQueue.GetFront());
                    break;
            }
        }

        private void btnGetRear_Click(object sender, EventArgs e)
        {
            string selectedList = cmbDQType.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Static":
                    if (doubleEndedStaticQueue.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the rear of the queue is: " + doubleEndedStaticQueue.GetRear());
                    break;
                case "Dynamic":
                    if (doubleEndedDynamicQueue.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the rear of the queue is: " + doubleEndedDynamicQueue.GetRear());
                    break;
            }
        }

        private void btnDoubleQSize_Click(object sender, EventArgs e)
        {
            string selectedList = cmbDQType.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Static":
                    MessageBox.Show("The size of the queue is: " + doubleEndedStaticQueue.Size());
                    break;
                case "Dynamic":
                    MessageBox.Show("The size of the queue is: " + doubleEndedDynamicQueue.Size());
                    break;
            }
        }

        private void btnEnqueuePQ_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValuePQ.Text, out int value))
            {
                int priority = Convert.ToInt32(txtPriority.Text);
                string selectedList = cmbTypeOfPQ.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Vector Of Vectors":
                        vectorOfVectorsPQ.Enqueue(value, priority);
                        UpdateListBox(lstPQ, vectorOfVectorsPQ);
                        break;
                    case "Vector Of Lists":
                        vectorOfListsPQ.Enqueue(value, priority);
                        UpdateListBox(lstPQ, vectorOfListsPQ);
                        break;
                    case "List Of Vectors":
                        listOfVectorsPQ.Enqueue(value, priority);
                        UpdateListBox(lstPQ, listOfVectorsPQ);
                        break;
                    case "List Of Lists":
                        listOfListsPQ.Enqueue(value, priority);
                        UpdateListBox(lstPQ, listOfListsPQ);
                        break;
                    default:
                        MessageBox.Show("Please select a queue type.");
                        break;
                }

                txtQueueValue.Clear();
                txtQueueValue.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.");
            }
        }

        private void cmbTypeOfPQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPQ.Items.Clear();
            string selectedList = cmbTypeOfPQ.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Vector Of Vectors":
                    UpdateListBox(lstPQ, vectorOfVectorsPQ);
                    break;
                case "Vector Of Lists":
                    UpdateListBox(lstPQ, vectorOfListsPQ);
                    break;
                case "List Of Vectors":
                    UpdateListBox(lstPQ, listOfVectorsPQ);
                    break;
                case "List Of Lists":
                    UpdateListBox(lstPQ, listOfListsPQ);
                    break;
                default:
                    MessageBox.Show("Please select a queue type.");
                    break;
            }
        }

        private void btnDequeuePQ_Click(object sender, EventArgs e)
        {
            string selectedList = cmbTypeOfPQ.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Vector Of Vectors":
                    if (vectorOfVectorsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value removed from the queue is: " + vectorOfVectorsPQ.Dequeue());
                    UpdateListBox(lstPQ, vectorOfVectorsPQ);
                    break;
                case "Vector Of Lists":
                    if (vectorOfListsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value removed from the queue is: " + vectorOfListsPQ.Dequeue());
                    UpdateListBox(lstPQ, vectorOfListsPQ);
                    break;
                case "List Of Vectors":
                    if (listOfVectorsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value removed from the queue is: " + listOfVectorsPQ.Dequeue());
                    UpdateListBox(lstPQ, listOfVectorsPQ);
                    break;
                case "List Of Lists":
                    if (listOfListsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value removed from the queue is: " + listOfListsPQ.Dequeue());
                    UpdateListBox(lstPQ, listOfListsPQ);
                    break;
            }
        }

        private void btnPeekPQ_Click(object sender, EventArgs e)
        {
            string selectedList = cmbTypeOfPQ.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Vector Of Vectors":
                    if (vectorOfVectorsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the front of the queue is: " + vectorOfVectorsPQ.Peek());
                    break;
                case "Vector Of Lists":
                    if (vectorOfListsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the front of the queue is: " + vectorOfListsPQ.Peek());
                    break;
                case "List Of Vectors":
                    if (listOfVectorsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the front of the queue is: " + listOfVectorsPQ.Peek());
                    break;
                case "List Of Lists":
                    if (listOfListsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the front of the queue is: " + listOfListsPQ.Peek());
                    break;
            }
        }

        private void btnSizePQ_Click(object sender, EventArgs e)
        {
            string selectedList = cmbTypeOfPQ.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Vector Of Vectors":
                    MessageBox.Show("The size of the queue is: " + vectorOfVectorsPQ.Size());
                    break;
                case "Vector Of Lists":
                    MessageBox.Show("The size of the queue is: " + vectorOfListsPQ.Size());
                    break;
                case "List Of Vectors":
                    MessageBox.Show("The size of the queue is: " + listOfVectorsPQ.Size());
                    break;
                case "List Of Lists":
                    MessageBox.Show("The size of the queue is: " + listOfListsPQ.Size());
                    break;
            }
        }

        private void UpdateListBox<T>(ListBox listBox, T queue) where T : class
        {
            listBox.Items.Clear();
            var items = (queue as dynamic).ToList();
            listBox.Items.AddRange(items.ToArray());
        }
    }
}
