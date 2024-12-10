using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class DoubleQueues
    {
        internal class DoubleEndedStaticQueue
        {
            private int[] array;
            private int front;
            private int rear;
            private int size;
            private int capacity;

            public DoubleEndedStaticQueue(int capacity)
            {
                this.capacity = capacity;
                array = new int[capacity];
                front = -1;
                rear = -1;
                size = 0;
            }

            // Verifica si la cola está vacía
            public bool IsEmpty()
            {
                return size == 0;
            }

            // Verifica si la cola está llena
            public bool IsFull()
            {
                return size == capacity;
            }

            // Inserta un elemento en el frente de la cola
            public void InsertFront(int value)
            {
                if (size == array.Length)
                {
                    MessageBox.Show("The Double Queueu is full.");
                    return;
                }

                // Mover todos los elementos una posición hacia atrás
                for (int i = size - 1; i >= 0; i--)
                {
                    array[i + 1] = array[i];
                }

                // Insertar el valor al frente
                array[0] = value;
                if (front == -1) front = 0;
                rear = (rear + 1) % array.Length;
                size++;
            }

            // Inserta un elemento en el final de la cola
            public void InsertRear(int value)
            {
                if (IsFull())
                {
                    MessageBox.Show("The Double Queueu is full.");
                    return;
                }

                if (rear == -1) // Si la cola está vacía
                {
                    front = 0;
                    rear = 0;
                }
                else
                {
                    rear = (rear + 1) % capacity; // Mover el índice del final hacia adelante
                }

                array[rear] = value;
                size++;
            }

            // Elimina un elemento del frente de la cola
            public int DeleteFront()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Double Queueu is empty.");
                    return -1;
                }

                int value = array[front];
                if (front == rear) // Si hay un solo elemento
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front = (front + 1) % capacity; // Mover el índice del frente hacia adelante
                }

                size--;
                return value;
            }

            // Elimina un elemento del final de la cola
            public int DeleteRear()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Double Queueu is empty.");
                    return -1;
                }

                int value = array[rear];
                if (front == rear) // Si hay un solo elemento
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    rear = (rear - 1 + capacity) % capacity; // Mover el índice del final hacia atrás
                }

                size--;
                return value;
            }

            // Ver el valor en el frente sin eliminarlo
            public int GetFront()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Double Queueu is empty.");
                    return -1;
                }
                return array[front];
            }

            // Ver el valor en el final sin eliminarlo
            public int GetRear()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Double Queueu is empty.");
                    return -1;
                }
                return array[rear];
            }

            // Obtener el tamaño actual de la cola
            public int Size()
            {
                return size;
            }

            public List<int> GetQueueElements()
            {
                List<int> elements = new List<int>();

                if (front != -1)
                {
                    for (int i = front; i <= rear; i++)
                    {
                        elements.Add(array[i]);
                    }
                }

                return elements;
            }
        }


        internal class DoubleEndedDynamicQueue
        {
            private DoublyNode front;  // Frente de la cola
            private DoublyNode back;   // Final de la cola
            private int size;    // Tamaño de la cola

            public DoubleEndedDynamicQueue()
            {
                front = null;
                back = null;
                size = 0;
            }

            // Agregar un elemento al frente de la cola
            public void InsertFront(int value)
            {
                DoublyNode newNode = new DoublyNode(value);

                if (IsEmpty())
                {
                    front = back = newNode;  // Si la cola está vacía, el nuevo nodo es tanto el frente como el final
                }
                else
                {
                    newNode.Next = front;
                    front.Prev = newNode;
                    front = newNode;
                }

                size++;
            }

            // Agregar un elemento al final de la cola
            public void InsertRear(int value)
            {
                DoublyNode newNode = new DoublyNode(value);

                if (IsEmpty())
                {
                    front = back = newNode;  // Si la cola está vacía, el nuevo nodo es tanto el frente como el final
                }
                else
                {
                    newNode.Prev = back;
                    back.Next = newNode;
                    back = newNode;
                }

                size++;
            }

            // Eliminar un elemento del frente de la cola
            public int DeleteFront()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Queue is empty.");
                }

                int frontValue = front.Value;
                front = front.Next;

                if (front != null)
                {
                    front.Prev = null;
                }
                else
                {
                    back = null;  // Si la cola queda vacía, el final también debe ser nulo
                }

                size--;
                return frontValue;
            }

            // Eliminar un elemento del final de la cola
            public int DeleteRear()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Queue is empty.");
                }

                int backValue = back.Value;
                back = back.Prev;

                if (back != null)
                {
                    back.Next = null;
                }
                else
                {
                    front = null;  // Si la cola queda vacía, el frente también debe ser nulo
                }

                size--;
                return backValue;
            }

            // Ver el elemento del frente de la cola sin eliminarlo
            public int GetFront()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Queue is empty.");
                }

                return front.Value;
            }

            // Ver el elemento del final de la cola sin eliminarlo
            public int GetRear()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Queue is empty.");
                }

                return back.Value;
            }

            // Obtener el tamaño de la cola
            public int Size()
            {
                return size;
            }

            // Verificar si la cola está vacía
            public bool IsEmpty()
            {
                return size == 0;
            }

            public List<int> GetQueueElements()
            {
                List<int> elements = new List<int>();
                DoublyNode current = front;

                while (current != null)
                {
                    elements.Add(current.Value);
                    current = current.Next;
                }

                return elements;
            }
        }
    }
}
