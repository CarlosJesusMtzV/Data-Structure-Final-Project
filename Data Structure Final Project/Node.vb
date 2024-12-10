
Namespace Data_Structure_Final_Project
    Friend Class Node
        Public Property Value As Integer
        Public Property [Next] As Node?
        Public Sub New()
            Value = 0
            [Next] = Nothing
        End Sub
        Public Sub New(value As Integer)
            Me.Value = value
            [Next] = Nothing
        End Sub
    End Class
End Namespace
