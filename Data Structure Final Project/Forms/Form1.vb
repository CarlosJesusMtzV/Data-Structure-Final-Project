
Namespace Data_Structure_Final_Project
    Public Partial Class Form1
        Inherits ZBase
        Public Sub New()
            InitializeComponent()
        End Sub


        Private Sub lBoxOptions_SelectedIndexChanged(sender As Object, e As EventArgs)

            Select Case lBoxOptions.SelectedIndex
                Case 0
                    Dim listsForm As ListsForm = New ListsForm()
                    listsForm.Show()
                    Hide()
                Case 1
                    Dim stacksForm As StacksForm = New StacksForm()
                    stacksForm.Show()
                    Hide()
                Case 2
                    Dim queuesForm As QueuesForm = New QueuesForm()
                    queuesForm.Show()
                    Hide()
                Case 3
                    Dim treesForm As TreesForm = New TreesForm()
                    treesForm.Show()
                    Hide()
                Case 4
                    Dim graphsForm As GraphsForm = New GraphsForm()
                    graphsForm.Show()
                    Hide()
                Case 5
                    Dim algorithmsForm As AlgorithmsForm = New AlgorithmsForm()
                    algorithmsForm.Show()
                    Hide()
            End Select
        End Sub
    End Class
End Namespace
