Imports System
Imports System.Linq
Imports System.Threading.Tasks

Namespace Data_Structure_Final_Project
    Friend Class PigeonHoleSort
        Public Shared Async Function Sort(array As Integer(), casillasDisplayCallback As Action(Of Integer(), String), sortedDisplayCallback As Action(Of Integer(), String)) As Task
            ' Paso 1: Encontrar el valor mínimo y máximo
            Dim min As Integer = array.Min()
            Dim max As Integer = array.Max()
            Dim range = max - min + 1

            ' Crear un arreglo de casillas
            Dim holes = New Integer(range - 1) {}

            ' Paso 2: Asignar los elementos a las casillas
            For Each num In array
                holes(num - min) += 1  ' Incrementa el contador para la casilla correspondiente

                ' Mostrar cómo se va acomodando el número en su casilla
                casillasDisplayCallback(holes, $"Asignando {num} a la casilla {num - min}")
                Await Task.Delay(500) ' Pausa para mostrar el proceso
            Next

            ' Mostrar la distribución final de las casillas
            casillasDisplayCallback(holes, "Distribución final de las casillas: " & String.Join(", ", holes))

            ' Paso 3: Recoger los elementos de las casillas en orden
            Dim index = 0
            For i = 0 To range - 1
                While Math.Max(Threading.Interlocked.Decrement(holes(i)), holes(i) + 1) > 0
                    array(Math.Min(Threading.Interlocked.Increment(index), index - 1)) = i + min

                    ' Mostrar cómo se recogen los elementos y se van acomodando
                    sortedDisplayCallback(array, $"Recogiendo {i + min} de la casilla {i}...")
                    Await Task.Delay(500) ' Pausa para mostrar el proceso
                End While
            Next

            sortedDisplayCallback(array, "Ordenamiento completado")
        End Function
    End Class
End Namespace
