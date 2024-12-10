Namespace Data_Structure_Final_Project
    Partial Class AlgorithmsForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            lstNumbersSort = New System.Windows.Forms.ListBox()
            cmbAlgoritms = New System.Windows.Forms.ComboBox()
            btnSort = New System.Windows.Forms.Button()
            btnSetNumbers = New System.Windows.Forms.Button()
            SuspendLayout()
            ' 
            ' lstNumbersSort
            ' 
            lstNumbersSort.Font = New Drawing.Font("Segoe UI", 14F)
            lstNumbersSort.FormattingEnabled = True
            lstNumbersSort.ItemHeight = 25
            lstNumbersSort.Location = New Drawing.Point(24, 97)
            lstNumbersSort.Name = "lstNumbersSort"
            lstNumbersSort.Size = New Drawing.Size(454, 354)
            lstNumbersSort.TabIndex = 26
            ' 
            ' cmbAlgoritms
            ' 
            cmbAlgoritms.FormattingEnabled = True
            cmbAlgoritms.Location = New Drawing.Point(24, 32)
            cmbAlgoritms.Name = "cmbAlgoritms"
            cmbAlgoritms.Size = New Drawing.Size(180, 23)
            cmbAlgoritms.TabIndex = 25
            ' 
            ' btnSort
            ' 
            btnSort.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnSort.Location = New Drawing.Point(449, 20)
            btnSort.Name = "btnSort"
            btnSort.Size = New Drawing.Size(180, 42)
            btnSort.TabIndex = 24
            btnSort.Text = "Sort"
            btnSort.UseVisualStyleBackColor = True
            AddHandler btnSort.Click, AddressOf btnSort_Click
            ' 
            ' btnSetNumbers
            ' 
            btnSetNumbers.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnSetNumbers.Location = New Drawing.Point(260, 20)
            btnSetNumbers.Name = "btnSetNumbers"
            btnSetNumbers.Size = New Drawing.Size(171, 42)
            btnSetNumbers.TabIndex = 23
            btnSetNumbers.Text = "Generate Numbers"
            btnSetNumbers.UseVisualStyleBackColor = True
            AddHandler btnSetNumbers.Click, AddressOf btnSetNumbers_Click
            ' 
            ' AlgorithmsForm
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(800, 471)
            Controls.Add(lstNumbersSort)
            Controls.Add(cmbAlgoritms)
            Controls.Add(btnSort)
            Controls.Add(btnSetNumbers)
            Name = "AlgorithmsForm"
            Text = "AlgorithmsForm"
            ResumeLayout(False)
        End Sub

#End Region
        Private lstNumbersSort As System.Windows.Forms.ListBox
        Private cmbAlgoritms As System.Windows.Forms.ComboBox
        Private btnSort As System.Windows.Forms.Button
        Private btnSetNumbers As System.Windows.Forms.Button

    End Class
End Namespace
