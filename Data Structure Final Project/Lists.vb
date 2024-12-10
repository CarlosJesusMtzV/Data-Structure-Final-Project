
Namespace Data_Structure_Final_Project
    Friend Class Lists
        Public Class LinkedList
            Private head As Node
            Public Sub New()
                head = Nothing
            End Sub

            Public Sub Add(newNode As Node)
                'Node newNode = new Node(value);
                'If the list is empty, add the new node as the head
                If head Is Nothing Then
                    head = newNode
                    Return
                End If
                'If the new node is less than the head, add it as the new head
                If newNode.Value < head.Value Then
                    newNode.Next = head
                    head = newNode
                    Return
                End If
                'Find the correct position for the new node
                Dim current = head
                'While the current node is not the last node and the value of the next node is less than the value of the new node
                While current.Next IsNot Nothing AndAlso current.Next.Value < newNode.Value
                    current = current.Next
                End While
                newNode.Next = current.Next
                current.Next = newNode
            End Sub
            Public Sub Remove(value As Integer)
                If head Is Nothing Then
                    Return
                End If
                If head.Value = value Then
                    head = head.Next
                    Return
                End If
                Dim current = head
                While current.Next IsNot Nothing
                    If current.Next.Value = value Then
                        current.Next = current.Next.Next
                        Return
                    End If
                    current = current.Next
                End While
            End Sub
            Public Function Contains(value As Integer) As Boolean
                Dim current = head
                While current IsNot Nothing
                    If current.Value = value Then
                        Return True
                    End If
                    current = current.Next
                End While
                Return False
            End Function
            Public Function Count() As Integer
                Dim lCount = 0
                Dim current = head
                While current IsNot Nothing
                    lCount += 1
                    current = current.Next
                End While
                Return lCount
            End Function

            Public Overrides Function ToString() As String
                Dim result = ""
                Dim current = head
                While current IsNot Nothing
                    result += current.ToString() & " "
                    current = current.Next
                End While
                Return result
            End Function

            Public Function GetHead() As Node
                Return head
            End Function
        End Class


        Public Class DoublyLinkedList
            Private head As DoublyNode
            Public Sub New()
                head = Nothing
            End Sub

            Public Sub Add(newNode As DoublyNode)

                If head Is Nothing OrElse head.Value >= newNode.Value Then ' Insertar al inicio si está vacía o el valor es menor.
                                        ''' Cannot convert AssignmentExpressionSyntax, System.InvalidCastException: No se puede convertir un objeto de tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' al tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''                     newNode.Next = this.head!
''' 
                    If head IsNot Nothing Then head.Prev = newNode
                    head = newNode
                Else
                    Dim current = head
                    While current.Next IsNot Nothing AndAlso current.Next.Value < newNode.Value
                        current = current.Next
                    End While

                                        ''' Cannot convert AssignmentExpressionSyntax, System.InvalidCastException: No se puede convertir un objeto de tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' al tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''                     newNode.Next = current.Next!
''' 
                    If current.Next IsNot Nothing Then current.Next.Prev = newNode
                    current.Next = newNode
                    newNode.Prev = current
                End If
            End Sub

            Public Sub Remove(value As Integer)
                If head Is Nothing Then
                    Return
                End If
                If head.Value = value Then
                    head = head.Next
                    head.Prev = Nothing
                    Return
                End If
                Dim current = head
                While current.Next IsNot Nothing
                    If current.Next.Value = value Then
                        current.Next = current.Next.Next
                        If current.Next IsNot Nothing Then
                            current.Next.Prev = current
                        End If
                        Return
                    End If
                    current = current.Next
                End While
            End Sub

            Public Function Count() As Integer
                Dim lCount = 0
                Dim current = head
                While current IsNot Nothing
                    lCount += 1
                    current = current.Next
                End While
                Return lCount
            End Function
            Public Function Contains(value As Integer) As Boolean
                Dim current = head
                While current IsNot Nothing
                    If current.Value = value Then
                        Return True
                    End If
                    current = current.Next
                End While
                Return False
            End Function

            Public Function GetHead() As DoublyNode
                Return head
            End Function
        End Class


        Public Class CircularLinkedList
            Private head As Node
            Public Sub New()
                head = Nothing
            End Sub

            Public Sub Add(newNode As Node)
                'Lista vacía
                If head Is Nothing Then
                    head = newNode
                    head.Next = head
                    'si el valor es menos que el head el valor sera el nuevo head
                ElseIf newNode.Value < head.Value Then
                    Dim current = head
                    While current.Next IsNot head
                        current = current.Next
                    End While
                    newNode.Next = head
                    current.Next = newNode
                    ' Buscar la posición correcta en la lista
                    head = newNode
                Else
                    Dim current = head

                    While current.Next IsNot head AndAlso current.Next.Value < newNode.Value
                        current = current.Next
                    End While
                    ' Verificamos si el valor ya existe
                    If current.Next.Value = newNode.Value Then
                        Return
                    End If
                    newNode.Next = current.Next
                    current.Next = newNode
                End If
            End Sub



            Public Sub Remove(value As Integer)
                If head Is Nothing Then
                    System.Windows.Forms.MessageBox.Show("The list is empty, no nodes to remove.")
                    Return
                End If

                Dim current = head

                If head.Value = value Then

                    If head.Next Is head Then
                        head = Nothing
                    Else
                        While current.Next IsNot head
                            current = current.Next
                        End While

                        head = head.Next
                        current.Next = head
                    End If
                    System.Windows.Forms.MessageBox.Show("Value removed successfully.")
                    Return
                End If

                ' El nodo a eliminar no es el head
                current = head

                While current.Next IsNot head
                    If current.Next.Value = value Then
                        current.Next = current.Next.Next
                        System.Windows.Forms.MessageBox.Show("Value removed successfully.")
                        Return
                    End If

                    current = current.Next
                End While

                System.Windows.Forms.MessageBox.Show("Value not found.")
            End Sub

            Public Function Count() As Integer
                If head Is Nothing Then
                    Return 0
                End If
                Dim lCount = 1
                Dim current = head
                While current.Next IsNot head
                    lCount += 1
                    current = current.Next
                End While
                Return lCount
            End Function

            Public Function Contains(value As Integer) As Boolean
                If head Is Nothing Then
                    Return False
                End If
                Dim current = head
                While current.Next IsNot head
                    If current.Value = value Then
                        Return True
                    End If
                    current = current.Next
                End While
                Return current.Value = value
            End Function

            Public Function GetHead() As Node
                Return head
            End Function
        End Class

        Friend Class DoublyCircularLinkedList
            Private head As DoublyNode

            Public Sub New()
                head = Nothing
            End Sub

            Public Sub Add(newNode As DoublyNode)
                'If the list is empty 
                If head Is Nothing Then
                    head = newNode
                    head.Next = head
                    head.Prev = head
                    Return
                End If

                'Agregegar un nodo si ya hay nodos en la lista 
                'Insertar un nodo al inicio 
                If newNode.Value < head.Value Then
                    newNode.Next = head
                    newNode.Prev = head.Prev
                    head.Prev.Next = newNode 'Se actualiza en next del ultimo nodo para que apunte al nuevo nodo
                    head.Prev = newNode
                    head = newNode
                    Return
                End If

                'Insertar un nodo al final 
                'Evalua si el valor del nuevo nodo es mayor al valor de ultimo nodo (head.Prev.Value)
                If newNode.Value > head.Prev.Value Then
                    newNode.Next = head ' El siguiente de newNode
                    newNode.Prev = head.Prev
                    head.Prev.Next = newNode ' Update the next of the last node
                    head.Prev = newNode ' Update head's previous to the new node
                    Return
                End If


                ' Find the correct position for the new node
                Dim current = head

                ' Traverse the list to find the right spot
                While current.Next IsNot head AndAlso current.Next.Value < newNode.Value
                    current = current.Next
                End While

                ' Insert the new node
                newNode.Next = current.Next
                newNode.Prev = current

                current.Next.Prev = newNode ' Update the next node's previous
                current.Next = newNode ' Link current node to the new node
            End Sub

            Public Sub Remove(value As Integer)
                If head Is Nothing Then
                    Return
                End If

                If head.Next Is head Then ' Solo hay un nodo en la lista
                    head = Nothing ' La lista queda vacía
                    Return
                End If

                'Eliminación al inicio 
                If head.Value = value Then
                    head.Prev.Next = head.Next ' Update last node's next
                    head.Next.Prev = head.Prev ' Update second node's previous
                    head = head.Next ' Update head to the next node
                    Return
                End If

                'Eliminación al final 
                If head.Prev.Value = value Then
                    ' Aquí eliminamos el último nodo
                    head.Prev = head.Prev.Prev ' Mover el puntero de cabeza hacia atrás
                    head.Prev.Next = head ' Actualizar el siguiente del nuevo último nodo
                    Return
                End If

                ' Eliminación de un nodo intermedio
                Dim current = head
                While current.Next IsNot head AndAlso current.Value <> value
                    current = current.Next
                End While

                ' Si el nodo con el valor fue encontrado
                If current.Value = value Then
                    current.Prev.Next = current.Next ' Actualizar el siguiente del nodo anterior
                    current.Next.Prev = current.Prev ' Actualizar el anterior del nodo siguiente
                End If
            End Sub


            Public Function Contains(value As Integer) As Boolean

                If head Is Nothing Then
                    Return False
                End If

                Dim current = head
                Do
                    If current.Value = value Then
                        Return True
                    End If
                    current = current.Next

                Loop While current IsNot head
                Return False
            End Function

            'implement the method count
            Public Function Count() As Integer
                If head Is Nothing Then
                    Return 0
                End If
                Dim lCount = 0
                Dim current = head
                Do
                    lCount += 1
                    current = current.Next
                Loop While current IsNot head
                Return lCount
            End Function

            Public Overrides Function ToString() As String

                If head Is Nothing Then Return "The doubly circular linked list is void"

                Dim result = ""
                Dim current As DoublyNode? = head

                Do
                    result += current.ToString() & " " ' Llama al ToString del nodo
                    current = current.Next ' Avanza al siguiente nodo
                Loop While current IsNot head ' Detenerse cuando se regrese al nodo cabeza

                Return result
            End Function

            Public Function GetHead() As DoublyNode
                Return head
            End Function
        End Class
    End Class
End Namespace
