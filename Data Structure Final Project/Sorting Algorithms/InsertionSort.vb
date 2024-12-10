Imports System
Imports System.Threading.Tasks

Namespace Data_Structure_Final_Project
    Friend Class InsertionSort
        Public Shared Async Function Sort(array As Integer(), displayCallback As Action(Of Integer(), Integer, Integer)) As Task
            Dim n = array.Length


            For i = 1 To n - 1
                Dim key = array(i)
                Dim j = i - 1

                ' Visualizar la comparación inicial
                displayCallback(array, i, j)
                Await Task.Delay(500) ' Pausa para observar

                ' Mover los elementos del array que son mayores que la clave
                ' a una posición adelante de su posición actual
                While j >= 0 AndAlso array(j) > key
                    array(j + 1) = array(j)

                    ' Visualizar el movimiento
                    displayCallback(array, j, j + 1)
                    Await Task.Delay(500) ' Pausa para observar

                    j -= 1
                End While
                array(j + 1) = key

                ' Visualizar la inserción del elemento
                displayCallback(array, j + 1, i)
                Await Task.Delay(500) ' Pausa para observar
            Next

            displayCallback(array, -1, -1) ' Visualización final
        End Function
    End Class
End Namespace
