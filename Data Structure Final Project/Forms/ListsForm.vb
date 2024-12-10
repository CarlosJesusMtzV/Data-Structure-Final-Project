Imports System
Imports System.Windows.Forms
Imports Data_Structure_Final_Project.Lists

Namespace Data_Structure_Final_Project
    Public Partial Class ListsForm
        Inherits ZBase
        Private linkedList As LinkedList
        Private doublyLinkedList As DoublyLinkedList
        Private circularLinkedList As CircularLinkedList
        Private doublyCircularLinkedList As DoublyCircularLinkedList
        Public Sub New()
            InitializeComponent()
            linkedList = New LinkedList()
            doublyLinkedList = New DoublyLinkedList()
            circularLinkedList = New CircularLinkedList()
            doublyCircularLinkedList = New DoublyCircularLinkedList()

            cmbListType.Items.Add("Simple Linked List")
            cmbListType.Items.Add("Doubly Linked List")
            cmbListType.Items.Add("Circular Linked List")
            cmbListType.Items.Add("Doubly Circular Linked List")
            cmbListType.SelectedIndex = 0
        End Sub

        Private Sub btnAdd_Click(sender As Object, e As EventArgs)
            Dim value As Integer = Nothing

            If Integer.TryParse(txtValue.Text, value) Then
                Dim selectedList As String = cmbListType.SelectedItem.ToString()
                Select Case selectedList
                    Case "Simple Linked List"
                        linkedList.Add(New Node(value))
                        UpdateListBox(lstSimpleLinkedList, linkedList.GetHead())
                    Case "Doubly Linked List"
                        doublyLinkedList.Add(New DoublyNode(value))
                        UpdateListBox(lstSimpleLinkedList, doublyLinkedList.GetHead())
                    Case "Circular Linked List"
                        circularLinkedList.Add(New Node(value))
                        UpdateListBox(lstSimpleLinkedList, circularLinkedList.GetHead())
                    Case "Doubly Circular Linked List"
                        doublyCircularLinkedList.Add(New DoublyNode(value))
                        UpdateListBox(lstSimpleLinkedList, doublyCircularLinkedList.GetHead())
                End Select

                txtValue.Clear()
                txtValue.Focus()
            Else
                MessageBox.Show("Please enter a valid integer value.")
            End If
        End Sub

        Private Sub UpdateListBox(listBox As ListBox, head As Object)
            listBox.Items.Clear()

            Dim headNode As Node = Nothing, headDoubleNode As DoublyNode = Nothing

            If CSharpImpl.__Assign(headNode, TryCast(head, Node)) IsNot Nothing Then
                ' Lista simple o lista simple circular
                Dim current = headNode

                Do
                    listBox.Items.Add(current.Value)
                    current = current.Next
                Loop While current IsNot Nothing AndAlso current IsNot headNode ' Para manejar tanto listas simples como circulares
            ElseIf CSharpImpl.__Assign(headDoubleNode, TryCast(head, DoublyNode)) IsNot Nothing Then
                ' Lista doble o lista doble circular
                Dim current = headDoubleNode

                Do
                    listBox.Items.Add(current.Value)
                    current = current.Next
                Loop While current IsNot Nothing AndAlso current IsNot headDoubleNode
            End If
        End Sub

        Private Sub cmbListType_SelectedIndexChanged(sender As Object, e As EventArgs)
            lstSimpleLinkedList.Items.Clear()
        End Sub

        Private Sub btnRemove_Click(sender As Object, e As EventArgs)
            Dim value As Integer = Nothing

            If Integer.TryParse(txtValue.Text, value) Then
                Dim selectedList As String = cmbListType.SelectedItem.ToString()
                Select Case selectedList
                    Case "Simple Linked List"
                        linkedList.Remove(value)
                        UpdateListBox(lstSimpleLinkedList, linkedList.GetHead())
                    Case "Doubly Linked List"
                        doublyLinkedList.Remove(value)
                        UpdateListBox(lstSimpleLinkedList, doublyLinkedList.GetHead())
                    Case "Circular Linked List"
                        circularLinkedList.Remove(value)
                        UpdateListBox(lstSimpleLinkedList, circularLinkedList.GetHead())
                    Case "Doubly Circular Linked List"
                        doublyCircularLinkedList.Remove(value)
                        UpdateListBox(lstSimpleLinkedList, doublyCircularLinkedList.GetHead())
                End Select
                txtValue.Clear()
                txtValue.Focus()
            Else
                MessageBox.Show("Please enter a valid integer value.")
            End If
        End Sub

        Private Sub btnContains_Click(sender As Object, e As EventArgs)
            Dim value As Integer = Nothing

            If Integer.TryParse(txtValue.Text, value) Then
                Dim selectedList As String = cmbListType.SelectedItem.ToString()
                Dim contains = False
                Select Case selectedList
                    Case "Simple Linked List"
                        contains = linkedList.Contains(value)
                    Case "Doubly Linked List"
                        contains = doublyLinkedList.Contains(value)
                    Case "Circular Linked List"
                        contains = circularLinkedList.Contains(value)
                    Case "Doubly Circular Linked List"
                        contains = doublyCircularLinkedList.Contains(value)
                End Select
                If contains Then
                    MessageBox.Show("The list contains the value.")
                Else
                    MessageBox.Show("The list does not contain the value.")
                End If
            Else
                MessageBox.Show("Please enter a valid integer value.")
            End If
        End Sub

        Private Sub btnCount_Click(sender As Object, e As EventArgs)
            Dim selectedList As String = cmbListType.SelectedItem.ToString()
            Dim count = 0
            Select Case selectedList
                Case "Simple Linked List"
                    count = linkedList.Count()
                Case "Doubly Linked List"
                    count = doublyLinkedList.Count()
                Case "Circular Linked List"
                    count = circularLinkedList.Count()
                Case "Doubly Circular Linked List"
                    count = doublyCircularLinkedList.Count()
            End Select
            MessageBox.Show($"The list has {count} elements.")
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
