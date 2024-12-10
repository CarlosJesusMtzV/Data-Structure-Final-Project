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
            lBoxOptions.Items.AddRange(New Object() {"     Lists", "     Stacks", "    Queues", "  Binary Trees", "    Graphs", " Algorithms"})
            lBoxOptions.Location = New System.Drawing.Point(131, 144)
            lBoxOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            lBoxOptions.Name = "lBoxOptions"
            lBoxOptions.Size = New System.Drawing.Size(285, 140)
            lBoxOptions.TabIndex = 0
            ' 
            ' lblTitle
            ' 
            lblTitle.AutoSize = True
            lblTitle.Font = New System.Drawing.Font("Modern No. 20", 36F, Drawing.FontStyle.Bold Or Drawing.FontStyle.Italic, Drawing.GraphicsUnit.Point, CByte(0))
            lblTitle.Location = New System.Drawing.Point(219, 9)
            lblTitle.Name = "lblTitle"
            lblTitle.Size = New System.Drawing.Size(374, 62)
            lblTitle.TabIndex = 1
            lblTitle.Text = "Final Proyect"
            ' 
            ' lblselectoption
            ' 
            lblselectoption.AutoSize = True
            lblselectoption.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
            lblselectoption.ForeColor = Drawing.SystemColors.ActiveCaptionText
            lblselectoption.Location = New System.Drawing.Point(108, 97)
            lblselectoption.Name = "lblselectoption"
            lblselectoption.Size = New System.Drawing.Size(369, 31)
            lblselectoption.TabIndex = 2
            lblselectoption.Text = "Estructuras de datos y Algoritmos"
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(8F, 20F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.SystemColors.ActiveCaption
            ClientSize = New System.Drawing.Size(1003, 463)
            Controls.Add(lblselectoption)
            Controls.Add(lblTitle)
            Controls.Add(lBoxOptions)
            Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
