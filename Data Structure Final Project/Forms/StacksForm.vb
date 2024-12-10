Imports System
Imports System.Text
Imports System.Windows.Forms
Imports Data_Structure_Final_Project.Stacks

Namespace Data_Structure_Final_Project
    Public Partial Class StacksForm
        Inherits ZBase
        Private dynamicStack As DynamicStack
        Private staticStack As StaticStack
        Public Sub New()
            InitializeComponent()
            dynamicStack = New DynamicStack()
            staticStack = New StaticStack()
            cmbStackType.SelectedIndex = 0
        End Sub
        Private Sub btnPush_Click(sender As Object, e As EventArgs)
            Dim value As Integer = Nothing

            If Integer.TryParse(txtStackValue.Text, value) Then
                Dim selectedList As String = cmbStackType.SelectedItem.ToString()
                Select Case selectedList
                    Case "Static"
                        staticStack.Push(Integer.Parse(txtStackValue.Text))
                        UpdateStacks()
                    Case "Dynamic"
                        Dim newNode As Node = New Node(Convert.ToInt32(txtStackValue.Text))
                        dynamicStack.Push(newNode)
                        UpdateStacks()
                    Case Else
                        MessageBox.Show("Please select a stack type.")
                End Select

                txtStackValue.Clear()
                txtStackValue.Focus()
            Else
                MessageBox.Show("Please enter a valid integer value.")
            End If
        End Sub

        Private Sub UpdateStacks()
            lstStaticStack.Items.Clear()
            Dim selectedList As String = cmbStackType.SelectedItem.ToString()
            If Equals(selectedList, "Static") Then
                ' Actualizar la pila estática
                Dim temporal As StaticStack = New StaticStack()
                Dim elemento As String

                ' Mostrar los elementos en la pila estática
                While Not staticStack.IsEmpty()
                    elemento = staticStack.Pop().ToString()
                    lstStaticStack.Items.Add(elemento)
                    temporal.Push(Integer.Parse(elemento))
                End While

                ' Restaurar los elementos en la pila original
                While Not temporal.IsEmpty()
                    staticStack.Push(Integer.Parse(temporal.Pop().ToString()))
                End While
            Else
                Dim currentNode As Node = dynamicStack.Peek()
                While currentNode IsNot Nothing
                    lstStaticStack.Items.Add(currentNode.Value)
                    currentNode = currentNode.Next
                End While
            End If
        End Sub

        Private Sub cmbStackType_SelectedIndexChanged(sender As Object, e As EventArgs)
            lstStaticStack.Items.Clear()
            UpdateStacks()
        End Sub

        Private Sub btnPop_Click(sender As Object, e As EventArgs)
            Dim selectedList As String = cmbStackType.SelectedItem.ToString()
            Select Case selectedList
                Case "Static"
                    Call MessageBox.Show("The poped value is: " & staticStack.Pop())
                    UpdateStacks()
                Case "Dynamic"
                    'dynamicStack.Pop();
                    'show the poped value in a message box
                    Dim poppedNode As Node = dynamicStack.Pop()
                    Call MessageBox.Show("Element removed from the dynamic stack: " & poppedNode.Value.ToString())
                    UpdateStacks()
            End Select
        End Sub

        Private Sub btnPeek_Click(sender As Object, e As EventArgs)
            Dim selectedList As String = cmbStackType.SelectedItem.ToString()
            Select Case selectedList
                Case "Static"
                    Call MessageBox.Show("The peeked value is: " & staticStack.Peek())
                Case "Dynamic"
                    Call MessageBox.Show("The peeked value is: " & dynamicStack.Peek().Value.ToString())
            End Select
        End Sub

        Private Sub btnSize_Click(sender As Object, e As EventArgs)
            Dim selectedList As String = cmbStackType.SelectedItem.ToString()
            Select Case selectedList
                Case "Static"
                    Call MessageBox.Show("The size of the stack is: " & staticStack.Size().ToString())
                Case "Dynamic"
                    Call MessageBox.Show("The size of the stack is: " & dynamicStack.Size().ToString())
            End Select
        End Sub
    End Class
End Namespace
