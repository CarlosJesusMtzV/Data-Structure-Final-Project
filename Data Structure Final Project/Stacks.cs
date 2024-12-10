using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class Stacks
    {
        public class StaticStack
        {
            private int[] elements; // Arreglo para almacenar los elementos
            private int top;        // Índice del elemento en el tope de la pila

            // Constructor que inicializa la pila con un tamaño fijo
            public StaticStack()
            {
                elements = new int[8];
                top = -1;           // Inicialmente, la pila está vacía
            }

            // Método para insertar un elemento en la pila
            public void Push(int dato)
            {
                if (IsFull())
                {
                    MessageBox.Show("La pila estatica está llena.");
                    return;
                }
                elements[++top] = dato; // Incrementar 'top' y agregar el dato
            }

            // Método para eliminar y devolver el elemento en el tope de la pila
            public string Pop()
            {
                if (IsEmpty())
                {
                    return "La pila está vacía.";
                }
                return elements[top--].ToString(); // Devolver y decrementar 'top'
            }

            // Método para devolver el elemento en el tope de la pila sin eliminarlo
            public string Peek()
            {
                if (IsEmpty())
                {
                    return "La pila está vacía.";
                }
                return elements[top].ToString(); // Devolver el valor sin modificar 'top'
            }

            // Método para verificar si la pila está vacía
            public bool IsEmpty()
            {
                return top == -1; // La pila está vacía si 'top' es -1
            }

            // Método para verificar si la pila está llena
            public bool IsFull()
            {
                return top == elements.Length - 1; // La pila está llena si 'top' alcanza el tamaño máximo
            }

            // Método para devolver el tamaño de la pila
            public int Size()
            {
                return top + 1; // El tamaño actual es 'top + 1'
            }
        }


        public class DynamicStack
        {
            private Node top;

            public DynamicStack()
            {
                top = null;
            }

            // Método para insertar un elemento en la pila
            public void Push(Node newNode)
            {
                if (IsEmpty())
                {
                    top = newNode;
                    return;
                }

                newNode.Next = top;
                top = newNode;
                return;
            }


            // Método para eliminar y devolver el elemento en el tope de la pila
            public Node Pop()
            {
                if (!IsEmpty())
                {
                    Node current = top;
                    top = top.Next;
                    current.Next = null;
                    return current;
                }
                return null;

            }


            // Método para devolver el elemento en el tope de la pila sin eliminarlo
            public Node Peek()
            {
                if (IsEmpty())
                {
                    return null;
                }

                return top;
            }


            // Método para verificar si la pila está vacía
            public bool IsEmpty()
            {
                return top == null;
            }

            public int Size()
            {
                int count = 0;
                Node current = top;

                // Recorre la pila desde el frente hasta el final
                while (current != null)
                {
                    count++;
                    current = current.Next; // Avanza al siguiente nodo
                }

                return count; // Devuelve el número total de elementos Size
            }
        }
    }
}
