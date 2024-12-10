Imports System
Imports System.Threading.Tasks

Namespace Data_Structure_Final_Project
    Friend Class HeapSort
        Public Shared Async Function Sort(array As Integer(), displayCallback As Action(Of Integer(), Integer, Integer)) As Task

            Dim n = array.Length

            ' Construir el heap (reordenar el arreglo)
            For i = n / 2 - 1 To 0 Step -1
                Await Heapify(array, n, i, displayCallback)
            Next

            ' Extraer elementos del heap uno por uno
            For i = n - 1 To 1 Step -1
                ' Mover la raíz actual al final
                Dim temp = array(0)
                array(0) = array(i)
                array(i) = temp

                displayCallback(array, 0, i)
                Await Task.Delay(500)

                ' Aplicar Heapify al subárbol reducido
                Await Heapify(array, i, 0, displayCallback)
            Next

            displayCallback(array, -1, -1) ' Visualización final
        End Function

        Private Shared Async Function Heapify(array As Integer(), n As Integer, i As Integer, displayCallback As Action(Of Integer(), Integer, Integer)) As Task
            Dim largest = i ' Inicializar el nodo más grande como raíz
            Dim left = 2 * i + 1 ' Hijo izquierdo
            Dim right = 2 * i + 2 ' Hijo derecho

            ' Comparar hijo izquierdo con la raíz
            If left < n AndAlso array(left) > array(largest) Then
                displayCallback(array, i, left)
                Await Task.Delay(500)
                largest = left
            End If

            ' Comparar hijo derecho con la raíz
            If right < n AndAlso array(right) > array(largest) Then
                displayCallback(array, i, right)
                Await Task.Delay(500)
                largest = right
            End If

            ' Si el nodo más grande no es la raíz
            If largest <> i Then
                ' Realizar el intercambio
                Dim swap = array(i)
                array(i) = array(largest)
                array(largest) = swap

                displayCallback(array, i, largest)
                Await Task.Delay(500)

                ' Aplicar Heapify recursivamente
                Await Heapify(array, n, largest, displayCallback)
            End If
        End Function
    End Class
End Namespace
