Imports System
Imports System.Linq
Imports System.Threading.Tasks

Namespace Data_Structure_Final_Project
    Friend Class MergeAlgorithms
        Public Shared Async Function MergeSort(array As Integer(), left As Integer, right As Integer, displayCallback As Action(Of Integer(), String)) As Task
            If left < right Then
                Dim middle As Integer = (left + right) / 2

                ' Mostrar división
                                ''' Cannot convert InvocationExpressionSyntax, System.InvalidCastException: No se puede convertir un objeto de tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' al tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ArgumentListSyntax'.
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitInvocationExpression(InvocationExpressionSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''                 // Mostrar división
'''                 displayCallback(array[left..(right + 1)], $"División: {left} - {right}")
''' 

                ' Dividir de manera recursiva
                Await MergeSort(array, left, middle, displayCallback)
                Await MergeSort(array, middle + 1, right, displayCallback)

                ' Combinar los subarreglos
                Await Merge(array, left, middle, right, displayCallback)
            End If
        End Function

        ' Crear copias de las mitades
        Private Shared Async Function Merge(array As Integer(), left As Integer, middle As Integer, right As Integer, displayCallback As Action(Of Integer(), String)) As Task
                        ''' Cannot convert LocalDeclarationStatementSyntax, System.InvalidCastException: No se puede convertir un objeto de tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' al tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.RemodelVariableDeclaration(VariableDeclarationSyntax declaration)
'''    en ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
''' 
''' Input:
'''             // Crear copias de las mitades
'''             int[] leftArray = array[left..(middle + 1)];
''' 
''' 
                        ''' Cannot convert LocalDeclarationStatementSyntax, System.InvalidCastException: No se puede convertir un objeto de tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' al tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.RemodelVariableDeclaration(VariableDeclarationSyntax declaration)
'''    en ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
''' 
''' Input:
'''             int[] rightArray = array[(middle + 1)..(right + 1)];
''' 
''' 

            Dim i = 0, j = 0, k = left

            ' Combinar elementos en orden
            While i < leftArray.Length AndAlso j < rightArray.Length
                array(Math.Min(Threading.Interlocked.Increment(k), k - 1)) = If(leftArray(i) <= rightArray(j), leftArray(Math.Min(Threading.Interlocked.Increment(i), i - 1)), rightArray(Math.Min(Threading.Interlocked.Increment(j), j - 1)))
                Await Task.Delay(50) ' Pausa para simular paso visual
                displayCallback(array, "Actualizando mezcla...")
            End While

            ' Copiar elementos restantes
            While i < leftArray.Length
                array(Math.Min(Threading.Interlocked.Increment(k), k - 1)) = leftArray(Math.Min(Threading.Interlocked.Increment(i), i - 1))
                Await Task.Delay(50)
                displayCallback(array, "Agregando elementos restantes de la izquierda...")
            End While

            While j < rightArray.Length
                array(Math.Min(Threading.Interlocked.Increment(k), k - 1)) = rightArray(Math.Min(Threading.Interlocked.Increment(j), j - 1))
                Await Task.Delay(50)
                displayCallback(array, "Agregando elementos restantes de la derecha...")
            End While

                        ''' Cannot convert InvocationExpressionSyntax, System.InvalidCastException: No se puede convertir un objeto de tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' al tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ArgumentListSyntax'.
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitInvocationExpression(InvocationExpressionSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             displayCallback(array[left..(right + 1)], $"Merge completado: {left} - {right}")
''' 
        End Function


        Public Shared Async Function DirectMerge(array As Integer(), displayCallback As Action(Of Integer(), String)) As Task
            Dim n = array.Length ' Obtener el tamaño del arreglo
            Dim temp = New Integer(n - 1) {} ' Crear un arreglo temporal del mismo tamaño

            Dim width = 1

            While width < n
                displayCallback(array.ToArray(), "División con width = " & width.ToString())

                ' Iterar sobre los subarreglos de tamaño 2*width
                Dim i = 0

                While i < n
                    Dim left = i ' Índice inicial del subarreglo izquierdo
                    Dim middle = Math.Min(i + width, n) ' Índice del último elemento del subarreglo izquierdo
                    Dim right = Math.Min(i + 2 * width, n) ' Índice del último elemento del subarreglo derecho

                    Dim l = left, r = middle, k = left

                    ' Fusionar los subarreglos izquierdo y derecho en el arreglo temporal
                    While l < middle AndAlso r < right
                        temp(Math.Min(Threading.Interlocked.Increment(k), k - 1)) = If(array(l) <= array(r), array(Math.Min(Threading.Interlocked.Increment(l), l - 1)), array(Math.Min(Threading.Interlocked.Increment(r), r - 1)))
                    End While

                    While l < middle
                        temp(Math.Min(Threading.Interlocked.Increment(k), k - 1)) = array(Math.Min(Threading.Interlocked.Increment(l), l - 1))
                    End While

                    While r < right
                        temp(Math.Min(Threading.Interlocked.Increment(k), k - 1)) = array(Math.Min(Threading.Interlocked.Increment(r), r - 1))
                    End While

                    ' Copiar el arreglo temporal de vuelta al arreglo original
                    System.Array.Copy(temp, left, array, left, right - left)
                    i += 2 * width
                End While

                displayCallback(array.ToArray(), "Mezcla después de width = " & width.ToString())
                Await Task.Delay(200) ' Pausa para simular paso visual
                width *= 2
            End While
        End Function

        ' Natural Merge Sort
        Public Shared Async Function NaturalMerge(array As Integer(), displayCallback As Action(Of Integer(), String)) As Task
            Dim ordenado = False
            Dim temp = New Integer(array.Length - 1) {}

            While Not ordenado
                ordenado = True
                Dim i = 0
                displayCallback(array, "División en sub-secuencias")

                While i < array.Length
                    Dim start = i

                    ' Encuentra el final de la primera secuencia ordenada
                    While i < array.Length - 1 AndAlso array(i) <= array(i + 1)
                        i += 1
                    End While
                    i += 1

                    Dim j = i

                    ' Encuentra el final de la segunda secuencia ordenada
                    While i < array.Length - 1 AndAlso array(i) <= array(i + 1)
                        i += 1
                    End While
                    i += 1

                    If j < array.Length Then
                        MergeNatural(array, start, j, Math.Min(i, array.Length), temp)
                        ordenado = False
                    End If
                End While

                System.Array.Copy(temp, 0, array, 0, array.Length)

                displayCallback(array, "Mezcla completa")
                Await Task.Delay(200) ' Pausa para simular paso visual
            End While
        End Function

        ' Merge Natural Helper
        Private Shared Sub MergeNatural(array As Integer(), left As Integer, middle As Integer, right As Integer, temp As Integer())
            Dim i = left, j = middle, k = left
            While i < middle AndAlso j < right
                temp(Math.Min(Threading.Interlocked.Increment(k), k - 1)) = If(array(i) <= array(j), array(Math.Min(Threading.Interlocked.Increment(i), i - 1)), array(Math.Min(Threading.Interlocked.Increment(j), j - 1)))
            End While

            While i < middle
                temp(Math.Min(Threading.Interlocked.Increment(k), k - 1)) = array(Math.Min(Threading.Interlocked.Increment(i), i - 1))
            End While
            While j < right
                temp(Math.Min(Threading.Interlocked.Increment(k), k - 1)) = array(Math.Min(Threading.Interlocked.Increment(j), j - 1))
            End While
        End Sub
    End Class
End Namespace
