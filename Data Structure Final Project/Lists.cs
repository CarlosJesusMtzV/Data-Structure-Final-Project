using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Final_Project
{
    internal class Lists
    {
        public class LinkedList
        {
            private Node head;
            public LinkedList()
            {
                head = null;
            }

            public void Add(Node newNode/*int value*/)
            {
                //Node newNode = new Node(value);
                //If the list is empty, add the new node as the head
                if (head == null)
                {
                    head = newNode;
                    return;
                }
                //If the new node is less than the head, add it as the new head
                if (newNode.Value < head.Value)
                {
                    newNode.Next = head;
                    head = newNode;
                    return;
                }
                //Find the correct position for the new node
                Node current = head;
                //While the current node is not the last node and the value of the next node is less than the value of the new node
                while (current.Next != null && current.Next.Value < newNode.Value)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            public void Remove(int value)
            {
                if (head == null)
                {
                    return;
                }
                if (head.Value == value)
                {
                    head = head.Next;
                    return;
                }
                Node current = head;
                while (current.Next != null)
                {
                    if (current.Next.Value == value)
                    {
                        current.Next = current.Next.Next;
                        return;
                    }
                    current = current.Next;
                }
            }
            public bool Contains(int value)
            {
                Node current = head;
                while (current != null)
                {
                    if (current.Value == value)
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }
            public int Count()
            {
                int count = 0;
                Node current = head;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }

            public override string ToString()
            {
                string result = "";
                Node current = head;
                while (current != null)
                {
                    result += current.ToString() + " ";
                    current = current.Next;
                }
                return result;
            }

            public Node GetHead() => head;
        }


        public class DoublyLinkedList
        {
            private DoublyNode head;
            public DoublyLinkedList()
            {
                head = null;
            }

            public void Add(DoublyNode newNode)
            {

                if (head == null || head.Value >= newNode.Value) // Insertar al inicio si está vacía o el valor es menor.
                {
                    newNode.Next = head!;
                    if (head != null) head.Prev = newNode;
                    head = newNode;
                }
                else
                {
                    DoublyNode current = head;
                    while (current.Next != null && current.Next.Value < newNode.Value)
                    {
                        current = current.Next;
                    }

                    newNode.Next = current.Next!;
                    if (current.Next != null) current.Next.Prev = newNode;
                    current.Next = newNode;
                    newNode.Prev = current;
                }
            }

            public void Remove(int value)
            {
                if (head == null)
                {
                    return;
                }
                if (head.Value == value)
                {
                    head = head.Next;
                    head.Prev = null;
                    return;
                }
                DoublyNode current = head;
                while (current.Next != null)
                {
                    if (current.Next.Value == value)
                    {
                        current.Next = current.Next.Next;
                        if (current.Next != null)
                        {
                            current.Next.Prev = current;
                        }
                        return;
                    }
                    current = current.Next;
                }
            }

            public int Count()
            {
                int count = 0;
                DoublyNode current = head;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }
            public bool Contains(int value)
            {
                DoublyNode current = head;
                while (current != null)
                {
                    if (current.Value == value)
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }

            public DoublyNode GetHead() => head;
        }


        public class CircularLinkedList
        {
            private Node head;
            public CircularLinkedList()
            {
                head = null;
            }

            public void Add(Node newNode)
            {
                //Lista vacía
                if (head == null)
                {
                    head = newNode;
                    head.Next = head;
                }
                //si el valor es menos que el head el valor sera el nuevo head
                else if (newNode.Value < head.Value)
                {
                    Node current = head;
                    while (current.Next != head)
                    {
                        current = current.Next;
                    }
                    newNode.Next = head;
                    current.Next = newNode;
                    head = newNode;
                }
                // Buscar la posición correcta en la lista
                else
                {
                    Node current = head;

                    while (current.Next != head && current.Next.Value < newNode.Value)
                    {
                        current = current.Next;
                    }
                    // Verificamos si el valor ya existe
                    if (current.Next.Value == newNode.Value)
                    {
                        return;
                    }
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }



            public void Remove(int value)
            {
                if (head == null)
                {
                    MessageBox.Show("The list is empty, no nodes to remove.");
                    return;
                }

                Node current = head;

                if (head.Value == value)
                {

                    if (head.Next == head)
                    {
                        head = null;
                    }
                    else
                    {
                        while (current.Next != head)
                        {
                            current = current.Next;
                        }

                        head = head.Next;
                        current.Next = head;
                    }
                    MessageBox.Show("Value removed successfully.");
                    return;
                }

                // El nodo a eliminar no es el head
                current = head;

                while (current.Next != head)
                {
                    if (current.Next.Value == value)
                    {
                        current.Next = current.Next.Next;
                        MessageBox.Show("Value removed successfully.");
                        return;
                    }

                    current = current.Next;
                }

                MessageBox.Show("Value not found.");
            }

            public int Count()
            {
                if (head == null)
                {
                    return 0;
                }
                int count = 1;
                Node current = head;
                while (current.Next != head)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }

            public bool Contains(int value)
            {
                if (head == null)
                {
                    return false;
                }
                Node current = head;
                while (current.Next != head)
                {
                    if (current.Value == value)
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return current.Value == value;
            }

            public Node GetHead() => head;
        }

        internal class DoublyCircularLinkedList
        {
            private DoublyNode head;

            public DoublyCircularLinkedList()
            {
                head = null;
            }

            public void Add(DoublyNode newNode)
            {
                //If the list is empty 
                if (head == null)
                {
                    head = newNode;
                    head.Next = head;
                    head.Prev = head;
                    return;
                }

                //Agregegar un nodo si ya hay nodos en la lista 
                //Insertar un nodo al inicio 
                if (newNode.Value < head.Value)
                {
                    newNode.Next = head;
                    newNode.Prev = head.Prev;
                    head.Prev.Next = newNode; //Se actualiza en next del ultimo nodo para que apunte al nuevo nodo
                    head.Prev = newNode;
                    head = newNode;
                    return;
                }

                //Insertar un nodo al final 
                //Evalua si el valor del nuevo nodo es mayor al valor de ultimo nodo (head.Prev.Value)
                if (newNode.Value > head.Prev.Value)
                {
                    newNode.Next = head; // El siguiente de newNode
                    newNode.Prev = head.Prev;
                    head.Prev.Next = newNode; // Update the next of the last node
                    head.Prev = newNode; // Update head's previous to the new node
                    return;
                }


                // Find the correct position for the new node
                DoublyNode current = head;

                // Traverse the list to find the right spot
                while (current.Next != head && current.Next.Value < newNode.Value)
                {
                    current = current.Next;
                }

                // Insert the new node
                newNode.Next = current.Next;
                newNode.Prev = current;

                current.Next.Prev = newNode; // Update the next node's previous
                current.Next = newNode; // Link current node to the new node
            }

            public void Remove(int value)
            {
                if (head == null)
                {
                    return;
                }

                if (head.Next == head) // Solo hay un nodo en la lista
                {
                    head = null; // La lista queda vacía
                    return;
                }

                //Eliminación al inicio 
                if (head.Value == value)
                {
                    head.Prev.Next = head.Next; // Update last node's next
                    head.Next.Prev = head.Prev; // Update second node's previous
                    head = head.Next; // Update head to the next node
                    return;
                }

                //Eliminación al final 
                if (head.Prev.Value == value)
                {
                    // Aquí eliminamos el último nodo
                    head.Prev = head.Prev.Prev; // Mover el puntero de cabeza hacia atrás
                    head.Prev.Next = head; // Actualizar el siguiente del nuevo último nodo
                    return;
                }

                // Eliminación de un nodo intermedio
                DoublyNode current = head;
                while (current.Next != head && current.Value != value)
                {
                    current = current.Next;
                }

                // Si el nodo con el valor fue encontrado
                if (current.Value == value)
                {
                    current.Prev.Next = current.Next; // Actualizar el siguiente del nodo anterior
                    current.Next.Prev = current.Prev; // Actualizar el anterior del nodo siguiente
                }
            }


            public bool Contains(int value)
            {

                if (head == null)
                {
                    return false;
                }

                DoublyNode current = head;
                do
                {
                    if (current.Value == value)
                    {
                        return true;
                    }
                    current = current.Next;

                } while (current != head);
                return false;
            }

            //implement the method count
            public int Count()
            {
                if (head == null)
                {
                    return 0;
                }
                int count = 0;
                DoublyNode current = head;
                do
                {
                    count++;
                    current = current.Next;
                } while (current != head);
                return count;
            }

            public override string ToString()
            {
                if (head == null)

                    return "The doubly circular linked list is void";

                string result = "";
                DoublyNode? current = head;

                do
                {
                    result += current.ToString() + " "; // Llama al ToString del nodo
                    current = current.Next; // Avanza al siguiente nodo
                } while (current != head); // Detenerse cuando se regrese al nodo cabeza

                return result;
            }

            public DoublyNode GetHead() => head;
        }
    }
}
