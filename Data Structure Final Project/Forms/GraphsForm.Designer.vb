
Namespace Data_Structure_Final_Project
    Partial Class GraphsForm
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
            btnAddNode = New System.Windows.Forms.Button()
            txtNode = New System.Windows.Forms.TextBox()
            txtFrom = New System.Windows.Forms.TextBox()
            txtTo = New System.Windows.Forms.TextBox()
            btnAddEdge = New System.Windows.Forms.Button()
            btnRemoveEdge = New System.Windows.Forms.Button()
            txtGraphRepresentation = New System.Windows.Forms.TextBox()
            txtWeight = New System.Windows.Forms.TextBox()
            chkDirected = New System.Windows.Forms.CheckBox()
            btnShowDFS = New System.Windows.Forms.Button()
            txtStartNode = New System.Windows.Forms.TextBox()
            btnRemoveNode = New System.Windows.Forms.Button()
            btnShowBFS = New System.Windows.Forms.Button()
            btnShowDFSRecursive = New System.Windows.Forms.Button()
            btnRemoveAll = New System.Windows.Forms.Button()
            label29 = New System.Windows.Forms.Label()
            label28 = New System.Windows.Forms.Label()
            label27 = New System.Windows.Forms.Label()
            label26 = New System.Windows.Forms.Label()
            label25 = New System.Windows.Forms.Label()
            label24 = New System.Windows.Forms.Label()
            label22 = New System.Windows.Forms.Label()
            label23 = New System.Windows.Forms.Label()
            SuspendLayout()
            ' 
            ' btnAddNode
            ' 
            btnAddNode.Location = New Drawing.Point(171, 88)
            btnAddNode.Name = "btnAddNode"
            btnAddNode.Size = New Drawing.Size(75, 23)
            btnAddNode.TabIndex = 1
            btnAddNode.Text = "Add Node"
            btnAddNode.UseVisualStyleBackColor = True
            AddHandler btnAddNode.Click, AddressOf btnAddNode_Click
            ' 
            ' txtNode
            ' 
            txtNode.Location = New Drawing.Point(161, 55)
            txtNode.Name = "txtNode"
            txtNode.Size = New Drawing.Size(180, 23)
            txtNode.TabIndex = 2
            ' 
            ' txtFrom
            ' 
            txtFrom.Location = New Drawing.Point(152, 185)
            txtFrom.Name = "txtFrom"
            txtFrom.Size = New Drawing.Size(104, 23)
            txtFrom.TabIndex = 4
            ' 
            ' txtTo
            ' 
            txtTo.Location = New Drawing.Point(152, 223)
            txtTo.Name = "txtTo"
            txtTo.Size = New Drawing.Size(104, 23)
            txtTo.TabIndex = 6
            ' 
            ' btnAddEdge
            ' 
            btnAddEdge.Location = New Drawing.Point(289, 185)
            btnAddEdge.Name = "btnAddEdge"
            btnAddEdge.Size = New Drawing.Size(75, 23)
            btnAddEdge.TabIndex = 8
            btnAddEdge.Text = "Add Edge"
            btnAddEdge.UseVisualStyleBackColor = True
            AddHandler btnAddEdge.Click, AddressOf btnAddEdge_Click
            ' 
            ' btnRemoveEdge
            ' 
            btnRemoveEdge.Location = New Drawing.Point(289, 223)
            btnRemoveEdge.Name = "btnRemoveEdge"
            btnRemoveEdge.Size = New Drawing.Size(75, 39)
            btnRemoveEdge.TabIndex = 9
            btnRemoveEdge.Text = "Remove Edge"
            btnRemoveEdge.UseVisualStyleBackColor = True
            AddHandler btnRemoveEdge.Click, AddressOf btnRemoveEdge_Click
            ' 
            ' txtGraphRepresentation
            ' 
            txtGraphRepresentation.Font = New Drawing.Font("Microsoft Sans Serif", 14F)
            txtGraphRepresentation.Location = New Drawing.Point(512, 70)
            txtGraphRepresentation.Multiline = True
            txtGraphRepresentation.Name = "txtGraphRepresentation"
            txtGraphRepresentation.Size = New Drawing.Size(362, 303)
            txtGraphRepresentation.TabIndex = 12
            ' 
            ' txtWeight
            ' 
            txtWeight.Location = New Drawing.Point(152, 257)
            txtWeight.Name = "txtWeight"
            txtWeight.Size = New Drawing.Size(104, 23)
            txtWeight.TabIndex = 13
            ' 
            ' chkDirected
            ' 
            chkDirected.AutoSize = True
            chkDirected.Location = New Drawing.Point(152, 286)
            chkDirected.Name = "chkDirected"
            chkDirected.Size = New Drawing.Size(70, 19)
            chkDirected.TabIndex = 15
            chkDirected.Text = "Directed"
            chkDirected.UseVisualStyleBackColor = True
            ' 
            ' btnShowDFS
            ' 
            btnShowDFS.Location = New Drawing.Point(160, 415)
            btnShowDFS.Name = "btnShowDFS"
            btnShowDFS.Size = New Drawing.Size(75, 39)
            btnShowDFS.TabIndex = 16
            btnShowDFS.Text = "Show DFS Algorithm"
            btnShowDFS.UseVisualStyleBackColor = True
            AddHandler btnShowDFS.Click, AddressOf btnShowDFS_Click
            ' 
            ' txtStartNode
            ' 
            txtStartNode.Location = New Drawing.Point(183, 386)
            txtStartNode.Name = "txtStartNode"
            txtStartNode.Size = New Drawing.Size(104, 23)
            txtStartNode.TabIndex = 17
            ' 
            ' btnRemoveNode
            ' 
            btnRemoveNode.Location = New Drawing.Point(266, 88)
            btnRemoveNode.Name = "btnRemoveNode"
            btnRemoveNode.Size = New Drawing.Size(75, 23)
            btnRemoveNode.TabIndex = 20
            btnRemoveNode.Text = "Remove"
            btnRemoveNode.UseVisualStyleBackColor = True
            AddHandler btnRemoveNode.Click, AddressOf btnRemoveNode_Click
            ' 
            ' btnShowBFS
            ' 
            btnShowBFS.Location = New Drawing.Point(79, 415)
            btnShowBFS.Name = "btnShowBFS"
            btnShowBFS.Size = New Drawing.Size(75, 39)
            btnShowBFS.TabIndex = 21
            btnShowBFS.Text = "Show BFS Algorithm"
            btnShowBFS.UseVisualStyleBackColor = True
            AddHandler btnShowBFS.Click, AddressOf btnShowBFS_Click
            ' 
            ' btnShowDFSRecursive
            ' 
            btnShowDFSRecursive.Location = New Drawing.Point(241, 415)
            btnShowDFSRecursive.Name = "btnShowDFSRecursive"
            btnShowDFSRecursive.Size = New Drawing.Size(75, 39)
            btnShowDFSRecursive.TabIndex = 23
            btnShowDFSRecursive.Text = "Show DFS Recursive Algorithm"
            btnShowDFSRecursive.UseVisualStyleBackColor = True
            AddHandler btnShowDFSRecursive.Click, AddressOf btnShowDFSRecursive_Click
            ' 
            ' btnRemoveAll
            ' 
            btnRemoveAll.Location = New Drawing.Point(512, 41)
            btnRemoveAll.Name = "btnRemoveAll"
            btnRemoveAll.Size = New Drawing.Size(84, 23)
            btnRemoveAll.TabIndex = 24
            btnRemoveAll.Text = "Remove All"
            btnRemoveAll.UseVisualStyleBackColor = True
            AddHandler btnRemoveAll.Click, AddressOf btnRemoveAll_Click
            ' 
            ' label29
            ' 
            label29.AutoSize = True
            label29.Font = New Drawing.Font("Swis721 Lt BT", 15F, Drawing.FontStyle.Bold)
            label29.Location = New Drawing.Point(147, 349)
            label29.Name = "label29"
            label29.Size = New Drawing.Size(109, 24)
            label29.TabIndex = 32
            label29.Text = "Traversals"
            ' 
            ' label28
            ' 
            label28.AutoSize = True
            label28.Font = New Drawing.Font("Swis721 Lt BT", 15F, Drawing.FontStyle.Bold)
            label28.Location = New Drawing.Point(161, 146)
            label28.Name = "label28"
            label28.Size = New Drawing.Size(72, 24)
            label28.TabIndex = 31
            label28.Text = "Edges"
            ' 
            ' label27
            ' 
            label27.AutoSize = True
            label27.Font = New Drawing.Font("Swis721 Lt BT", 15F, Drawing.FontStyle.Bold)
            label27.Location = New Drawing.Point(171, 18)
            label27.Name = "label27"
            label27.Size = New Drawing.Size(73, 24)
            label27.TabIndex = 30
            label27.Text = "Nodes"
            ' 
            ' label26
            ' 
            label26.AutoSize = True
            label26.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label26.Location = New Drawing.Point(82, 388)
            label26.Name = "label26"
            label26.Size = New Drawing.Size(98, 19)
            label26.TabIndex = 29
            label26.Text = "Node Start:"
            ' 
            ' label25
            ' 
            label25.AutoSize = True
            label25.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label25.Location = New Drawing.Point(80, 257)
            label25.Name = "label25"
            label25.Size = New Drawing.Size(68, 19)
            label25.TabIndex = 28
            label25.Text = "Weight:"
            ' 
            ' label24
            ' 
            label24.AutoSize = True
            label24.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label24.Location = New Drawing.Point(67, 223)
            label24.Name = "label24"
            label24.Size = New Drawing.Size(81, 19)
            label24.TabIndex = 27
            label24.Text = "Node To:"
            ' 
            ' label22
            ' 
            label22.AutoSize = True
            label22.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label22.Location = New Drawing.Point(47, 185)
            label22.Name = "label22"
            label22.Size = New Drawing.Size(101, 19)
            label22.TabIndex = 26
            label22.Text = "Node From:"
            ' 
            ' label23
            ' 
            label23.AutoSize = True
            label23.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label23.Location = New Drawing.Point(49, 55)
            label23.Name = "label23"
            label23.Size = New Drawing.Size(106, 19)
            label23.TabIndex = 25
            label23.Text = "Node Name:"
            ' 
            ' GraphsForm
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(889, 466)
            Controls.Add(btnAddNode)
            Controls.Add(txtNode)
            Controls.Add(txtFrom)
            Controls.Add(txtTo)
            Controls.Add(btnAddEdge)
            Controls.Add(btnRemoveEdge)
            Controls.Add(txtGraphRepresentation)
            Controls.Add(txtWeight)
            Controls.Add(chkDirected)
            Controls.Add(btnShowDFS)
            Controls.Add(txtStartNode)
            Controls.Add(btnRemoveNode)
            Controls.Add(btnShowBFS)
            Controls.Add(btnShowDFSRecursive)
            Controls.Add(btnRemoveAll)
            Controls.Add(label29)
            Controls.Add(label28)
            Controls.Add(label27)
            Controls.Add(label26)
            Controls.Add(label25)
            Controls.Add(label24)
            Controls.Add(label22)
            Controls.Add(label23)
            Name = "GraphsForm"
            Text = "GraphsForm"
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region
        Private btnAddNode As System.Windows.Forms.Button
        Private txtNode As System.Windows.Forms.TextBox
        Private txtFrom As System.Windows.Forms.TextBox
        Private txtTo As System.Windows.Forms.TextBox
        Private btnAddEdge As System.Windows.Forms.Button
        Private btnRemoveEdge As System.Windows.Forms.Button
        Private txtGraphRepresentation As System.Windows.Forms.TextBox
        Private txtWeight As System.Windows.Forms.TextBox
        Private chkDirected As System.Windows.Forms.CheckBox
        Private btnShowDFS As System.Windows.Forms.Button
        Private txtStartNode As System.Windows.Forms.TextBox
        Private btnRemoveNode As System.Windows.Forms.Button
        Private btnShowBFS As System.Windows.Forms.Button
        Private btnShowDFSRecursive As System.Windows.Forms.Button
        Private btnRemoveAll As System.Windows.Forms.Button
        Private label29 As System.Windows.Forms.Label
        Private label28 As System.Windows.Forms.Label
        Private label27 As System.Windows.Forms.Label
        Private label26 As System.Windows.Forms.Label
        Private label25 As System.Windows.Forms.Label
        Private label24 As System.Windows.Forms.Label
        Private label22 As System.Windows.Forms.Label
        Private label23 As System.Windows.Forms.Label


    End Class
End Namespace
