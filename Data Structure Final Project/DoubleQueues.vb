Imports System
Imports System.Collections.Generic

Namespace Data_Structure_Final_Project
    Friend Class DoubleQueues
        Friend Class DoubleEndedStaticQueue
            Private array As Integer()
            Private front As Integer
            Private rear As Integer
            Private sizeField As Integer
            Private capacity As Integer

            Public Sub New(capacity As Integer)
                Me.capacity = capacity
                array = New Integer(capacity - 1) {}
                front = -1
                rear = -1
                sizeField = 0
            End Sub

            ' Verifica si la cola está vacía
            Public Function IsEmpty() As Boolean
                Return sizeField = 0
            End Function

            ' Verifica si la cola está llena
            Public Function IsFull() As Boolean
                Return sizeField = capacity
            End Function

            ' Inserta un elemento en el frente de la cola
            Public Sub InsertFront(value As Integer)
                If sizeField = array.Length Then
                    System.Windows.Forms.MessageBox.Show("The Double Queueu is full.")
                    Return
                End If

                ' Mover todos los elementos una posición hacia atrás
                For i = sizeField - 1 To 0 Step -1
                    array(i + 1) = array(i)
                Next

                ' Insertar el valor al frente
                array(0) = value
                If front = -1 Then front = 0
                rear = (rear + 1) Mod array.Length
                sizeField += 1
            End Sub

            ' Inserta un elemento en el final de la cola
            Public Sub InsertRear(value As Integer)
                If IsFull() Then
                    System.Windows.Forms.MessageBox.Show("The Double Queueu is full.")
                    Return
                End If

                If rear = -1 Then ' Si la cola está vacía
                    front = 0
                    rear = 0
                Else
                    rear = (rear + 1) Mod capacity ' Mover el índice del final hacia adelante
                End If

                array(rear) = value
                sizeField += 1
            End Sub

            ' Elimina un elemento del frente de la cola
            Public Function DeleteFront() As Integer
                If IsEmpty() Then
                    System.Windows.Forms.MessageBox.Show("The Double Queueu is empty.")
                    Return -1
                End If

                Dim value = array(front)
                If front = rear Then ' Si hay un solo elemento
                    front = -1
                    rear = -1
                Else
                    front = (front + 1) Mod capacity ' Mover el índice del frente hacia adelante
                End If

                sizeField -= 1
                Return value
            End Function

            ' Elimina un elemento del final de la cola
            Public Function DeleteRear() As Integer
                If IsEmpty() Then
                    System.Windows.Forms.MessageBox.Show("The Double Queueu is empty.")
                    Return -1
                End If

                Dim value = array(rear)
                If front = rear Then ' Si hay un solo elemento
                    front = -1
                    rear = -1
                Else
                    rear = (rear - 1 + capacity) Mod capacity ' Mover el índice del final hacia atrás
                End If

                sizeField -= 1
                Return value
            End Function

            ' Ver el valor en el frente sin eliminarlo
            Public Function GetFront() As Integer
                If IsEmpty() Then
                    System.Windows.Forms.MessageBox.Show("The Double Queueu is empty.")
                    Return -1
                End If
                Return array(front)
            End Function

            ' Ver el valor en el final sin eliminarlo
            Public Function GetRear() As Integer
                If IsEmpty() Then
                    System.Windows.Forms.MessageBox.Show("The Double Queueu is empty.")
                    Return -1
                End If
                Return array(rear)
            End Function

            ' Obtener el tamaño actual de la cola
            Public Function Size() As Integer
                Return sizeField
            End Function

            Public Function GetQueueElements() As List(Of Integer)
                Dim elements As List(Of Integer) = New List(Of Integer)()

                If front <> -1 Then
                    For i = front To rear
                        elements.Add(array(i))
                    Next
                End If

                Return elements
            End Function
        End Class


        Friend Class DoubleEndedDynamicQueue
            Private front As DoublyNode  ' Frente de la cola
            Private back As DoublyNode   ' Final de la cola
            Private sizeField As Integer    ' Tamaño de la cola

            Public Sub New()
                front = Nothing
                back = Nothing
                sizeField = 0
            End Sub

            ' Agregar un elemento al frente de la cola
            Public Sub InsertFront(value As Integer)
                Dim newNode As DoublyNode = New DoublyNode(value)

                If IsEmpty() Then
                    front = CSharpImpl.__Assign(back, newNode)  ' Si la cola está vacía, el nuevo nodo es tanto el frente como el final
                Else
                    newNode.Next = front
                    front.Prev = newNode
                    front = newNode
                End If

                sizeField += 1
            End Sub

            ' Agregar un elemento al final de la cola
            Public Sub InsertRear(value As Integer)
                Dim newNode As DoublyNode = New DoublyNode(value)

                If IsEmpty() Then
                    front = CSharpImpl.__Assign(back, newNode)  ' Si la cola está vacía, el nuevo nodo es tanto el frente como el final
                Else
                    newNode.Prev = back
                    back.Next = newNode
                    back = newNode
                End If

                sizeField += 1
            End Sub

            ' Eliminar un elemento del frente de la cola
            Public Function DeleteFront() As Integer
                If IsEmpty() Then
                    Throw New InvalidOperationException("Queue is empty.")
                End If

                Dim frontValue = front.Value
                front = front.Next

                If front IsNot Nothing Then
                    front.Prev = Nothing
                Else
                    back = Nothing  ' Si la cola queda vacía, el final también debe ser nulo
                End If

                sizeField -= 1
                Return frontValue
            End Function

            ' Eliminar un elemento del final de la cola
            Public Function DeleteRear() As Integer
                If IsEmpty() Then
                    Throw New InvalidOperationException("Queue is empty.")
                End If

                Dim backValue = back.Value
                back = back.Prev

                If back IsNot Nothing Then
                    back.Next = Nothing
                Else
                    front = Nothing  ' Si la cola queda vacía, el frente también debe ser nulo
                End If

                sizeField -= 1
                Return backValue
            End Function

            ' Ver el elemento del frente de la cola sin eliminarlo
            Public Function GetFront() As Integer
                If IsEmpty() Then
                    Throw New InvalidOperationException("Queue is empty.")
                End If

                Return front.Value
            End Function

            ' Ver el elemento del final de la cola sin eliminarlo
            Public Function GetRear() As Integer
                If IsEmpty() Then
                    Throw New InvalidOperationException("Queue is empty.")
                End If

                Return back.Value
            End Function

            ' Obtener el tamaño de la cola
            Public Function Size() As Integer
                Return sizeField
            End Function

            ' Verificar si la cola está vacía
            Public Function IsEmpty() As Boolean
                Return sizeField = 0
            End Function

            Public Function GetQueueElements() As List(Of Integer)
                Dim elements As List(Of Integer) = New List(Of Integer)()
                Dim current = front

                While current IsNot Nothing
                    elements.Add(current.Value)
                    current = current.Next
                End While

                Return elements
            End Function

            Private Class CSharpImpl
                <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
                Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                    target = value
                    Return value
                End Function
            End Class
        End Class
    End Class
End Namespace
