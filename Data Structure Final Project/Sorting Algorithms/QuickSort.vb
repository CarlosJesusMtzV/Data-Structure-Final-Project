Imports System
Imports System.Threading.Tasks

Namespace Data_Structure_Final_Project
    Friend Class QuickSort
        Public Shared Async Function Sort(array As Integer(), low As Integer, high As Integer, displayCallback As Action(Of Integer(), Integer, Integer)) As Task
            If low < high Then
                ' Encuentra el pivote
                Dim pivotIndex = Await Partition(array, low, high, displayCallback)

                ' Visualizar la partición actual
                displayCallback(array, low, high)
                Await Task.Delay(500) ' Pausa para visualizar la partición

                ' Ordenar recursivamente las sublistas
                Await Sort(array, low, pivotIndex - 1, displayCallback)
                Await Sort(array, pivotIndex + 1, high, displayCallback)
            End If
        End Function

        Private Shared Async Function Partition(array As Integer(), low As Integer, high As Integer, displayCallback As Action(Of Integer(), Integer, Integer)) As Task(Of Integer)
            Dim pivot = array(high)
            Dim i = low - 1

            For j = low To high - 1
                ' Mostrar la comparación entre array[j] y el pivote
                displayCallback(array, j, high)
                Await Task.Delay(500) ' Pausa para visualizar la comparación

                If array(j) <= pivot Then
                    i += 1
                    ' Intercambiar array[i] y array[j]
                    Dim temp = array(i)
                    array(i) = array(j)
                    array(j) = temp

                    ' Mostrar el intercambio
                    displayCallback(array, i, j)
                    Await Task.Delay(500) ' Pausa para visualizar el intercambio
                End If
            Next

            ' Colocar el pivote en su lugar correcto
            Dim pivotIndex = i + 1
            Dim tempPivot = array(pivotIndex)
            array(pivotIndex) = array(high)
            array(high) = tempPivot

            ' Mostrar la colocación del pivote
            displayCallback(array, pivotIndex, high)
            Await Task.Delay(500) ' Pausa para visualizar el intercambio del pivote

            Return pivotIndex
        End Function
    End Class
End Namespace
