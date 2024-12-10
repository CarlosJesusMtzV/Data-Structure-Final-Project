Imports System
Imports System.Collections.Generic

Namespace Data_Structure_Final_Project
    Friend Class PriorityQueues
        Public Class VectorOfVectors_PQ(Of T)
            Public _queue As T()()
            Public _maxPriority As Integer

            ' Constructor, initialize with max priority level
            Public Sub New(maxPriority As Integer)
                _maxPriority = maxPriority
                _queue = New T(maxPriority + 1 - 1)() {}  ' Array of arrays
                For i = 0 To maxPriority
                    _queue(i) = New T(-1) {}  ' Initialize each inner array as an empty array
                Next
            End Sub

            ' Enqueue an item with a specified priority
            Public Sub Enqueue(item As T, priority As Integer)
                If priority < 0 OrElse priority > _maxPriority Then
                    System.Windows.Forms.MessageBox.Show("Priority out of range.")
                    Return
                End If

                ' Resize the array at the given priority index to accommodate the new item
                Array.Resize(_queue(priority), _queue(priority).Length + 1)
                _queue(priority)(_queue(priority).Length - 1) = item
            End Sub

            ' Dequeue the item with the highest priority (largest priority value)
            Public Function Dequeue() As T
                ' Find the highest non-empty priority array
                For i = _maxPriority To 0 Step -1
                    If _queue(i).Length > 0 Then
                        Dim item = _queue(i)(0)
                        ' Shift all items down in the array (like removing the first element)
                        For j = 0 To _queue(i).Length - 1 - 1
                            _queue(i)(j) = _queue(i)(j + 1)
                        Next
                        Array.Resize(_queue(i), _queue(i).Length - 1)  ' Remove last item (after shift)
                        Return item
                    End If
                Next

                Throw New InvalidOperationException("Queue is empty.")
            End Function

            ' Peek the item with the highest priority (without removing it)
            Public Function Peek() As T
                For i = _maxPriority To 0 Step -1
                    If _queue(i).Length > 0 Then
                        Return _queue(i)(0)
                    End If
                Next

                Throw New InvalidOperationException("Queue is empty.")
            End Function

            ' Check if the priority queue is empty
            Public Function IsEmpty() As Boolean
                For i = 0 To _maxPriority
                    If _queue(i).Length > 0 Then
                        Return False
                    End If
                Next
                Return True
            End Function

            ' Return the number of elements in the priority queue
            Public Function Size() As Integer
                Dim lSize = 0
                For i = 0 To _maxPriority
                    lSize += _queue(i).Length
                Next
                Return lSize
            End Function

            Public Function ToList() As List(Of String)
                Dim result = New List(Of String)()
                For i = _queue.Length - 1 To 0 Step -1
                    For Each item In _queue(i)
                        result.Add($"Priority {i}: {item}")
                    Next
                Next
                Return result
            End Function
        End Class
        Public Class VectorOfLists_PQ(Of T)
            Private _priorityLists As List(Of T)()

            ' Maximum priority level supported
            Private _maxPriority As Integer

            ' Constructor
            Public Sub New(maxPriority As Integer)
                ' Validate max priority
                If maxPriority < 0 Then Throw New ArgumentException("Max priority must be non-negative.")

                ' Initialize the array of lists
                _maxPriority = maxPriority
                _priorityLists = New List(Of T)(maxPriority + 1 - 1) {}

                ' Initialize each list
                For i = 0 To maxPriority
                    _priorityLists(i) = New List(Of T)()
                Next
            End Sub

            ' Add an item with specified priority
            Public Sub Enqueue(item As T, priority As Integer)
                ' Validate priority range
                If priority < 0 OrElse priority > _maxPriority Then
                    System.Windows.Forms.MessageBox.Show("Priority out of range.")
                    Return
                End If

                ' Add item to the appropriate priority list
                _priorityLists(priority).Add(item)
            End Sub

            ' Remove and return the highest priority item
            Public Function Dequeue() As T
                ' Find the highest non-empty priority list
                For i = _maxPriority To 0 Step -1
                    If _priorityLists(i).Count > 0 Then
                        ' Get the first item in the list
                        Dim item = _priorityLists(i)(0)

                        ' Remove the first item
                        _priorityLists(i).RemoveAt(0)

                        Return item
                    End If
                Next

                ' If no items found, throw an exception
                Throw New InvalidOperationException("Queue is empty.")
            End Function

            ' View the highest priority item without removing it
            Public Function Peek() As T
                ' Find the highest non-empty priority list
                For i = _maxPriority To 0 Step -1
                    If _priorityLists(i).Count > 0 Then
                        Return _priorityLists(i)(0)
                    End If
                Next

                ' If no items found, throw an exception
                Throw New InvalidOperationException("Queue is empty.")
            End Function

            ' Check if the queue is empty
            Public Function IsEmpty() As Boolean
                ' Check if all priority lists are empty
                For i = 0 To _maxPriority
                    If _priorityLists(i).Count > 0 Then
                        Return False
                    End If
                Next
                Return True
            End Function

            ' Get the total number of items in the queue
            Public Function Size() As Integer
                Dim totalSize = 0

                ' Sum the sizes of all priority lists
                For i = 0 To _maxPriority
                    totalSize += _priorityLists(i).Count
                Next

                Return totalSize
            End Function

            ' Optional: Clear the entire queue
            Public Sub Clear()
                ' Clear each list in the array
                For i = 0 To _maxPriority
                    _priorityLists(i).Clear()
                Next
            End Sub

            Public Function ToList() As List(Of String)
                Dim result = New List(Of String)()
                For i = _priorityLists.Length - 1 To 0 Step -1
                    For Each item In _priorityLists(i)
                        result.Add($"Priority {i}: {item}")
                    Next
                Next
                Return result
            End Function
        End Class
        Public Class ListOfLists_PQ(Of T)
            ' Vector of Vectors, where each index represents a priority level.
            Private _queue As List(Of List(Of T))
            Private _maxPriority As Integer

            ' Constructor, initialize with max priority level.
            Public Sub New(maxPriority As Integer)
                _maxPriority = maxPriority
                _queue = New List(Of List(Of T))(New List(Of T)(maxPriority + 1 - 1) {}) ' +1 because index starts at 0
                For i = 0 To maxPriority
                    _queue(i) = New List(Of T)()
                Next
            End Sub

            ' Enqueue an item with a specified priority
            Public Sub Enqueue(item As T, priority As Integer)
                If priority < 0 OrElse priority > _maxPriority Then
                    System.Windows.Forms.MessageBox.Show("Priority out of range.")
                    Return
                End If

                _queue(priority).Add(item)
            End Sub

            ' Dequeue the item with the highest priority (largest priority value)
            Public Function Dequeue() As T
                ' Find the highest non-empty priority list
                For i = _maxPriority To 0 Step -1
                    If _queue(i).Count > 0 Then
                        Dim item = _queue(i)(0)
                        _queue(i).RemoveAt(0) ' Remove the item
                        Return item
                    End If
                Next

                Throw New InvalidOperationException("Queue is empty.")
            End Function

            ' Peek the item with the highest priority (without removing it)
            Public Function Peek() As T
                For i = _maxPriority To 0 Step -1
                    If _queue(i).Count > 0 Then
                        Return _queue(i)(0)
                    End If
                Next

                Throw New InvalidOperationException("Queue is empty.")
            End Function

            ' Check if the priority queue is empty
            Public Function IsEmpty() As Boolean
                For i = 0 To _maxPriority
                    If _queue(i).Count > 0 Then
                        Return False
                    End If
                Next
                Return True
            End Function

            ' Return the number of elements in the priority queue
            Public Function Size() As Integer
                Dim lSize = 0
                For i = 0 To _maxPriority
                    lSize += _queue(i).Count
                Next
                Return lSize
            End Function

            Public Function ToList() As List(Of String)
                Dim result = New List(Of String)()
                For i = _queue.Count - 1 To 0 Step -1
                    For Each item In _queue(i)
                        result.Add($"Priority {i}: {item}")
                    Next
                Next
                Return result
            End Function
        End Class
        Public Class ListOfVectors_PQ(Of T)
            Private _queue As List(Of T())
            Private _maxPriority As Integer

            Public Sub New(maxPriority As Integer)
                _maxPriority = maxPriority
                _queue = New List(Of T())(maxPriority + 1)
                For i = 0 To maxPriority
                    _queue.Add(New T(-1) {})
                Next
            End Sub

            Public Sub Enqueue(item As T, priority As Integer)
                If priority < 0 OrElse priority > _maxPriority Then
                    System.Windows.Forms.MessageBox.Show("Priority out of range.")
                    Return
                End If

                ' Create a new array with increased size and copy existing elements
                Dim currentArray = _queue(priority)
                Array.Resize(currentArray, currentArray.Length + 1)
                currentArray(currentArray.Length - 1) = item
                _queue(priority) = currentArray
            End Sub

            Public Function Dequeue() As T
                For i = _maxPriority To 0 Step -1
                    If _queue(i).Length > 0 Then
                        Dim item = _queue(i)(0)

                        ' Create a new smaller array to remove the first element
                        Dim currentArray = _queue(i)
                        Dim newArray = New T(currentArray.Length - 1 - 1) {}

                        ' Copy elements after the first one
                        Array.Copy(currentArray, 1, newArray, 0, newArray.Length)

                        _queue(i) = newArray
                        Return item
                    End If
                Next
                Throw New InvalidOperationException("Queue is empty.")
            End Function

            ' Rest of the methods remain the same as in your original implementation
            Public Function Peek() As T
                For i = _maxPriority To 0 Step -1
                    If _queue(i).Length > 0 Then
                        Return _queue(i)(0)
                    End If
                Next
                Throw New InvalidOperationException("Queue is empty.")
            End Function

            Public Function IsEmpty() As Boolean
                For i = 0 To _maxPriority
                    If _queue(i).Length > 0 Then
                        Return False
                    End If
                Next
                Return True
            End Function

            Public Function Size() As Integer
                Dim lSize = 0
                For i = 0 To _maxPriority
                    lSize += _queue(i).Length
                Next
                Return lSize
            End Function

            Public Function ToList() As List(Of String)
                Dim result = New List(Of String)()
                For i = _queue.Count - 1 To 0 Step -1
                    For Each item In _queue(i)
                        result.Add($"Priority {i}: {item}")
                    Next
                Next
                Return result
            End Function
        End Class
    End Class
End Namespace
