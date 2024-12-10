using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class Queues
    {
        public class StaticQueue
        {
            private int[] elements; // Arreglo para almacenar elementos de la cola
            private int front;      // Índice del primer elemento de la cola
            private int rear;       // Índice del último elemento de la cola
            private int count;      // Número de elementos en la cola

            public int Capacity { get; } // Capacidad máxima de la cola

            public StaticQueue(int capacity)
            {
                Capacity = capacity;
                elements = new int[capacity];
                front = 0;
                rear = -1;
                count = 0;
            }

            // Método para agregar un número a la cola
            public void Enqueue(int number)
            {
                if (count == Capacity)
                {
                    MessageBox.Show("The Queueu is full.");
                    return;
                }

                rear = (rear + 1) % Capacity;
                elements[rear] = number;
                count++;
            }

            // Método para eliminar y devolver el número al frente de la cola
            public int Dequeue()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Queueu is empty.");
                }

                int number = elements[front];
                front = (front + 1) % Capacity;
                count--;
                return number;
            }

            // Método para ver el número al frente de la cola sin eliminarlo
            public int Peek()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Queueu is empty.");
                }

                return elements[front];
            }

            // Método para verificar si la cola está vacía
            public bool IsEmpty()
            {
                return count == 0;
            }

            // Método para verificar si la cola está llena
            public bool IsFull()
            {
                return count == Capacity;
            }

            //method to get size of the queue
            public int Size()
            {
                return count;
            }
        }


        public class DynamicQueue
        {
            private Node front; // Nodo al frente de la cola
            private Node rear;  // Nodo al final de la cola
            private int count;  // Número de elementos en la cola

            public int Count => count;

            public DynamicQueue()
            {
                front = null;
                rear = null;
                count = 0;
            }

            // Método para agregar un número a la cola
            public void Enqueue(int number)
            {
                Node newNode = new Node(number);

                if (IsEmpty())
                {
                    front = rear = newNode;
                }
                else
                {
                    rear.Next = newNode;
                    rear = newNode;
                }

                count++;
            }

            // Método para eliminar y devolver el número al frente de la cola
            public int Dequeue()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Queueu is empty.");
                }

                int data = front.Value;
                front = front.Next;

                if (front == null)
                {
                    rear = null; // La cola queda vacía
                }

                count--;
                return data;
            }

            // Método para ver el número al frente de la cola sin eliminarlo
            public int Peek()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Queueu is empty.");
                }

                return front.Value;
            }

            // Método para verificar si la cola está vacía
            public bool IsEmpty()
            {
                return front == null;
            }

            //method to get size of the queue
            public int Size()
            {
                return count;
            }
        }


        internal class CircularQueue
        {
            private int[] array;
            private int front;
            private int rear;
            private int count;
            public int Capacity { get; }

            // Constructor para inicializar la cola circular con un tamaño determinado
            public CircularQueue(int capacity)
            {
                Capacity = capacity;
                array = new int[capacity];
                front = 0;
                rear = -1;
                count = 0;
            }

            // Método para agregar un elemento al final de la cola
            public void Enqueue(int value)
            {
                if (count == Capacity)
                {
                    MessageBox.Show("The Queueu is full.");
                    return;
                }

                rear = (rear + 1) % Capacity;  // Mover el índice rear de forma circular
                array[rear] = value;
                count++;
            }

            // Método para eliminar un elemento del frente de la cola
            public int Dequeue()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Queueu is empty.");
                }

                int dequeuedValue = array[front];
                front = (front + 1) % Capacity;  // Mover el índice front de forma circular
                count--;
                return dequeuedValue;
            }

            // Método para ver el valor del frente de la cola sin eliminarlo
            public int Peek()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Queueu is empty.");
                }

                return array[front];
            }

            // Método para obtener el número de elementos en la cola
            public int Size()
            {
                return count;
            }

            // Método para verificar si la cola está vacía
            public bool IsEmpty()
            {
                return count == 0;
            }

            // Método para verificar si la cola está llena
            public bool IsFull()
            {
                return count == Capacity;
            }
        }
    }
}
