Namespace Data_Structure_Final_Project
    Partial Class Form1
        ''' <summary>
        '''  Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        '''  Clean up any resources being used.
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
        '''  Required method for Designer support - do not modify
        '''  the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            lBoxOptions = New System.Windows.Forms.ListBox()
            lblTitle = New System.Windows.Forms.Label()
            lblselectoption = New System.Windows.Forms.Label()
            SuspendLayout()
            ' 
            ' lBoxOptions
            ' 
            lBoxOptions.BorderStyle = System.Windows.Forms.BorderStyle.None
            lBoxOptions.FormattingEnabled = True
            lBoxOptions.ItemHeight = 15
            lBoxOptions.Items.AddRange(New Object() {"     Lists", "     Stacks", "    Queues", "  Binary Trees", "    Graphs", " Algorithms"})
            lBoxOptions.Location = New Drawing.Point(115, 108)
            lBoxOptions.Name = "lBoxOptions"
            lBoxOptions.Size = New Drawing.Size(83, 165)
            lBoxOptions.TabIndex = 0
            AddHandler lBoxOptions.SelectedIndexChanged, AddressOf lBoxOptions_SelectedIndexChanged
            ' 
            ' lblTitle
            ' 
            lblTitle.AutoSize = True
            lblTitle.Font = New Drawing.Font("Microsoft Sans Serif", 27.7499962F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            lblTitle.Location = New Drawing.Point(37, 25)
            lblTitle.Name = "lblTitle"
            lblTitle.Size = New Drawing.Size(249, 42)
            lblTitle.TabIndex = 1
            lblTitle.Text = "Final Proyect"
            ' 
            ' lblselectoption
            ' 
            lblselectoption.AutoSize = True
            lblselectoption.Font = New Drawing.Font("Verdana", 11.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            lblselectoption.ForeColor = Drawing.Color.Blue
            lblselectoption.Location = New Drawing.Point(97, 77)
            lblselectoption.Name = "lblselectoption"
            lblselectoption.Size = New Drawing.Size(131, 18)
            lblselectoption.TabIndex = 2
            lblselectoption.Text = "Select An Option"
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(324, 354)
            Controls.Add(lblselectoption)
            Controls.Add(lblTitle)
            Controls.Add(lBoxOptions)
            Name = "Form1"
            Text = "Form1"
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region
        Private lBoxOptions As System.Windows.Forms.ListBox
        Private lblTitle As System.Windows.Forms.Label
        Private lblselectoption As System.Windows.Forms.Label
    End Class
End Namespace
