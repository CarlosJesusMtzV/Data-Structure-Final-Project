Imports System

Namespace Data_Structure_Final_Project
    Friend Class Queues
        Public Class StaticQueue
            Private elements As Integer() ' Arreglo para almacenar elementos de la cola
            Private front As Integer      ' Índice del primer elemento de la cola
            Private rear As Integer       ' Índice del último elemento de la cola
            Private count As Integer      ' Número de elementos en la cola

            Public ReadOnly Property Capacity As Integer ' Capacidad máxima de la cola

            Public Sub New(capacity As Integer)
                Me.Capacity = capacity
                elements = New Integer(capacity - 1) {}
                front = 0
                rear = -1
                count = 0
            End Sub

            ' Método para agregar un número a la cola
            Public Sub Enqueue(number As Integer)
                If count = Capacity Then
                    System.Windows.Forms.MessageBox.Show("The Queueu is full.")
                    Return
                End If

                rear = (rear + 1) Mod Capacity
                elements(rear) = number
                count += 1
            End Sub

            ' Método para eliminar y devolver el número al frente de la cola
            Public Function Dequeue() As Integer
                If IsEmpty() Then
                    System.Windows.Forms.MessageBox.Show("The Queueu is empty.")
                End If

                Dim number = elements(front)
                front = (front + 1) Mod Capacity
                count -= 1
                Return number
            End Function

            ' Método para ver el número al frente de la cola sin eliminarlo
            Public Function Peek() As Integer
                If IsEmpty() Then
                    System.Windows.Forms.MessageBox.Show("The Queueu is empty.")
                End If

                Return elements(front)
            End Function

            ' Método para verificar si la cola está vacía
            Public Function IsEmpty() As Boolean
                Return count = 0
            End Function

            ' Método para verificar si la cola está llena
            Public Function IsFull() As Boolean
                Return count = Capacity
            End Function

            'method to get size of the queue
            Public Function Size() As Integer
                Return count
            End Function
        End Class


        Public Class DynamicQueue
            Private front As Node ' Nodo al frente de la cola
            Private rear As Node  ' Nodo al final de la cola
            Private countField As Integer  ' Número de elementos en la cola

            Public ReadOnly Property Count As Integer
                Get
                    Return countField
                End Get
            End Property

            Public Sub New()
                front = Nothing
                rear = Nothing
                countField = 0
            End Sub

            ' Método para agregar un número a la cola
            Public Sub Enqueue(number As Integer)
                Dim newNode As Node = New Node(number)

                If IsEmpty() Then
                    front = CSharpImpl.__Assign(rear, newNode)
                Else
                    rear.Next = newNode
                    rear = newNode
                End If

                countField += 1
            End Sub

            ' Método para eliminar y devolver el número al frente de la cola
            Public Function Dequeue() As Integer
                If IsEmpty() Then
                    System.Windows.Forms.MessageBox.Show("The Queueu is empty.")
                End If

                Dim data = front.Value
                front = front.Next

                If front Is Nothing Then
                    rear = Nothing ' La cola queda vacía
                End If

                countField -= 1
                Return data
            End Function

            ' Método para ver el número al frente de la cola sin eliminarlo
            Public Function Peek() As Integer
                If IsEmpty() Then
                    System.Windows.Forms.MessageBox.Show("The Queueu is empty.")
                End If

                Return front.Value
            End Function

            ' Método para verificar si la cola está vacía
            Public Function IsEmpty() As Boolean
                Return front Is Nothing
            End Function

            'method to get size of the queue
            Public Function Size() As Integer
                Return countField
            End Function

            Private Class CSharpImpl
                <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
                Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                    target = value
                    Return value
                End Function
            End Class
        End Class


        Friend Class CircularQueue
            Private array As Integer()
            Private front As Integer
            Private rear As Integer
            Private count As Integer
            Public ReadOnly Property Capacity As Integer

            ' Constructor para inicializar la cola circular con un tamaño determinado
            Public Sub New(capacity As Integer)
                Me.Capacity = capacity
                array = New Integer(capacity - 1) {}
                front = 0
                rear = -1
                count = 0
            End Sub

            ' Método para agregar un elemento al final de la cola
            Public Sub Enqueue(value As Integer)
                If count = Capacity Then
                    System.Windows.Forms.MessageBox.Show("The Queueu is full.")
                    Return
                End If

                rear = (rear + 1) Mod Capacity  ' Mover el índice rear de forma circular
                array(rear) = value
                count += 1
            End Sub

            ' Método para eliminar un elemento del frente de la cola
            Public Function Dequeue() As Integer
                If IsEmpty() Then
                    System.Windows.Forms.MessageBox.Show("The Queueu is empty.")
                End If

                Dim dequeuedValue = array(front)
                front = (front + 1) Mod Capacity  ' Mover el índice front de forma circular
                count -= 1
                Return dequeuedValue
            End Function

            ' Método para ver el valor del frente de la cola sin eliminarlo
            Public Function Peek() As Integer
                If IsEmpty() Then
                    System.Windows.Forms.MessageBox.Show("The Queueu is empty.")
                End If

                Return array(front)
            End Function

            ' Método para obtener el número de elementos en la cola
            Public Function Size() As Integer
                Return count
            End Function

            ' Método para verificar si la cola está vacía
            Public Function IsEmpty() As Boolean
                Return count = 0
            End Function

            ' Método para verificar si la cola está llena
            Public Function IsFull() As Boolean
                Return count = Capacity
            End Function
        End Class
    End Class
End Namespace
