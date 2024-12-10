Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks

Namespace Data_Structure_Final_Project
    Friend Class BucketSort
        Public Shared Async Function Sort(array As Integer(), displayCallback As Action(Of Integer(), String)) As Task
            Dim n = array.Length
            If n <= 1 Then Return

            Dim minValue As Integer = array.Min()
            Dim maxValue As Integer = array.Max()
            Dim bucketCount = n

            ' Crear los "buckets" vacíos
            Dim buckets As List(Of Integer()) = New List(Of Integer())(bucketCount)
            For i = 0 To bucketCount - 1
                buckets.Add(New Integer(-1) {})
            Next

            ' Distribuir los elementos en los "buckets"
            displayCallback(array, "Distribuyendo los elementos en los buckets...")
            For i = 0 To n - 1
                Dim bucketIndex As Integer = (array(i) - minValue) * (bucketCount - 1) / (maxValue - minValue)
                buckets(bucketIndex) = buckets(bucketIndex).Concat(New Integer() {array(i)}).ToArray()
            Next

            ' Mostrar los buckets con su rango, incluyendo los vacíos
            For i = 0 To bucketCount - 1
                If buckets(i).Length > 0 Then
                    Dim bucketMin As Integer = buckets(i).Min()
                    Dim bucketMax As Integer = buckets(i).Max()
                    displayCallback(buckets(i), $"Bucket {i + 1}: Rango: [{bucketMin}, {bucketMax}] - Elementos: {String.Join(", ", buckets(i))}")
                Else
                    displayCallback(New Integer(-1) {}, $"Bucket {i + 1}: Vacío")
                End If
            Next

            ' Ordenar los "buckets" individualmente usando InsertionSort
            For i = 0 To bucketCount - 1
                Await InsertionSort(buckets(i), displayCallback)
            Next

            ' Concatenar los resultados
            Dim index = 0
            For Each bucket In buckets
                For Each item In bucket
                    array(Math.Min(Threading.Interlocked.Increment(index), index - 1)) = item
                Next
            Next

            ' Mostrar el arreglo final
            displayCallback(array, "Arreglo final ordenado: " & String.Join(", ", array))
        End Function

        ' Método InsertionSort para ordenar cada bucket
        Private Shared Async Function InsertionSort(array As Integer(), displayCallback As Action(Of Integer(), String)) As Task
            Dim n = array.Length
            For i = 1 To n - 1
                Dim key = array(i)
                Dim j = i - 1
                While j >= 0 AndAlso array(j) > key
                    array(j + 1) = array(j)
                    j -= 1
                End While
                array(j + 1) = key

                ' Mostrar el arreglo después de cada paso de InsertionSort
                displayCallback(array, "Paso de InsertionSort: " & String.Join(", ", array))
                Await Task.Delay(500) ' Añadir una pequeña demora para visualizar los pasos
            Next
        End Function
    End Class
End Namespace
