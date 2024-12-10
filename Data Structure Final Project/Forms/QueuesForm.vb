Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports Data_Structure_Final_Project.DoubleQueues
Imports Data_Structure_Final_Project.PriorityQueues
Imports Data_Structure_Final_Project.Queues

Namespace Data_Structure_Final_Project
    Public Partial Class QueuesForm
        Inherits ZBase
        Private staticQueue As StaticQueue
        Private dynamicQueue As DynamicQueue
        Private circularQueue As CircularQueue
        Private doubleEndedStaticQueue As DoubleEndedStaticQueue
        Private doubleEndedDynamicQueue As DoubleEndedDynamicQueue
        Private vectorOfVectorsPQ As VectorOfVectors_PQ(Of Integer)
        Private vectorOfListsPQ As VectorOfLists_PQ(Of Integer)
        Private listOfListsPQ As ListOfLists_PQ(Of Integer)
        Private listOfVectorsPQ As ListOfVectors_PQ(Of Integer)
        Public Sub New()
            InitializeComponent()
            staticQueue = New StaticQueue(5)
            dynamicQueue = New DynamicQueue()
            circularQueue = New CircularQueue(5)
            doubleEndedStaticQueue = New DoubleEndedStaticQueue(5)
            doubleEndedDynamicQueue = New DoubleEndedDynamicQueue()
            vectorOfVectorsPQ = New VectorOfVectors_PQ(Of Integer)(3)
            vectorOfListsPQ = New VectorOfLists_PQ(Of Integer)(3)
            listOfListsPQ = New ListOfLists_PQ(Of Integer)(3)
            listOfVectorsPQ = New ListOfVectors_PQ(Of Integer)(3)
            cmbQueueType.SelectedIndex = 0
            cmbDQType.SelectedIndex = 0
            cmbTypeOfPQ.SelectedIndex = 0
        End Sub

        Private Sub btnEnqueue_Click(sender As Object, e As EventArgs)
            Dim value As Integer = Nothing

            If Integer.TryParse(txtQueueValue.Text, value) Then
                Dim selectedList As String = cmbQueueType.SelectedItem.ToString()
                Select Case selectedList
                    Case "Static"
                        staticQueue.Enqueue(value)
                        UpdateQueueDisplay(staticQueue, lstQueues)
                    Case "Dynamic"
                        dynamicQueue.Enqueue(value)
                        UpdateQueueDisplay(dynamicQueue, lstQueues)
                    Case "Circular"
                        circularQueue.Enqueue(value)
                        UpdateQueueDisplay(circularQueue, lstQueues)
                    Case Else
                        MessageBox.Show("Please select a queue type.")
                End Select

                txtQueueValue.Clear()
                txtQueueValue.Focus()
            Else
                MessageBox.Show("Please enter a valid integer value.")
            End If
        End Sub

        Private Sub UpdateQueueDisplay(queue As Object, listBox As ListBox)
            listBox.Items.Clear()

            Dim staticQueue As StaticQueue = Nothing, dynamicQueue As DynamicQueue = Nothing, circularQueue As CircularQueue = Nothing

            If CSharpImpl.__Assign(staticQueue, TryCast(queue, StaticQueue)) IsNot Nothing Then
                Dim tempQueue As StaticQueue = New StaticQueue(staticQueue.Capacity)

                While Not staticQueue.IsEmpty()
                    Dim value As Integer = staticQueue.Dequeue()
                    listBox.Items.Add(value)
                    tempQueue.Enqueue(value)
                End While

                ' Restaurar los elementos a la cola estática
                While Not tempQueue.IsEmpty()
                    staticQueue.Enqueue(tempQueue.Dequeue())
                End While
            ElseIf CSharpImpl.__Assign(dynamicQueue, TryCast(queue, DynamicQueue)) IsNot Nothing Then
                Dim tempQueue As DynamicQueue = New DynamicQueue()

                While Not dynamicQueue.IsEmpty()
                    Dim value As Integer = dynamicQueue.Dequeue()
                    listBox.Items.Add(value)
                    tempQueue.Enqueue(value)
                End While

                ' Restaurar los elementos a la cola dinámica
                While Not tempQueue.IsEmpty()
                    dynamicQueue.Enqueue(tempQueue.Dequeue())
                End While
            ElseIf CSharpImpl.__Assign(circularQueue, TryCast(queue, CircularQueue)) IsNot Nothing Then
                Dim tempQueue As CircularQueue = New CircularQueue(circularQueue.Capacity)

                While Not circularQueue.IsEmpty()
                    Dim value As Integer = circularQueue.Dequeue()
                    listBox.Items.Add(value)
                    tempQueue.Enqueue(value)
                End While

                ' Restaurar los elementos a la cola circular
                While Not tempQueue.IsEmpty()
                    circularQueue.Enqueue(tempQueue.Dequeue())
                End While
            End If
        End Sub

        Private Sub cmbQueueType_SelectedIndexChanged(sender As Object, e As EventArgs)
            lstQueues.Items.Clear()
            Dim selectedList As String = cmbQueueType.SelectedItem.ToString()
            Select Case selectedList
                Case "Static"
                    UpdateQueueDisplay(staticQueue, lstQueues)
                Case "Dynamic"
                    UpdateQueueDisplay(dynamicQueue, lstQueues)
                Case "Circular"
                    UpdateQueueDisplay(circularQueue, lstQueues)
                Case Else
                    MessageBox.Show("Please select a queue type.")
            End Select
        End Sub

        Private Sub btnDequeue_Click(sender As Object, e As EventArgs)
            Try
                Dim selectedList As String = cmbQueueType.SelectedItem.ToString()

                Select Case selectedList
                    Case "Static"
                        If staticQueue.IsEmpty() Then ' Método personalizado para verificar si la cola está vacía
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                        Call MessageBox.Show("The value removed from the queue is: " & staticQueue.Dequeue().ToString())
                        UpdateQueueDisplay(staticQueue, lstQueues)

                    Case "Dynamic"
                        If dynamicQueue.IsEmpty() Then
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                        Call MessageBox.Show("The value removed from the queue is: " & dynamicQueue.Dequeue().ToString())
                        UpdateQueueDisplay(dynamicQueue, lstQueues)

                    Case "Circular"
                        If circularQueue.IsEmpty() Then
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                        Call MessageBox.Show("The value removed from the queue is: " & circularQueue.Dequeue().ToString())
                        UpdateQueueDisplay(circularQueue, lstQueues)
                End Select

                txtQueueValue.Clear()
                txtQueueValue.Focus()
            Catch ex As Exception
                ' Manejo general de errores inesperados
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnQueuePeek_Click(sender As Object, e As EventArgs)
            Try
                Dim selectedList As String = cmbQueueType.SelectedItem.ToString()
                Select Case selectedList
                    Case "Static"
                        If staticQueue.IsEmpty() Then
                            MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                        Call MessageBox.Show("The value at the front of the queue is: " & staticQueue.Peek().ToString())
                    Case "Dynamic"
                        If dynamicQueue.IsEmpty() Then
                            MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                        Call MessageBox.Show("The value at the front of the queue is: " & dynamicQueue.Peek().ToString())
                    Case "Circular"
                        If circularQueue.IsEmpty() Then
                            MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                        Call MessageBox.Show("The value at the front of the queue is: " & circularQueue.Peek().ToString())
                End Select
            Catch ex As Exception
                ' Manejo general de errores inesperados
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnQueueSize_Click(sender As Object, e As EventArgs)
            Try
                Dim selectedList As String = cmbQueueType.SelectedItem.ToString()
                Select Case selectedList
                    Case "Static"
                        Call MessageBox.Show("The size of the queue is: " & staticQueue.Size().ToString())
                    Case "Dynamic"
                        Call MessageBox.Show("The size of the queue is: " & dynamicQueue.Size().ToString())
                    Case "Circular"
                        Call MessageBox.Show("The size of the queue is: " & circularQueue.Size().ToString())
                End Select
            Catch ex As Exception
                ' Manejo general de errores inesperados
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnInserFront_Click(sender As Object, e As EventArgs)
            Dim value As Integer = Nothing

            If Integer.TryParse(txtDQValue.Text, value) Then
                Dim selectedList As String = cmbDQType.SelectedItem.ToString()
                Select Case selectedList
                    Case "Static"
                        doubleEndedStaticQueue.InsertFront(value) ' Insertar al final de la cola estática

                        ' Limpiar y actualizar el ListBox para la cola estática
                        lstDoubleQueues.Items.Clear()
                        For Each item In doubleEndedStaticQueue.GetQueueElements() ' Obtener elementos de la cola estática
                            lstDoubleQueues.Items.Add(item)  ' Agregar cada elemento al ListBox de la cola estática
                        Next
                    Case "Dynamic"
                        doubleEndedDynamicQueue.InsertFront(value) ' Inserta el valor al frente de la cola dinámica

                        ' Limpiar y actualizar el ListBox para la cola dinámica
                        lstDoubleQueues.Items.Clear()
                        For Each item In doubleEndedDynamicQueue.GetQueueElements()
                            lstDoubleQueues.Items.Add(item)  ' Agregar cada elemento al ListBox de la cola dinámica
                        Next

                    Case Else
                        MessageBox.Show("Please select a double queue type.")
                End Select

                txtDQValue.Clear()
                txtDQValue.Focus()
            Else
                MessageBox.Show("Please enter a valid integer value.")
            End If
        End Sub

        Private Sub cmbDQType_SelectedIndexChanged(sender As Object, e As EventArgs)
            lstDoubleQueues.Items.Clear()
            Dim selectedList As String = cmbDQType.SelectedItem.ToString()
            Select Case selectedList
                Case "Static"
                    For Each item In doubleEndedStaticQueue.GetQueueElements()
                        lstDoubleQueues.Items.Add(item)
                    Next
                Case "Dynamic"
                    For Each item In doubleEndedDynamicQueue.GetQueueElements()
                        lstDoubleQueues.Items.Add(item)
                    Next
            End Select
        End Sub

        Private Sub btnInsertRear_Click(sender As Object, e As EventArgs)
            Dim value As Integer = Nothing

            If Integer.TryParse(txtDQValue.Text, value) Then
                Dim selectedList As String = cmbDQType.SelectedItem.ToString()
                Select Case selectedList
                    Case "Static"
                        doubleEndedStaticQueue.InsertRear(value) ' Insertar al final de la cola estática
                        ' Limpiar y actualizar el ListBox para la cola estática
                        lstDoubleQueues.Items.Clear()
                        For Each item In doubleEndedStaticQueue.GetQueueElements() ' Obtener elementos de la cola estática
                            lstDoubleQueues.Items.Add(item)  ' Agregar cada elemento al ListBox de la cola estática
                        Next
                    Case "Dynamic"
                        doubleEndedDynamicQueue.InsertRear(value) ' Inserta el valor al frente de la cola dinámica
                        ' Limpiar y actualizar el ListBox para la cola dinámica
                        lstDoubleQueues.Items.Clear()
                        For Each item In doubleEndedDynamicQueue.GetQueueElements()
                            lstDoubleQueues.Items.Add(item)  ' Agregar cada elemento al ListBox de la cola dinámica
                        Next

                    Case Else
                        MessageBox.Show("Please select a double queue type.")
                End Select
                txtDQValue.Clear()
                txtDQValue.Focus()
            Else
                MessageBox.Show("Please enter a valid integer value.")
            End If
        End Sub

        Private Sub btnDeleteFront_Click(sender As Object, e As EventArgs)
            Try
                Dim selectedList As String = cmbDQType.SelectedItem.ToString()
                Select Case selectedList
                    Case "Static"
                        If doubleEndedStaticQueue.IsEmpty() Then
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                        Call MessageBox.Show("The value removed from the queue is: " & doubleEndedStaticQueue.DeleteFront().ToString())
                        lstDoubleQueues.Items.Clear()
                        For Each item In doubleEndedStaticQueue.GetQueueElements()
                            lstDoubleQueues.Items.Add(item)
                        Next
                    Case "Dynamic"
                        If doubleEndedDynamicQueue.IsEmpty() Then
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                        Call MessageBox.Show("The value removed from the queue is: " & doubleEndedDynamicQueue.DeleteFront().ToString())
                        lstDoubleQueues.Items.Clear()
                        For Each item In doubleEndedDynamicQueue.GetQueueElements()
                            lstDoubleQueues.Items.Add(item)
                        Next
                End Select
            Catch ex As Exception
                ' Manejo general de errores inesperados
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnDeleteRear_Click(sender As Object, e As EventArgs)
            Dim selectedList As String = cmbDQType.SelectedItem.ToString()
            Select Case selectedList
                Case "Static"
                    If doubleEndedStaticQueue.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value removed from the queue is: " & doubleEndedStaticQueue.DeleteRear().ToString())
                    lstDoubleQueues.Items.Clear()
                    For Each item In doubleEndedStaticQueue.GetQueueElements()
                        lstDoubleQueues.Items.Add(item)
                    Next
                Case "Dynamic"
                    If doubleEndedDynamicQueue.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value removed from the queue is: " & doubleEndedDynamicQueue.DeleteRear().ToString())
                    lstDoubleQueues.Items.Clear()
                    For Each item In doubleEndedDynamicQueue.GetQueueElements()
                        lstDoubleQueues.Items.Add(item)
                    Next
            End Select

        End Sub

        Private Sub btnGetFront_Click(sender As Object, e As EventArgs)
            Dim selectedList As String = cmbDQType.SelectedItem.ToString()
            Select Case selectedList
                Case "Static"
                    If doubleEndedStaticQueue.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value at the front of the queue is: " & doubleEndedStaticQueue.GetFront().ToString())
                Case "Dynamic"
                    If doubleEndedDynamicQueue.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value at the front of the queue is: " & doubleEndedDynamicQueue.GetFront().ToString())
            End Select
        End Sub

        Private Sub btnGetRear_Click(sender As Object, e As EventArgs)
            Dim selectedList As String = cmbDQType.SelectedItem.ToString()
            Select Case selectedList
                Case "Static"
                    If doubleEndedStaticQueue.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value at the rear of the queue is: " & doubleEndedStaticQueue.GetRear().ToString())
                Case "Dynamic"
                    If doubleEndedDynamicQueue.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value at the rear of the queue is: " & doubleEndedDynamicQueue.GetRear().ToString())
            End Select
        End Sub

        Private Sub btnDoubleQSize_Click(sender As Object, e As EventArgs)
            Dim selectedList As String = cmbDQType.SelectedItem.ToString()
            Select Case selectedList
                Case "Static"
                    Call MessageBox.Show("The size of the queue is: " & doubleEndedStaticQueue.Size().ToString())
                Case "Dynamic"
                    Call MessageBox.Show("The size of the queue is: " & doubleEndedDynamicQueue.Size().ToString())
            End Select
        End Sub

        Private Sub btnEnqueuePQ_Click(sender As Object, e As EventArgs)
            Dim value As Integer = Nothing

            If Integer.TryParse(txtValuePQ.Text, value) Then
                Dim priority = Convert.ToInt32(txtPriority.Text)
                Dim selectedList As String = cmbTypeOfPQ.SelectedItem.ToString()
                Select Case selectedList
                    Case "Vector Of Vectors"
                        vectorOfVectorsPQ.Enqueue(value, priority)
                        UpdateListBox(lstPQ, vectorOfVectorsPQ)
                    Case "Vector Of Lists"
                        vectorOfListsPQ.Enqueue(value, priority)
                        UpdateListBox(lstPQ, vectorOfListsPQ)
                    Case "List Of Vectors"
                        listOfVectorsPQ.Enqueue(value, priority)
                        UpdateListBox(lstPQ, listOfVectorsPQ)
                    Case "List Of Lists"
                        listOfListsPQ.Enqueue(value, priority)
                        UpdateListBox(lstPQ, listOfListsPQ)
                    Case Else
                        MessageBox.Show("Please select a queue type.")
                End Select

                txtQueueValue.Clear()
                txtQueueValue.Focus()
            Else
                MessageBox.Show("Please enter a valid integer value.")
            End If
        End Sub

        Private Sub cmbTypeOfPQ_SelectedIndexChanged(sender As Object, e As EventArgs)
            lstPQ.Items.Clear()
            Dim selectedList As String = cmbTypeOfPQ.SelectedItem.ToString()
            Select Case selectedList
                Case "Vector Of Vectors"
                    UpdateListBox(lstPQ, vectorOfVectorsPQ)
                Case "Vector Of Lists"
                    UpdateListBox(lstPQ, vectorOfListsPQ)
                Case "List Of Vectors"
                    UpdateListBox(lstPQ, listOfVectorsPQ)
                Case "List Of Lists"
                    UpdateListBox(lstPQ, listOfListsPQ)
                Case Else
                    MessageBox.Show("Please select a queue type.")
            End Select
        End Sub

        Private Sub btnDequeuePQ_Click(sender As Object, e As EventArgs)
            Dim selectedList As String = cmbTypeOfPQ.SelectedItem.ToString()
            Select Case selectedList
                Case "Vector Of Vectors"
                    If vectorOfVectorsPQ.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value removed from the queue is: " & vectorOfVectorsPQ.Dequeue().ToString())
                    UpdateListBox(lstPQ, vectorOfVectorsPQ)
                Case "Vector Of Lists"
                    If vectorOfListsPQ.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value removed from the queue is: " & vectorOfListsPQ.Dequeue().ToString())
                    UpdateListBox(lstPQ, vectorOfListsPQ)
                Case "List Of Vectors"
                    If listOfVectorsPQ.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value removed from the queue is: " & listOfVectorsPQ.Dequeue().ToString())
                    UpdateListBox(lstPQ, listOfVectorsPQ)
                Case "List Of Lists"
                    If listOfListsPQ.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value removed from the queue is: " & listOfListsPQ.Dequeue().ToString())
                    UpdateListBox(lstPQ, listOfListsPQ)
            End Select
        End Sub

        Private Sub btnPeekPQ_Click(sender As Object, e As EventArgs)
            Dim selectedList As String = cmbTypeOfPQ.SelectedItem.ToString()
            Select Case selectedList
                Case "Vector Of Vectors"
                    If vectorOfVectorsPQ.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value at the front of the queue is: " & vectorOfVectorsPQ.Peek().ToString())
                Case "Vector Of Lists"
                    If vectorOfListsPQ.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value at the front of the queue is: " & vectorOfListsPQ.Peek().ToString())
                Case "List Of Vectors"
                    If listOfVectorsPQ.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value at the front of the queue is: " & listOfVectorsPQ.Peek().ToString())
                Case "List Of Lists"
                    If listOfListsPQ.IsEmpty() Then
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Call MessageBox.Show("The value at the front of the queue is: " & listOfListsPQ.Peek().ToString())
            End Select
        End Sub

        Private Sub btnSizePQ_Click(sender As Object, e As EventArgs)
            Dim selectedList As String = cmbTypeOfPQ.SelectedItem.ToString()
            Select Case selectedList
                Case "Vector Of Vectors"
                    Call MessageBox.Show("The size of the queue is: " & vectorOfVectorsPQ.Size().ToString())
                Case "Vector Of Lists"
                    Call MessageBox.Show("The size of the queue is: " & vectorOfListsPQ.Size().ToString())
                Case "List Of Vectors"
                    Call MessageBox.Show("The size of the queue is: " & listOfVectorsPQ.Size().ToString())
                Case "List Of Lists"
                    Call MessageBox.Show("The size of the queue is: " & listOfListsPQ.Size().ToString())
            End Select
        End Sub

        Private Sub UpdateListBox(Of T As Class)(listBox As ListBox, queue As T)
            listBox.Items.Clear()
            Dim items = TryCast(queue, dynamic).ToList()
            listBox.Items.AddRange(items.ToArray())
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
