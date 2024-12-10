Namespace Data_Structure_Final_Project
    Partial Class ListsForm
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
            btnCount = New System.Windows.Forms.Button()
            btnContains = New System.Windows.Forms.Button()
            btnRemove = New System.Windows.Forms.Button()
            btnAdd = New System.Windows.Forms.Button()
            label5 = New System.Windows.Forms.Label()
            txtValue = New System.Windows.Forms.TextBox()
            lstSimpleLinkedList = New System.Windows.Forms.ListBox()
            cmbListType = New System.Windows.Forms.ComboBox()
            label1 = New System.Windows.Forms.Label()
            SuspendLayout()
            ' 
            ' btnCount
            ' 
            btnCount.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnCount.Location = New Drawing.Point(545, 128)
            btnCount.Name = "btnCount"
            btnCount.Size = New Drawing.Size(96, 42)
            btnCount.TabIndex = 13
            btnCount.Text = "Count"
            btnCount.UseVisualStyleBackColor = True
            AddHandler btnCount.Click, AddressOf btnCount_Click
            ' 
            ' btnContains
            ' 
            btnContains.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnContains.Location = New Drawing.Point(404, 128)
            btnContains.Name = "btnContains"
            btnContains.Size = New Drawing.Size(96, 42)
            btnContains.TabIndex = 12
            btnContains.Text = "Contains"
            btnContains.UseVisualStyleBackColor = True
            AddHandler btnContains.Click, AddressOf btnContains_Click
            ' 
            ' btnRemove
            ' 
            btnRemove.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnRemove.Location = New Drawing.Point(263, 128)
            btnRemove.Name = "btnRemove"
            btnRemove.Size = New Drawing.Size(96, 42)
            btnRemove.TabIndex = 11
            btnRemove.Text = "Remove"
            btnRemove.UseVisualStyleBackColor = True
            AddHandler btnRemove.Click, AddressOf btnRemove_Click
            ' 
            ' btnAdd
            ' 
            btnAdd.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnAdd.Location = New Drawing.Point(122, 128)
            btnAdd.Name = "btnAdd"
            btnAdd.Size = New Drawing.Size(96, 42)
            btnAdd.TabIndex = 10
            btnAdd.Text = "Add"
            btnAdd.UseVisualStyleBackColor = True
            AddHandler btnAdd.Click, AddressOf btnAdd_Click
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label5.Location = New Drawing.Point(197, 43)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(88, 22)
            label5.TabIndex = 9
            label5.Text = "Number:"
            ' 
            ' txtValue
            ' 
            txtValue.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            txtValue.Location = New Drawing.Point(183, 68)
            txtValue.Name = "txtValue"
            txtValue.Size = New Drawing.Size(119, 30)
            txtValue.TabIndex = 8
            ' 
            ' lstSimpleLinkedList
            ' 
            lstSimpleLinkedList.Font = New Drawing.Font("Swis721 Lt BT", 14.25F)
            lstSimpleLinkedList.FormattingEnabled = True
            lstSimpleLinkedList.ItemHeight = 22
            lstSimpleLinkedList.Location = New Drawing.Point(331, 205)
            lstSimpleLinkedList.Name = "lstSimpleLinkedList"
            lstSimpleLinkedList.Size = New Drawing.Size(122, 202)
            lstSimpleLinkedList.TabIndex = 0
            ' 
            ' cmbListType
            ' 
            cmbListType.FormattingEnabled = True
            cmbListType.Location = New Drawing.Point(353, 68)
            cmbListType.Name = "cmbListType"
            cmbListType.Size = New Drawing.Size(201, 23)
            cmbListType.TabIndex = 14
            AddHandler cmbListType.SelectedIndexChanged, AddressOf cmbListType_SelectedIndexChanged
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label1.Location = New Drawing.Point(367, 43)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(168, 22)
            label1.TabIndex = 15
            label1.Text = "Select type of list"
            ' 
            ' ListsForm
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(793, 449)
            Controls.Add(label1)
            Controls.Add(cmbListType)
            Controls.Add(btnCount)
            Controls.Add(btnContains)
            Controls.Add(btnRemove)
            Controls.Add(btnAdd)
            Controls.Add(label5)
            Controls.Add(txtValue)
            Controls.Add(lstSimpleLinkedList)
            Name = "ListsForm"
            Text = "ListsForms"
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region
        Private btnCount As System.Windows.Forms.Button
        Private btnContains As System.Windows.Forms.Button
        Private btnRemove As System.Windows.Forms.Button
        Private btnAdd As System.Windows.Forms.Button
        Private label5 As System.Windows.Forms.Label
        Private txtValue As System.Windows.Forms.TextBox
        Private lstSimpleLinkedList As System.Windows.Forms.ListBox
        Private cmbListType As System.Windows.Forms.ComboBox
        Private label1 As System.Windows.Forms.Label
    End Class
End Namespace
