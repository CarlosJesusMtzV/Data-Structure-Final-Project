Namespace Data_Structure_Final_Project
    Partial Class QueuesForm
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
            label5 = New System.Windows.Forms.Label()
            txtValue = New System.Windows.Forms.TextBox()
            tabControl1 = New System.Windows.Forms.TabControl()
            tabPage1 = New System.Windows.Forms.TabPage()
            lstQueues = New System.Windows.Forms.ListBox()
            label2 = New System.Windows.Forms.Label()
            cmbQueueType = New System.Windows.Forms.ComboBox()
            btnQueueSize = New System.Windows.Forms.Button()
            btnQueuePeek = New System.Windows.Forms.Button()
            btnDequeue = New System.Windows.Forms.Button()
            btnEnqueue = New System.Windows.Forms.Button()
            label1 = New System.Windows.Forms.Label()
            txtQueueValue = New System.Windows.Forms.TextBox()
            tabPage2 = New System.Windows.Forms.TabPage()
            lstDoubleQueues = New System.Windows.Forms.ListBox()
            btnDoubleQSize = New System.Windows.Forms.Button()
            btnGetRear = New System.Windows.Forms.Button()
            btnGetFront = New System.Windows.Forms.Button()
            btnDeleteRear = New System.Windows.Forms.Button()
            btnDeleteFront = New System.Windows.Forms.Button()
            btnInsertRear = New System.Windows.Forms.Button()
            btnInserFront = New System.Windows.Forms.Button()
            label3 = New System.Windows.Forms.Label()
            cmbDQType = New System.Windows.Forms.ComboBox()
            label4 = New System.Windows.Forms.Label()
            txtDQValue = New System.Windows.Forms.TextBox()
            tabPage3 = New System.Windows.Forms.TabPage()
            label8 = New System.Windows.Forms.Label()
            txtPriority = New System.Windows.Forms.TextBox()
            btnSizePQ = New System.Windows.Forms.Button()
            btnPeekPQ = New System.Windows.Forms.Button()
            btnDequeuePQ = New System.Windows.Forms.Button()
            btnEnqueuePQ = New System.Windows.Forms.Button()
            lstPQ = New System.Windows.Forms.ListBox()
            label6 = New System.Windows.Forms.Label()
            cmbTypeOfPQ = New System.Windows.Forms.ComboBox()
            label7 = New System.Windows.Forms.Label()
            txtValuePQ = New System.Windows.Forms.TextBox()
            tabControl1.SuspendLayout()
            tabPage1.SuspendLayout()
            tabPage2.SuspendLayout()
            tabPage3.SuspendLayout()
            SuspendLayout()
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label5.Location = New Drawing.Point(60, 26)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(88, 22)
            label5.TabIndex = 11
            label5.Text = "Number:"
            ' 
            ' txtValue
            ' 
            txtValue.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            txtValue.Location = New Drawing.Point(40, 51)
            txtValue.Name = "txtValue"
            txtValue.Size = New Drawing.Size(119, 30)
            txtValue.TabIndex = 10
            ' 
            ' tabControl1
            ' 
            tabControl1.Controls.Add(tabPage1)
            tabControl1.Controls.Add(tabPage2)
            tabControl1.Controls.Add(tabPage3)
            tabControl1.Location = New Drawing.Point(-1, -2)
            tabControl1.Name = "tabControl1"
            tabControl1.SelectedIndex = 0
            tabControl1.Size = New Drawing.Size(599, 454)
            tabControl1.TabIndex = 19
            ' 
            ' tabPage1
            ' 
            tabPage1.Controls.Add(lstQueues)
            tabPage1.Controls.Add(label2)
            tabPage1.Controls.Add(cmbQueueType)
            tabPage1.Controls.Add(btnQueueSize)
            tabPage1.Controls.Add(btnQueuePeek)
            tabPage1.Controls.Add(btnDequeue)
            tabPage1.Controls.Add(btnEnqueue)
            tabPage1.Controls.Add(label1)
            tabPage1.Controls.Add(txtQueueValue)
            tabPage1.Location = New Drawing.Point(4, 24)
            tabPage1.Name = "tabPage1"
            tabPage1.Padding = New System.Windows.Forms.Padding(3)
            tabPage1.Size = New Drawing.Size(591, 426)
            tabPage1.TabIndex = 0
            tabPage1.Text = "Queues"
            tabPage1.UseVisualStyleBackColor = True
            ' 
            ' lstQueues
            ' 
            lstQueues.Font = New Drawing.Font("Swis721 Lt BT", 14.25F)
            lstQueues.FormattingEnabled = True
            lstQueues.ItemHeight = 22
            lstQueues.Location = New Drawing.Point(220, 189)
            lstQueues.Name = "lstQueues"
            lstQueues.Size = New Drawing.Size(122, 202)
            lstQueues.TabIndex = 20
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label2.Location = New Drawing.Point(261, 22)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(201, 22)
            label2.TabIndex = 19
            label2.Text = "Select type of Queue"
            ' 
            ' cmbQueueType
            ' 
            cmbQueueType.FormattingEnabled = True
            cmbQueueType.Items.AddRange(New Object() {"Static", "Dynamic", "Circular"})
            cmbQueueType.Location = New Drawing.Point(261, 47)
            cmbQueueType.Name = "cmbQueueType"
            cmbQueueType.Size = New Drawing.Size(201, 23)
            cmbQueueType.TabIndex = 18
            AddHandler cmbQueueType.SelectedIndexChanged, AddressOf cmbQueueType_SelectedIndexChanged
            ' 
            ' btnQueueSize
            ' 
            btnQueueSize.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnQueueSize.Location = New Drawing.Point(454, 104)
            btnQueueSize.Name = "btnQueueSize"
            btnQueueSize.Size = New Drawing.Size(96, 42)
            btnQueueSize.TabIndex = 17
            btnQueueSize.Text = "Size"
            btnQueueSize.UseVisualStyleBackColor = True
            AddHandler btnQueueSize.Click, AddressOf btnQueueSize_Click
            ' 
            ' btnQueuePeek
            ' 
            btnQueuePeek.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnQueuePeek.Location = New Drawing.Point(313, 104)
            btnQueuePeek.Name = "btnQueuePeek"
            btnQueuePeek.Size = New Drawing.Size(96, 42)
            btnQueuePeek.TabIndex = 16
            btnQueuePeek.Text = "Peek"
            btnQueuePeek.UseVisualStyleBackColor = True
            AddHandler btnQueuePeek.Click, AddressOf btnQueuePeek_Click
            ' 
            ' btnDequeue
            ' 
            btnDequeue.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnDequeue.Location = New Drawing.Point(172, 104)
            btnDequeue.Name = "btnDequeue"
            btnDequeue.Size = New Drawing.Size(96, 42)
            btnDequeue.TabIndex = 15
            btnDequeue.Text = "Dequeue"
            btnDequeue.UseVisualStyleBackColor = True
            AddHandler btnDequeue.Click, AddressOf btnDequeue_Click
            ' 
            ' btnEnqueue
            ' 
            btnEnqueue.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnEnqueue.Location = New Drawing.Point(31, 104)
            btnEnqueue.Name = "btnEnqueue"
            btnEnqueue.Size = New Drawing.Size(96, 42)
            btnEnqueue.TabIndex = 14
            btnEnqueue.Text = "Enqueue"
            btnEnqueue.UseVisualStyleBackColor = True
            AddHandler btnEnqueue.Click, AddressOf btnEnqueue_Click
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label1.Location = New Drawing.Point(25, 15)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(88, 22)
            label1.TabIndex = 11
            label1.Text = "Number:"
            ' 
            ' txtQueueValue
            ' 
            txtQueueValue.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            txtQueueValue.Location = New Drawing.Point(9, 40)
            txtQueueValue.Name = "txtQueueValue"
            txtQueueValue.Size = New Drawing.Size(119, 30)
            txtQueueValue.TabIndex = 10
            ' 
            ' tabPage2
            ' 
            tabPage2.Controls.Add(lstDoubleQueues)
            tabPage2.Controls.Add(btnDoubleQSize)
            tabPage2.Controls.Add(btnGetRear)
            tabPage2.Controls.Add(btnGetFront)
            tabPage2.Controls.Add(btnDeleteRear)
            tabPage2.Controls.Add(btnDeleteFront)
            tabPage2.Controls.Add(btnInsertRear)
            tabPage2.Controls.Add(btnInserFront)
            tabPage2.Controls.Add(label3)
            tabPage2.Controls.Add(cmbDQType)
            tabPage2.Controls.Add(label4)
            tabPage2.Controls.Add(txtDQValue)
            tabPage2.Location = New Drawing.Point(4, 24)
            tabPage2.Name = "tabPage2"
            tabPage2.Padding = New System.Windows.Forms.Padding(3)
            tabPage2.Size = New Drawing.Size(591, 426)
            tabPage2.TabIndex = 1
            tabPage2.Text = "Double Queues"
            tabPage2.UseVisualStyleBackColor = True
            ' 
            ' lstDoubleQueues
            ' 
            lstDoubleQueues.Font = New Drawing.Font("Swis721 Lt BT", 14.25F)
            lstDoubleQueues.FormattingEnabled = True
            lstDoubleQueues.ItemHeight = 22
            lstDoubleQueues.Location = New Drawing.Point(215, 214)
            lstDoubleQueues.Name = "lstDoubleQueues"
            lstDoubleQueues.Size = New Drawing.Size(122, 202)
            lstDoubleQueues.TabIndex = 31
            ' 
            ' btnDoubleQSize
            ' 
            btnDoubleQSize.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnDoubleQSize.Location = New Drawing.Point(372, 150)
            btnDoubleQSize.Name = "btnDoubleQSize"
            btnDoubleQSize.Size = New Drawing.Size(96, 42)
            btnDoubleQSize.TabIndex = 30
            btnDoubleQSize.Text = "Size"
            btnDoubleQSize.UseVisualStyleBackColor = True
            AddHandler btnDoubleQSize.Click, AddressOf btnDoubleQSize_Click
            ' 
            ' btnGetRear
            ' 
            btnGetRear.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnGetRear.Location = New Drawing.Point(231, 150)
            btnGetRear.Name = "btnGetRear"
            btnGetRear.Size = New Drawing.Size(96, 42)
            btnGetRear.TabIndex = 29
            btnGetRear.Text = "Get Rear"
            btnGetRear.UseVisualStyleBackColor = True
            AddHandler btnGetRear.Click, AddressOf btnGetRear_Click
            ' 
            ' btnGetFront
            ' 
            btnGetFront.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnGetFront.Location = New Drawing.Point(90, 150)
            btnGetFront.Name = "btnGetFront"
            btnGetFront.Size = New Drawing.Size(96, 42)
            btnGetFront.TabIndex = 28
            btnGetFront.Text = "Get Front"
            btnGetFront.UseVisualStyleBackColor = True
            AddHandler btnGetFront.Click, AddressOf btnGetFront_Click
            ' 
            ' btnDeleteRear
            ' 
            btnDeleteRear.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnDeleteRear.Location = New Drawing.Point(441, 102)
            btnDeleteRear.Name = "btnDeleteRear"
            btnDeleteRear.Size = New Drawing.Size(112, 42)
            btnDeleteRear.TabIndex = 27
            btnDeleteRear.Text = "Delete Rear"
            btnDeleteRear.UseVisualStyleBackColor = True
            AddHandler btnDeleteRear.Click, AddressOf btnDeleteRear_Click
            ' 
            ' btnDeleteFront
            ' 
            btnDeleteFront.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnDeleteFront.Location = New Drawing.Point(300, 102)
            btnDeleteFront.Name = "btnDeleteFront"
            btnDeleteFront.Size = New Drawing.Size(112, 42)
            btnDeleteFront.TabIndex = 26
            btnDeleteFront.Text = "Delete Front"
            btnDeleteFront.UseVisualStyleBackColor = True
            AddHandler btnDeleteFront.Click, AddressOf btnDeleteFront_Click
            ' 
            ' btnInsertRear
            ' 
            btnInsertRear.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnInsertRear.Location = New Drawing.Point(159, 102)
            btnInsertRear.Name = "btnInsertRear"
            btnInsertRear.Size = New Drawing.Size(102, 42)
            btnInsertRear.TabIndex = 25
            btnInsertRear.Text = "Insert Rear"
            btnInsertRear.UseVisualStyleBackColor = True
            AddHandler btnInsertRear.Click, AddressOf btnInsertRear_Click
            ' 
            ' btnInserFront
            ' 
            btnInserFront.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnInserFront.Location = New Drawing.Point(18, 102)
            btnInserFront.Name = "btnInserFront"
            btnInserFront.Size = New Drawing.Size(114, 42)
            btnInserFront.TabIndex = 24
            btnInserFront.Text = "Insert Front"
            btnInserFront.UseVisualStyleBackColor = True
            AddHandler btnInserFront.Click, AddressOf btnInserFront_Click
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label3.Location = New Drawing.Point(253, 38)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(272, 22)
            label3.TabIndex = 23
            label3.Text = "Select type of Double Queue"
            ' 
            ' cmbDQType
            ' 
            cmbDQType.FormattingEnabled = True
            cmbDQType.Items.AddRange(New Object() {"Static", "Dynamic"})
            cmbDQType.Location = New Drawing.Point(289, 63)
            cmbDQType.Name = "cmbDQType"
            cmbDQType.Size = New Drawing.Size(201, 23)
            cmbDQType.TabIndex = 22
            AddHandler cmbDQType.SelectedIndexChanged, AddressOf cmbDQType_SelectedIndexChanged
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label4.Location = New Drawing.Point(53, 31)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(88, 22)
            label4.TabIndex = 21
            label4.Text = "Number:"
            ' 
            ' txtDQValue
            ' 
            txtDQValue.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            txtDQValue.Location = New Drawing.Point(37, 56)
            txtDQValue.Name = "txtDQValue"
            txtDQValue.Size = New Drawing.Size(119, 30)
            txtDQValue.TabIndex = 20
            ' 
            ' tabPage3
            ' 
            tabPage3.Controls.Add(label8)
            tabPage3.Controls.Add(txtPriority)
            tabPage3.Controls.Add(btnSizePQ)
            tabPage3.Controls.Add(btnPeekPQ)
            tabPage3.Controls.Add(btnDequeuePQ)
            tabPage3.Controls.Add(btnEnqueuePQ)
            tabPage3.Controls.Add(lstPQ)
            tabPage3.Controls.Add(label6)
            tabPage3.Controls.Add(cmbTypeOfPQ)
            tabPage3.Controls.Add(label7)
            tabPage3.Controls.Add(txtValuePQ)
            tabPage3.Location = New Drawing.Point(4, 24)
            tabPage3.Name = "tabPage3"
            tabPage3.Padding = New System.Windows.Forms.Padding(3)
            tabPage3.Size = New Drawing.Size(591, 426)
            tabPage3.TabIndex = 2
            tabPage3.Text = "Priority Queues"
            tabPage3.UseVisualStyleBackColor = True
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label8.Location = New Drawing.Point(339, 20)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(80, 22)
            label8.TabIndex = 41
            label8.Text = "Priority:"
            ' 
            ' txtPriority
            ' 
            txtPriority.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            txtPriority.Location = New Drawing.Point(323, 45)
            txtPriority.Name = "txtPriority"
            txtPriority.Size = New Drawing.Size(119, 30)
            txtPriority.TabIndex = 40
            ' 
            ' btnSizePQ
            ' 
            btnSizePQ.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnSizePQ.Location = New Drawing.Point(453, 163)
            btnSizePQ.Name = "btnSizePQ"
            btnSizePQ.Size = New Drawing.Size(96, 42)
            btnSizePQ.TabIndex = 39
            btnSizePQ.Text = "Size"
            btnSizePQ.UseVisualStyleBackColor = True
            AddHandler btnSizePQ.Click, AddressOf btnSizePQ_Click
            ' 
            ' btnPeekPQ
            ' 
            btnPeekPQ.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnPeekPQ.Location = New Drawing.Point(312, 163)
            btnPeekPQ.Name = "btnPeekPQ"
            btnPeekPQ.Size = New Drawing.Size(96, 42)
            btnPeekPQ.TabIndex = 38
            btnPeekPQ.Text = "Peek"
            btnPeekPQ.UseVisualStyleBackColor = True
            AddHandler btnPeekPQ.Click, AddressOf btnPeekPQ_Click
            ' 
            ' btnDequeuePQ
            ' 
            btnDequeuePQ.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnDequeuePQ.Location = New Drawing.Point(171, 163)
            btnDequeuePQ.Name = "btnDequeuePQ"
            btnDequeuePQ.Size = New Drawing.Size(96, 42)
            btnDequeuePQ.TabIndex = 37
            btnDequeuePQ.Text = "Dequeue"
            btnDequeuePQ.UseVisualStyleBackColor = True
            AddHandler btnDequeuePQ.Click, AddressOf btnDequeuePQ_Click
            ' 
            ' btnEnqueuePQ
            ' 
            btnEnqueuePQ.Font = New Drawing.Font("Swis721 Lt BT", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            btnEnqueuePQ.Location = New Drawing.Point(30, 163)
            btnEnqueuePQ.Name = "btnEnqueuePQ"
            btnEnqueuePQ.Size = New Drawing.Size(96, 42)
            btnEnqueuePQ.TabIndex = 36
            btnEnqueuePQ.Text = "Enqueue"
            btnEnqueuePQ.UseVisualStyleBackColor = True
            AddHandler btnEnqueuePQ.Click, AddressOf btnEnqueuePQ_Click
            ' 
            ' lstPQ
            ' 
            lstPQ.Font = New Drawing.Font("Swis721 Lt BT", 14.25F)
            lstPQ.FormattingEnabled = True
            lstPQ.ItemHeight = 22
            lstPQ.Location = New Drawing.Point(215, 214)
            lstPQ.Name = "lstPQ"
            lstPQ.Size = New Drawing.Size(122, 202)
            lstPQ.TabIndex = 32
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label6.Location = New Drawing.Point(167, 84)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(266, 22)
            label6.TabIndex = 27
            label6.Text = "Select type of Prority Queue"
            ' 
            ' cmbTypeOfPQ
            ' 
            cmbTypeOfPQ.FormattingEnabled = True
            cmbTypeOfPQ.Items.AddRange(New Object() {"Vector Of Vectors", "Vector Of Lists", "List Of Vectors", "List Of Lists"})
            cmbTypeOfPQ.Location = New Drawing.Point(196, 109)
            cmbTypeOfPQ.Name = "cmbTypeOfPQ"
            cmbTypeOfPQ.Size = New Drawing.Size(201, 23)
            cmbTypeOfPQ.TabIndex = 26
            AddHandler cmbTypeOfPQ.SelectedIndexChanged, AddressOf cmbTypeOfPQ_SelectedIndexChanged
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label7.Location = New Drawing.Point(181, 20)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(88, 22)
            label7.TabIndex = 25
            label7.Text = "Number:"
            ' 
            ' txtValuePQ
            ' 
            txtValuePQ.Font = New Drawing.Font("Swis721 Lt BT", 14.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            txtValuePQ.Location = New Drawing.Point(165, 45)
            txtValuePQ.Name = "txtValuePQ"
            txtValuePQ.Size = New Drawing.Size(119, 30)
            txtValuePQ.TabIndex = 24
            ' 
            ' QueuesForm
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(594, 450)
            Controls.Add(tabControl1)
            Controls.Add(label5)
            Controls.Add(txtValue)
            Name = "QueuesForm"
            Text = "QueuesForm"
            tabControl1.ResumeLayout(False)
            tabPage1.ResumeLayout(False)
            tabPage1.PerformLayout()
            tabPage2.ResumeLayout(False)
            tabPage2.PerformLayout()
            tabPage3.ResumeLayout(False)
            tabPage3.PerformLayout()
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region

        Private label5 As System.Windows.Forms.Label
        Private txtValue As System.Windows.Forms.TextBox
        Private tabControl1 As System.Windows.Forms.TabControl
        Private tabPage1 As System.Windows.Forms.TabPage
        Private tabPage2 As System.Windows.Forms.TabPage
        Private label1 As System.Windows.Forms.Label
        Private txtQueueValue As System.Windows.Forms.TextBox
        Private btnQueueSize As System.Windows.Forms.Button
        Private btnQueuePeek As System.Windows.Forms.Button
        Private btnDequeue As System.Windows.Forms.Button
        Private btnEnqueue As System.Windows.Forms.Button
        Private label2 As System.Windows.Forms.Label
        Private cmbQueueType As System.Windows.Forms.ComboBox
        Private lstQueues As System.Windows.Forms.ListBox
        Private tabPage3 As System.Windows.Forms.TabPage
        Private lstDoubleQueues As System.Windows.Forms.ListBox
        Private btnDoubleQSize As System.Windows.Forms.Button
        Private btnGetRear As System.Windows.Forms.Button
        Private btnGetFront As System.Windows.Forms.Button
        Private btnDeleteRear As System.Windows.Forms.Button
        Private btnDeleteFront As System.Windows.Forms.Button
        Private btnInsertRear As System.Windows.Forms.Button
        Private btnInserFront As System.Windows.Forms.Button
        Private label3 As System.Windows.Forms.Label
        Private cmbDQType As System.Windows.Forms.ComboBox
        Private label4 As System.Windows.Forms.Label
        Private txtDQValue As System.Windows.Forms.TextBox
        Private lstPQ As System.Windows.Forms.ListBox
        Private label6 As System.Windows.Forms.Label
        Private cmbTypeOfPQ As System.Windows.Forms.ComboBox
        Private label7 As System.Windows.Forms.Label
        Private txtValuePQ As System.Windows.Forms.TextBox
        Private btnSizePQ As System.Windows.Forms.Button
        Private btnPeekPQ As System.Windows.Forms.Button
        Private btnDequeuePQ As System.Windows.Forms.Button
        Private btnEnqueuePQ As System.Windows.Forms.Button
        Private label8 As System.Windows.Forms.Label
        Private txtPriority As System.Windows.Forms.TextBox
    End Class
End Namespace
