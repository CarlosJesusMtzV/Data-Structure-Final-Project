Imports System.Windows.Forms

Namespace Data_Structure_Final_Project
    Partial Class TreesForm
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
            label30 = New Label()
            txtOutput = New TextBox()
            btnSearch = New Button()
            btnClear = New Button()
            btnInOrder = New Button()
            btnDelete = New Button()
            btnPostOrder = New Button()
            btnPreOrder = New Button()
            btnInsertNode = New Button()
            txtNodeValue = New TextBox()
            panelTree = New Panel()
            SuspendLayout()
            ' 
            ' label30
            ' 
            label30.AutoSize = True
            label30.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label30.Location = New Drawing.Point(22, 13)
            label30.Name = "label30"
            label30.Size = New Drawing.Size(121, 22)
            label30.TabIndex = 51
            label30.Text = "Node Value:"
            ' 
            ' txtOutput
            ' 
            txtOutput.Font = New Drawing.Font("Segoe UI", 14F)
            txtOutput.Location = New Drawing.Point(22, 153)
            txtOutput.Multiline = True
            txtOutput.Name = "txtOutput"
            txtOutput.Size = New Drawing.Size(381, 39)
            txtOutput.TabIndex = 50
            ' 
            ' btnSearch
            ' 
            btnSearch.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnSearch.Location = New Drawing.Point(389, 29)
            btnSearch.Name = "btnSearch"
            btnSearch.Size = New Drawing.Size(83, 42)
            btnSearch.TabIndex = 49
            btnSearch.Text = "Search"
            btnSearch.UseVisualStyleBackColor = True
            AddHandler btnSearch.Click, AddressOf btnSearch_Click
            ' 
            ' btnClear
            ' 
            btnClear.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnClear.Location = New Drawing.Point(422, 96)
            btnClear.Name = "btnClear"
            btnClear.Size = New Drawing.Size(138, 42)
            btnClear.TabIndex = 48
            btnClear.Text = "Clear Tree"
            btnClear.UseVisualStyleBackColor = True
            AddHandler btnClear.Click, AddressOf btnClear_Click
            ' 
            ' btnInOrder
            ' 
            btnInOrder.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnInOrder.Location = New Drawing.Point(278, 96)
            btnInOrder.Name = "btnInOrder"
            btnInOrder.Size = New Drawing.Size(108, 42)
            btnInOrder.TabIndex = 47
            btnInOrder.Text = "In Order"
            btnInOrder.UseVisualStyleBackColor = True
            AddHandler btnInOrder.Click, AddressOf btnInOrder_Click
            ' 
            ' btnDelete
            ' 
            btnDelete.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnDelete.Location = New Drawing.Point(281, 29)
            btnDelete.Name = "btnDelete"
            btnDelete.Size = New Drawing.Size(83, 42)
            btnDelete.TabIndex = 46
            btnDelete.Text = "Delete"
            btnDelete.UseVisualStyleBackColor = True
            AddHandler btnDelete.Click, AddressOf btnDelete_Click
            ' 
            ' btnPostOrder
            ' 
            btnPostOrder.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnPostOrder.Location = New Drawing.Point(154, 96)
            btnPostOrder.Name = "btnPostOrder"
            btnPostOrder.Size = New Drawing.Size(108, 42)
            btnPostOrder.TabIndex = 45
            btnPostOrder.Text = "Post Order"
            btnPostOrder.UseVisualStyleBackColor = True
            AddHandler btnPostOrder.Click, AddressOf btnPostOrder_Click
            ' 
            ' btnPreOrder
            ' 
            btnPreOrder.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnPreOrder.Location = New Drawing.Point(30, 96)
            btnPreOrder.Name = "btnPreOrder"
            btnPreOrder.Size = New Drawing.Size(108, 42)
            btnPreOrder.TabIndex = 44
            btnPreOrder.Text = "Pre Order"
            btnPreOrder.UseVisualStyleBackColor = True
            AddHandler btnPreOrder.Click, AddressOf btnPreOrder_Click
            ' 
            ' btnInsertNode
            ' 
            btnInsertNode.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnInsertNode.Location = New Drawing.Point(173, 29)
            btnInsertNode.Name = "btnInsertNode"
            btnInsertNode.Size = New Drawing.Size(83, 42)
            btnInsertNode.TabIndex = 43
            btnInsertNode.Text = "Insert"
            btnInsertNode.UseVisualStyleBackColor = True
            AddHandler btnInsertNode.Click, AddressOf btnInsertNode_Click
            ' 
            ' txtNodeValue
            ' 
            txtNodeValue.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            txtNodeValue.Location = New Drawing.Point(22, 41)
            txtNodeValue.Name = "txtNodeValue"
            txtNodeValue.Size = New Drawing.Size(119, 30)
            txtNodeValue.TabIndex = 21
            ' 
            ' panelTree
            ' 
            panelTree.Location = New Drawing.Point(12, 211)
            panelTree.Name = "panelTree"
            panelTree.Size = New Drawing.Size(625, 319)
            panelTree.TabIndex = 0
            ' 
            ' TreesForm
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Drawing.Size(643, 531)
            Controls.Add(label30)
            Controls.Add(txtOutput)
            Controls.Add(btnSearch)
            Controls.Add(btnClear)
            Controls.Add(btnInOrder)
            Controls.Add(btnDelete)
            Controls.Add(btnPostOrder)
            Controls.Add(btnPreOrder)
            Controls.Add(btnInsertNode)
            Controls.Add(txtNodeValue)
            Controls.Add(panelTree)
            Name = "TreesForm"
            Text = "TreesForm"
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region
        Private label30 As Label
        Private txtOutput As TextBox
        Private btnSearch As Button
        Private btnClear As Button
        Private btnInOrder As Button
        Private btnInsertNode As Button
        Private btnPostOrder As Button
        Private btnPreOrder As Button
        Private txtNodeValue As TextBox
        Private panelTree As Panel
        Private btnDelete As Button
    End Class
End Namespace
