Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Data_Structure_Final_Project
    Public Partial Class TreesForm
        Inherits ZBase
        Private root As BinaryTree.Node
        Public Sub New()
            InitializeComponent()
            root = New BinaryTree.Node()
        End Sub


        Private Sub DrawTree()
            ' Este método será usado para dibujar el árbol en un control como un PictureBox
            Using g As Graphics = panelTree.CreateGraphics()
                g.Clear(Color.White) ' Limpia el panel antes de dibujar

                If root.value IsNot Nothing Then
                    DrawNode(g, root, panelTree.Width / 2, 20, 100) ' Comienza a dibujar desde el centro del Panel
                End If
            End Using
        End Sub

        Private Sub DrawNode(g As Graphics, node As BinaryTree.Node, x As Integer, y As Integer, xOffset As Integer)
            If node Is Nothing Then Return

            ' Limitar la posición dentro del Panel
            Dim panelWidth = panelTree.Width
            Dim panelHeight = panelTree.Height

            ' Asegurar que las coordenadas x, y no se salgan del área del Panel
            x = Math.Max(30, Math.Min(panelWidth - 30, x))   ' Limita x entre 30 y panelWidth - 30
            y = Math.Max(30, Math.Min(panelHeight - 30, y))  ' Limita y entre 30 y panelHeight - 30

            ' Dibuja el nodo
            g.FillEllipse(Brushes.LightBlue, x - 15, y - 15, 30, 30)
            g.DrawString(node.value.ToString(), Font, Brushes.Black, x - 10, y - 10)

            ' Dibuja las aristas
            If node.left IsNot Nothing Then
                Dim leftX = x - xOffset
                Dim leftY = y + 60
                g.DrawLine(Pens.Black, x, y, leftX, leftY)
                Me.DrawNode(g, node.left, leftX, leftY, xOffset / 2)
            End If

            If node.right IsNot Nothing Then
                Dim rightX = x + xOffset
                Dim rightY = y + 60
                g.DrawLine(Pens.Black, x, y, rightX, rightY)
                Me.DrawNode(g, node.right, rightX, rightY, xOffset / 2)
            End If
        End Sub

        Private Sub btnInsertNode_Click(sender As Object, e As EventArgs)
            Dim value As Integer = Nothing

            If Integer.TryParse(txtNodeValue.Text, value) Then
                root.Insert(value)
                DrawTree()
                txtNodeValue.Clear()
            End If
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As EventArgs)
            Dim value As Integer = Nothing

            If Integer.TryParse(txtNodeValue.Text, value) Then
                root = root.Delete(root, value) ' Elimina el nodo
                DrawTree()
            End If
        End Sub

        Private Sub btnSearch_Click(sender As Object, e As EventArgs)
            Dim value As Integer = Nothing

            If Integer.TryParse(txtNodeValue.Text, value) Then
                Dim foundNode As BinaryTree.Node = root.Search(value)
                MessageBox.Show(root.GetNodeInfo(foundNode, "Found"))
            End If
        End Sub

        Private Sub btnClear_Click(sender As Object, e As EventArgs)
            root = New BinaryTree.Node() ' Establece la raíz a null, eliminando todo el árbol
            DrawTree()
        End Sub

        Private Sub btnPreOrder_Click(sender As Object, e As EventArgs)
            Dim result = PreOrderTraversal(root)
            txtOutput.Text = result
        End Sub
        Private Function PreOrderTraversal(node As BinaryTree.Node) As String
            If node Is Nothing Then Return ""
            Return node.value.ToString() & ", " & Me.PreOrderTraversal(node.left) & Me.PreOrderTraversal(node.right)
        End Function

        Private Sub btnInOrder_Click(sender As Object, e As EventArgs)
            Dim result = InOrderTraversal(root)
            txtOutput.Text = result
        End Sub

        Private Function InOrderTraversal(node As BinaryTree.Node) As String
            If node Is Nothing Then Return ""
            Return Me.InOrderTraversal(node.left) & node.value.ToString() & ", " & Me.InOrderTraversal(node.right)
        End Function

        Private Sub btnPostOrder_Click(sender As Object, e As EventArgs)
            Dim result = PostOrderTraversal(root)
            txtOutput.Text = result
        End Sub

        Private Function PostOrderTraversal(node As BinaryTree.Node) As String
            If node Is Nothing Then Return ""
            Return Me.PostOrderTraversal(node.left) & Me.PostOrderTraversal(node.right) & node.value.ToString() & ", "
        End Function
    End Class
End Namespace
