Imports System.Windows.Forms

Namespace Data_Structure_Final_Project
    Partial Class StacksForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

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
            btnSize = New Button()
            btnPeek = New Button()
            btnPop = New Button()
            btnPush = New Button()
            label8 = New Label()
            txtStackValue = New TextBox()
            lstStaticStack = New ListBox()
            cmbStackType = New ComboBox()
            SuspendLayout()
            ' 
            ' btnSize
            ' 
            btnSize.Font = New Drawing.Font("Microsoft Sans Serif", 12F, Drawing.FontStyle.Bold)
            btnSize.Location = New Drawing.Point(434, 90)
            btnSize.Name = "btnSize"
            btnSize.Size = New Drawing.Size(96, 42)
            btnSize.TabIndex = 15
            btnSize.Text = "Size"
            btnSize.UseVisualStyleBackColor = True
            AddHandler btnSize.Click, AddressOf btnSize_Click
            ' 
            ' btnPeek
            ' 
            btnPeek.Font = New Drawing.Font("Microsoft Sans Serif", 12F, Drawing.FontStyle.Bold)
            btnPeek.Location = New Drawing.Point(296, 90)
            btnPeek.Name = "btnPeek"
            btnPeek.Size = New Drawing.Size(96, 42)
            btnPeek.TabIndex = 14
            btnPeek.Text = "Peek"
            btnPeek.UseVisualStyleBackColor = True
            AddHandler btnPeek.Click, AddressOf btnPeek_Click
            ' 
            ' btnPop
            ' 
            btnPop.Font = New Drawing.Font("Microsoft Sans Serif", 12F, Drawing.FontStyle.Bold)
            btnPop.Location = New Drawing.Point(158, 90)
            btnPop.Name = "btnPop"
            btnPop.Size = New Drawing.Size(96, 42)
            btnPop.TabIndex = 13
            btnPop.Text = "Pop"
            btnPop.UseVisualStyleBackColor = True
            AddHandler btnPop.Click, AddressOf btnPop_Click
            ' 
            ' btnPush
            ' 
            btnPush.Font = New Drawing.Font("Microsoft Sans Serif", 12F, Drawing.FontStyle.Bold)
            btnPush.Location = New Drawing.Point(20, 90)
            btnPush.Name = "btnPush"
            btnPush.Size = New Drawing.Size(96, 42)
            btnPush.TabIndex = 12
            btnPush.Text = "Push"
            btnPush.UseVisualStyleBackColor = True
            AddHandler btnPush.Click, AddressOf btnPush_Click
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.Font = New Drawing.Font("Microsoft Sans Serif", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label8.Location = New Drawing.Point(215, 14)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(91, 24)
            label8.TabIndex = 11
            label8.Text = "Number:"
            ' 
            ' txtStackValue
            ' 
            txtStackValue.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            txtStackValue.Location = New Drawing.Point(204, 41)
            txtStackValue.Name = "txtStackValue"
            txtStackValue.Size = New Drawing.Size(119, 30)
            txtStackValue.TabIndex = 10
            ' 
            ' lstStaticStack
            ' 
            lstStaticStack.Font = New Drawing.Font("Microsoft Sans Serif", 14.25F)
            lstStaticStack.FormattingEnabled = True
            lstStaticStack.ItemHeight = 24
            lstStaticStack.Location = New Drawing.Point(204, 170)
            lstStaticStack.Name = "lstStaticStack"
            lstStaticStack.Size = New Drawing.Size(119, 268)
            lstStaticStack.TabIndex = 2
            ' 
            ' cmbStackType
            ' 
            cmbStackType.FormattingEnabled = True
            cmbStackType.Items.AddRange(New Object() {"Static", "Dynamic"})
            cmbStackType.Location = New Drawing.Point(339, 41)
            cmbStackType.Name = "cmbStackType"
            cmbStackType.Size = New Drawing.Size(121, 23)
            cmbStackType.TabIndex = 16
            AddHandler cmbStackType.SelectedIndexChanged, AddressOf cmbStackType_SelectedIndexChanged
            ' 
            ' StacksForm
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Drawing.Size(557, 450)
            Controls.Add(cmbStackType)
            Controls.Add(btnSize)
            Controls.Add(btnPeek)
            Controls.Add(btnPop)
            Controls.Add(btnPush)
            Controls.Add(label8)
            Controls.Add(txtStackValue)
            Controls.Add(lstStaticStack)
            Name = "StacksForm"
            Text = "StacksForm"
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region
        Private btnSize As Button
        Private btnPeek As Button
        Private btnPop As Button
        Private btnPush As Button
        Private label8 As Label
        Private txtStackValue As TextBox
        Private lstStaticStack As ListBox
        Private cmbStackType As ComboBox
    End Class
End Namespace
