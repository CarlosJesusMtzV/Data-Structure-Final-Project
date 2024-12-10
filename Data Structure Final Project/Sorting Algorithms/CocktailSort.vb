Imports System
Imports System.Threading.Tasks

Namespace Data_Structure_Final_Project
    Friend Class CocktailSort
        Public Shared Async Function Sort(array As Integer(), displayCallback As Action(Of Integer(), Integer, Integer)) As Task
            Dim n = array.Length
            Dim swapped As Boolean
            Do
                swapped = False

                ' Recorrido de izquierda a derecha
                For i = 0 To n - 1 - 1
                    If array(i) > array(i + 1) Then
                        displayCallback(array, i, i + 1)  ' Resaltamos los números que estamos intercambiando
                        Await Task.Delay(500)  ' Pausa para visualizar el intercambio

                        ' Intercambio
                        Dim temp = array(i)
                        array(i) = array(i + 1)
                        array(i + 1) = temp

                        swapped = True
                    End If
                Next

                ' Recorrido de derecha a izquierda
                For i = n - 2 To 0 Step -1
                    If array(i) > array(i + 1) Then
                        displayCallback(array, i, i + 1)  ' Resaltamos los números que estamos intercambiando
                        Await Task.Delay(500)  ' Pausa para visualizar el intercambio

                        ' Intercambio
                        Dim temp = array(i)
                        array(i) = array(i + 1)
                        array(i + 1) = temp

                        swapped = True
                    End If
                Next

                n -= 1  ' Reducir el tamaño de la zona no ordenada
            Loop While swapped

            displayCallback(array, -1, -1) ' Visualización final
        End Function
    End Class
End Namespace
