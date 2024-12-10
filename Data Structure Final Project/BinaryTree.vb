Imports System

Namespace Data_Structure_Final_Project
    Friend Class BinaryTree
        Public Class Node
            Public left As Node?
            Public right As Node?
            Public value As Integer?

            Public Sub New(value As Integer)
                Me.value = value
                left = Nothing
                right = Nothing

            End Sub
            Public Sub New()
                value = Nothing
                left = Nothing
                right = Nothing

            End Sub

            Public Sub Insert(value As Integer)
                If Me.value Is Nothing Then
                    Me.value = value
                    Return
                End If
                If value < Me.value Then
                    If left Is Nothing Then
                        left = New Node(value)
                    Else
                        left.Insert(value)
                    End If
                Else
                    If right Is Nothing Then
                        right = New Node(value)
                    Else
                        right.Insert(value)
                    End If
                End If




            End Sub




            Public Function Search(value As Integer) As Node?
                If Me.value Is Nothing Then Return Nothing

                If Me.value = value Then Return Me

                If value < Me.value Then
                    If left IsNot Nothing Then
                        Return left.Search(value)
                    Else
                        Return Nothing
                    End If
                Else
                    If right IsNot Nothing Then
                        Return right.Search(value)
                    Else
                        Return Nothing
                    End If
                End If
            End Function

            Public Function Delete(root As Node?, value As Integer) As Node?
                If root Is Nothing Then Return Nothing

                If value < root.value Then
                    root.left = Me.Delete(root.left, value)
                ElseIf value > root.value Then
                    root.right = Me.Delete(root.right, value)
                Else

                    If root.left Is Nothing AndAlso root.right Is Nothing Then
                        Return Nothing
                    ElseIf root.left Is Nothing Then
                        Return root.right
                    ElseIf root.right Is Nothing Then
                        Return root.left
                    Else
                        Dim minNode = Me.FindMin(root.right)
                        root.value = minNode.value
                        root.right = Me.Delete(root.right, CInt(minNode.value))
                    End If
                End If

                Return root
            End Function

            Private Function FindMin(node As Node?) As Node?
                While node?.left IsNot Nothing
                    node = node.left
                End While
                Return node
            End Function

            Public Function GetNodeInfo(node As Node?, action As String) As String


                If node Is Nothing Then
                    Return "Node with value not found."
                End If

                Dim height = GetNodeHeight(node)



                Dim isLeaf = node.left Is Nothing AndAlso node.right Is Nothing

                Dim leafStatus = If(isLeaf, "is a leaf node", "is not a leaf node")

                Return $"The {action} Node with value {node.value.ToString()} was found at the height {height} and {leafStatus}."
            End Function
            Public Function GetNodeHeight(node As Node?) As Integer

                If Me Is Nothing Then Return 0
                Dim height = 1
                If value = node?.value Then Return height

                If node?.value < value Then


                    If left IsNot Nothing Then

                        If left.value = node?.value Then
                            Return height + 1
                        End If
                        Dim temp As Integer = left.GetNodeHeight(node)
                        Return height + temp
                    Else
                        Return 0
                    End If
                Else
                    If right IsNot Nothing Then


                        If right.value = node?.value Then
                            Return height + 1
                        End If
                        Return height + right.GetNodeHeight(node)
                    Else
                        Return 0
                    End If
                End If
            End Function


            Public Function CountNodes() As Integer
                Dim count = 1
                If left IsNot Nothing Then
                    count += left.CountNodes()
                End If
                If right IsNot Nothing Then
                    count += right.CountNodes()
                End If
                Return count
            End Function

            Public Function GetHeight() As Integer
                If Me Is Nothing Then Return 0

                Dim leftHeight As Integer = If(left?.GetHeight(), 0)
                Dim rightHeight As Integer = If(right?.GetHeight(), 0)

                Return Math.Max(leftHeight, rightHeight) + 1
            End Function




            Public Sub TreeInfo()
                Dim heightt As Integer = GetHeight()
                Dim nodeCount As Integer = CountNodes()
                Dim height = heightt
                Dim levels = height

                System.Windows.Forms.MessageBox.Show($"Tree Information:
Nodes: {nodeCount}
Height: {height}
Levels: {levels}")
            End Sub
        End Class
    End Class
End Namespace
