Imports System

Namespace Data_Structure_Final_Project
    Friend Class Stacks
        Public Class StaticStack
            Private elements As Integer() ' Arreglo para almacenar los elementos
            Private top As Integer        ' Índice del elemento en el tope de la pila

            ' Constructor que inicializa la pila con un tamaño fijo
            Public Sub New()
                elements = New Integer(7) {}
                top = -1           ' Inicialmente, la pila está vacía
            End Sub

            ' Método para insertar un elemento en la pila
            Public Sub Push(dato As Integer)
                If IsFull() Then
                    System.Windows.Forms.MessageBox.Show("La pila estatica está llena.")
                    Return
                End If
                elements(Threading.Interlocked.Increment(top)) = dato ' Incrementar 'top' y agregar el dato
            End Sub

            ' Método para eliminar y devolver el elemento en el tope de la pila
            Public Function Pop() As String
                If IsEmpty() Then
                    Return "La pila está vacía."
                End If
                Return elements(Math.Max(Threading.Interlocked.Decrement(top), top + 1)).ToString() ' Devolver y decrementar 'top'
            End Function

            ' Método para devolver el elemento en el tope de la pila sin eliminarlo
            Public Function Peek() As String
                If IsEmpty() Then
                    Return "La pila está vacía."
                End If
                Return elements(top).ToString() ' Devolver el valor sin modificar 'top'
            End Function

            ' Método para verificar si la pila está vacía
            Public Function IsEmpty() As Boolean
                Return top = -1 ' La pila está vacía si 'top' es -1
            End Function

            ' Método para verificar si la pila está llena
            Public Function IsFull() As Boolean
                Return top = elements.Length - 1 ' La pila está llena si 'top' alcanza el tamaño máximo
            End Function

            ' Método para devolver el tamaño de la pila
            Public Function Size() As Integer
                Return top + 1 ' El tamaño actual es 'top + 1'
            End Function
        End Class


        Public Class DynamicStack
            Private top As Node

            Public Sub New()
                top = Nothing
            End Sub

            ' Método para insertar un elemento en la pila
            Public Sub Push(newNode As Node)
                If IsEmpty() Then
                    top = newNode
                    Return
                End If

                newNode.Next = top
                top = newNode
                Return
            End Sub


            ' Método para eliminar y devolver el elemento en el tope de la pila
            Public Function Pop() As Node
                If Not IsEmpty() Then
                    Dim current = top
                    top = top.Next
                    current.Next = Nothing
                    Return current
                End If
                Return Nothing

            End Function


            ' Método para devolver el elemento en el tope de la pila sin eliminarlo
            Public Function Peek() As Node
                If IsEmpty() Then
                    Return Nothing
                End If

                Return top
            End Function


            ' Método para verificar si la pila está vacía
            Public Function IsEmpty() As Boolean
                Return top Is Nothing
            End Function

            Public Function Size() As Integer
                Dim count = 0
                Dim current = top

                ' Recorre la pila desde el frente hasta el final
                While current IsNot Nothing
                    count += 1
                    current = current.Next ' Avanza al siguiente nodo
                End While

                Return count ' Devuelve el número total de elementos Size
            End Function
        End Class
    End Class
End Namespace
