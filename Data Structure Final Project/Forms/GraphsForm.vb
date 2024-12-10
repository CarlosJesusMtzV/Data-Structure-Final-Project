Imports System
Imports System.Linq
Imports System.Windows.Forms
Imports Data_Structure_Final_Project.Graphs

Namespace Data_Structure_Final_Project
    Public Partial Class GraphsForm
        Inherits ZBase
        Private graph As Graph
        Public Sub New()
            InitializeComponent()
            graph = New Graph()
        End Sub

        Private Sub btnAddNode_Click(sender As Object, e As EventArgs)
            Dim nodeName As String = txtNode.Text.Trim()
            Dim weight As Integer = Nothing
            If Not String.IsNullOrEmpty(nodeName) Then
                ' Verificar si el nodo ya existe en el grafo
                If graph.Nodes.Any(Function(node) Equals(node.Name, nodeName)) Then
                    MessageBox.Show($"The node '{nodeName}' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Si no existe, añadir el nodo
                    Dim newNode As GraphNode = New GraphNode(nodeName)
                    graph.AddNode(newNode)
                    MessageBox.Show($"Node '{nodeName}' added.", "Success", MessageBoxButtons.OK)
                    txtNode.Clear()
                    Dim weightText As String = txtWeight.Text.Trim()

                    If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, weight) Then
                        txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
                    Else
                        txtGraphRepresentation.Text = graph.ShowAdjacencyList()
                    End If
                    txtFrom.Clear()
                    txtTo.Clear()
                End If
            End If
        End Sub

        Private Sub btnAddEdge_Click(sender As Object, e As EventArgs)
            Dim fromNodeName As String = txtFrom.Text.Trim()
            Dim toNodeName As String = txtTo.Text.Trim()
            Dim weightText As String = txtWeight.Text.Trim() ' Asumimos que tienes un campo de texto para el peso

            Dim fromNode = graph.Nodes.Find(Function(n) Equals(n.Name, fromNodeName))
            Dim toNode = graph.Nodes.Find(Function(n) Equals(n.Name, toNodeName))
            ' Si el campo de peso no está vacío, se usa el constructor con peso
            Dim weight As Integer = Nothing

            If fromNode IsNot Nothing AndAlso toNode IsNot Nothing Then
                If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, weight) Then
                    If chkDirected.Checked Then
                        graph.AddEdge(fromNode, toNode, weight)
                        MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}' with weight {weight}.")
                    Else
                        graph.AddNoDirectedEdge(fromNode, toNode, weight)
                        MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}' with weight {weight}.")
                    End If
                    txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
                Else
                    ' Si no se especifica peso, se usa el constructor sin peso
                    If chkDirected.Checked Then
                        graph.AddEdge(fromNode, toNode)
                        MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}'.")
                    Else
                        graph.AddNoDirectedEdge(fromNode, toNode)
                        MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}'.")
                    End If
                    txtGraphRepresentation.Text = graph.ShowAdjacencyList()
                End If
                txtFrom.Clear()
                txtTo.Clear()
            Else
                MessageBox.Show("One or both nodes do not exist.")
            End If
        End Sub

        Private Sub btnRemoveNode_Click(sender As Object, e As EventArgs)
            Dim nodeName As String = txtNode.Text.Trim()
            Dim nodeToRemove = graph.Nodes.Find(Function(n) Equals(n.Name, nodeName))
            Dim weight As Integer = Nothing

            If nodeToRemove IsNot Nothing Then
                graph.RemoveNode(nodeToRemove)
                MessageBox.Show($"Node '{nodeName}' deleted.", "Success", MessageBoxButtons.OK)
                txtNode.Clear()

                ' Actualizar la representación de la lista de adyacencia
                Dim weightText As String = txtWeight.Text.Trim()

                If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, weight) Then
                    txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
                Else
                    txtGraphRepresentation.Text = graph.ShowAdjacencyList()
                End If
                txtFrom.Clear()
                txtTo.Clear()
            Else
                MessageBox.Show("Node not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub btnRemoveEdge_Click(sender As Object, e As EventArgs)
            Dim fromNodeName As String = txtFrom.Text.Trim()
            Dim toNodeName As String = txtTo.Text.Trim()
            Dim isDirected = chkDirected.Checked ' CheckBox para determinar si la arista es dirigida.

            Dim fromNode = graph.Nodes.Find(Function(n) Equals(n.Name, fromNodeName))
            Dim toNode = graph.Nodes.Find(Function(n) Equals(n.Name, toNodeName))
            Dim weight As Integer = Nothing

            If fromNode IsNot Nothing AndAlso toNode IsNot Nothing Then
                If isDirected Then
                    graph.RemoveEdge(fromNode, toNode)
                    MessageBox.Show($"Directed edge removed from '{fromNodeName}' to '{toNodeName}'.", "Success", MessageBoxButtons.OK)
                Else
                    graph.RemoveEdge(fromNode, toNode)
                    graph.RemoveEdge(toNode, fromNode)
                    MessageBox.Show($"Undirected edge removed between '{fromNodeName}' and '{toNodeName}'.", "Success", MessageBoxButtons.OK)
                End If

                Dim weightText As String = txtWeight.Text.Trim()

                If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, weight) Then
                    txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
                Else
                    txtGraphRepresentation.Text = graph.ShowAdjacencyList()
                End If

                txtFrom.Clear()
                txtTo.Clear()
            Else
                MessageBox.Show("One or both nodes do not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub btnShowDFS_Click(sender As Object, e As EventArgs)
            txtGraphRepresentation.Clear()
            ' Obtener el nombre del nodo de inicio desde una TextBox (puede ser un número o una palabra)
            Dim startNodeName = txtStartNode.Text

            ' Buscar el nodo en el grafo cuyo nombre coincida con el ingresado
            Dim startNode = graph.Nodes.FirstOrDefault(Function(n) Equals(n.Name, startNodeName))

            If startNode IsNot Nothing Then
                ' Realizar DFS desde el nodo encontrado
                Dim result = graph.DFSIterative(startNode)
                txtGraphRepresentation.Text = result  ' Mostrar el resultado en el TextBox
            Else
                ' Si el nodo no existe, mostrar un mensaje de error
                txtGraphRepresentation.Text = "Node not found."
            End If
        End Sub

        Private Sub btnShowBFS_Click(sender As Object, e As EventArgs)
            txtGraphRepresentation.Clear()
            ' Obtener el nombre del nodo de inicio desde una TextBox (puede ser un número o una palabra)
            Dim startNodeName = txtStartNode.Text

            ' Buscar el nodo en el grafo cuyo nombre coincida con el ingresado
            Dim startNode = graph.Nodes.FirstOrDefault(Function(n) Equals(n.Name, startNodeName))

            If startNode IsNot Nothing Then
                ' Realizar DFS desde el nodo encontrado
                Dim result = graph.BFS(startNode)
                txtGraphRepresentation.Text = result  ' Mostrar el resultado en el TextBox
            Else
                ' Si el nodo no existe, mostrar un mensaje de error
                txtGraphRepresentation.Text = "Node not found."
            End If
        End Sub

        Private Sub btnShowDFSRecursive_Click(sender As Object, e As EventArgs)
            txtGraphRepresentation.Clear()
            ' Obtener el nombre del nodo de inicio desde una TextBox (puede ser un número o una palabra)
            Dim startNodeName = txtStartNode.Text
            Dim startNode = graph.Nodes.FirstOrDefault(Function(n) Equals(n.Name, startNodeName))
            If startNode IsNot Nothing Then
                Dim result = graph.DFS(startNode)
                txtGraphRepresentation.Text = result
            Else
                txtGraphRepresentation.Text = "Node not found."
            End If

        End Sub

        Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs)
            'add a validation in english
            Dim result = MessageBox.Show("Are you sure you want to remove all nodes and edges?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                graph.RemoveGraph()
                MessageBox.Show("All nodes and edges removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtGraphRepresentation.Clear()

            End If
        End Sub
    End Class
End Namespace
