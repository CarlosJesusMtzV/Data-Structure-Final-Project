namespace Data_Structure_Final_Project
{
    partial class QueuesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            txtValue = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lstQueues = new ListBox();
            label2 = new Label();
            cmbQueueType = new ComboBox();
            btnQueueSize = new Button();
            btnQueuePeek = new Button();
            btnDequeue = new Button();
            btnEnqueue = new Button();
            label1 = new Label();
            txtQueueValue = new TextBox();
            tabPage2 = new TabPage();
            lstDoubleQueues = new ListBox();
            btnDoubleQSize = new Button();
            btnGetRear = new Button();
            btnGetFront = new Button();
            btnDeleteRear = new Button();
            btnDeleteFront = new Button();
            btnInsertRear = new Button();
            btnInserFront = new Button();
            label3 = new Label();
            cmbDQType = new ComboBox();
            label4 = new Label();
            txtDQValue = new TextBox();
            tabPage3 = new TabPage();
            label8 = new Label();
            txtPriority = new TextBox();
            btnSizePQ = new Button();
            btnPeekPQ = new Button();
            btnDequeuePQ = new Button();
            btnEnqueuePQ = new Button();
            lstPQ = new ListBox();
            label6 = new Label();
            cmbTypeOfPQ = new ComboBox();
            label7 = new Label();
            txtValuePQ = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(60, 26);
            label5.Name = "label5";
            label5.Size = new Size(88, 22);
            label5.TabIndex = 11;
            label5.Text = "Number:";
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValue.Location = new Point(40, 51);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(119, 30);
            txtValue.TabIndex = 10;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-1, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(599, 454);
            tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lstQueues);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(cmbQueueType);
            tabPage1.Controls.Add(btnQueueSize);
            tabPage1.Controls.Add(btnQueuePeek);
            tabPage1.Controls.Add(btnDequeue);
            tabPage1.Controls.Add(btnEnqueue);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtQueueValue);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(591, 426);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Queues";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstQueues
            // 
            lstQueues.Font = new Font("Swis721 Lt BT", 14.25F);
            lstQueues.FormattingEnabled = true;
            lstQueues.ItemHeight = 22;
            lstQueues.Location = new Point(220, 189);
            lstQueues.Name = "lstQueues";
            lstQueues.Size = new Size(122, 202);
            lstQueues.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(261, 22);
            label2.Name = "label2";
            label2.Size = new Size(201, 22);
            label2.TabIndex = 19;
            label2.Text = "Select type of Queue";
            // 
            // cmbQueueType
            // 
            cmbQueueType.FormattingEnabled = true;
            cmbQueueType.Items.AddRange(new object[] { "Static", "Dynamic", "Circular" });
            cmbQueueType.Location = new Point(261, 47);
            cmbQueueType.Name = "cmbQueueType";
            cmbQueueType.Size = new Size(201, 23);
            cmbQueueType.TabIndex = 18;
            cmbQueueType.SelectedIndexChanged += cmbQueueType_SelectedIndexChanged;
            // 
            // btnQueueSize
            // 
            btnQueueSize.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQueueSize.Location = new Point(454, 104);
            btnQueueSize.Name = "btnQueueSize";
            btnQueueSize.Size = new Size(96, 42);
            btnQueueSize.TabIndex = 17;
            btnQueueSize.Text = "Size";
            btnQueueSize.UseVisualStyleBackColor = true;
            btnQueueSize.Click += btnQueueSize_Click;
            // 
            // btnQueuePeek
            // 
            btnQueuePeek.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQueuePeek.Location = new Point(313, 104);
            btnQueuePeek.Name = "btnQueuePeek";
            btnQueuePeek.Size = new Size(96, 42);
            btnQueuePeek.TabIndex = 16;
            btnQueuePeek.Text = "Peek";
            btnQueuePeek.UseVisualStyleBackColor = true;
            btnQueuePeek.Click += btnQueuePeek_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDequeue.Location = new Point(172, 104);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(96, 42);
            btnDequeue.TabIndex = 15;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnqueue.Location = new Point(31, 104);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(96, 42);
            btnEnqueue.TabIndex = 14;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 15);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 11;
            label1.Text = "Number:";
            // 
            // txtQueueValue
            // 
            txtQueueValue.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQueueValue.Location = new Point(9, 40);
            txtQueueValue.Name = "txtQueueValue";
            txtQueueValue.Size = new Size(119, 30);
            txtQueueValue.TabIndex = 10;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lstDoubleQueues);
            tabPage2.Controls.Add(btnDoubleQSize);
            tabPage2.Controls.Add(btnGetRear);
            tabPage2.Controls.Add(btnGetFront);
            tabPage2.Controls.Add(btnDeleteRear);
            tabPage2.Controls.Add(btnDeleteFront);
            tabPage2.Controls.Add(btnInsertRear);
            tabPage2.Controls.Add(btnInserFront);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(cmbDQType);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtDQValue);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(591, 426);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Double Queues";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstDoubleQueues
            // 
            lstDoubleQueues.Font = new Font("Swis721 Lt BT", 14.25F);
            lstDoubleQueues.FormattingEnabled = true;
            lstDoubleQueues.ItemHeight = 22;
            lstDoubleQueues.Location = new Point(215, 214);
            lstDoubleQueues.Name = "lstDoubleQueues";
            lstDoubleQueues.Size = new Size(122, 202);
            lstDoubleQueues.TabIndex = 31;
            // 
            // btnDoubleQSize
            // 
            btnDoubleQSize.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoubleQSize.Location = new Point(372, 150);
            btnDoubleQSize.Name = "btnDoubleQSize";
            btnDoubleQSize.Size = new Size(96, 42);
            btnDoubleQSize.TabIndex = 30;
            btnDoubleQSize.Text = "Size";
            btnDoubleQSize.UseVisualStyleBackColor = true;
            btnDoubleQSize.Click += btnDoubleQSize_Click;
            // 
            // btnGetRear
            // 
            btnGetRear.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetRear.Location = new Point(231, 150);
            btnGetRear.Name = "btnGetRear";
            btnGetRear.Size = new Size(96, 42);
            btnGetRear.TabIndex = 29;
            btnGetRear.Text = "Get Rear";
            btnGetRear.UseVisualStyleBackColor = true;
            btnGetRear.Click += btnGetRear_Click;
            // 
            // btnGetFront
            // 
            btnGetFront.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetFront.Location = new Point(90, 150);
            btnGetFront.Name = "btnGetFront";
            btnGetFront.Size = new Size(96, 42);
            btnGetFront.TabIndex = 28;
            btnGetFront.Text = "Get Front";
            btnGetFront.UseVisualStyleBackColor = true;
            btnGetFront.Click += btnGetFront_Click;
            // 
            // btnDeleteRear
            // 
            btnDeleteRear.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteRear.Location = new Point(441, 102);
            btnDeleteRear.Name = "btnDeleteRear";
            btnDeleteRear.Size = new Size(112, 42);
            btnDeleteRear.TabIndex = 27;
            btnDeleteRear.Text = "Delete Rear";
            btnDeleteRear.UseVisualStyleBackColor = true;
            btnDeleteRear.Click += btnDeleteRear_Click;
            // 
            // btnDeleteFront
            // 
            btnDeleteFront.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteFront.Location = new Point(300, 102);
            btnDeleteFront.Name = "btnDeleteFront";
            btnDeleteFront.Size = new Size(112, 42);
            btnDeleteFront.TabIndex = 26;
            btnDeleteFront.Text = "Delete Front";
            btnDeleteFront.UseVisualStyleBackColor = true;
            btnDeleteFront.Click += btnDeleteFront_Click;
            // 
            // btnInsertRear
            // 
            btnInsertRear.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertRear.Location = new Point(159, 102);
            btnInsertRear.Name = "btnInsertRear";
            btnInsertRear.Size = new Size(102, 42);
            btnInsertRear.TabIndex = 25;
            btnInsertRear.Text = "Insert Rear";
            btnInsertRear.UseVisualStyleBackColor = true;
            btnInsertRear.Click += btnInsertRear_Click;
            // 
            // btnInserFront
            // 
            btnInserFront.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserFront.Location = new Point(18, 102);
            btnInserFront.Name = "btnInserFront";
            btnInserFront.Size = new Size(114, 42);
            btnInserFront.TabIndex = 24;
            btnInserFront.Text = "Insert Front";
            btnInserFront.UseVisualStyleBackColor = true;
            btnInserFront.Click += btnInserFront_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(253, 38);
            label3.Name = "label3";
            label3.Size = new Size(272, 22);
            label3.TabIndex = 23;
            label3.Text = "Select type of Double Queue";
            // 
            // cmbDQType
            // 
            cmbDQType.FormattingEnabled = true;
            cmbDQType.Items.AddRange(new object[] { "Static", "Dynamic" });
            cmbDQType.Location = new Point(289, 63);
            cmbDQType.Name = "cmbDQType";
            cmbDQType.Size = new Size(201, 23);
            cmbDQType.TabIndex = 22;
            cmbDQType.SelectedIndexChanged += cmbDQType_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 31);
            label4.Name = "label4";
            label4.Size = new Size(88, 22);
            label4.TabIndex = 21;
            label4.Text = "Number:";
            // 
            // txtDQValue
            // 
            txtDQValue.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDQValue.Location = new Point(37, 56);
            txtDQValue.Name = "txtDQValue";
            txtDQValue.Size = new Size(119, 30);
            txtDQValue.TabIndex = 20;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(txtPriority);
            tabPage3.Controls.Add(btnSizePQ);
            tabPage3.Controls.Add(btnPeekPQ);
            tabPage3.Controls.Add(btnDequeuePQ);
            tabPage3.Controls.Add(btnEnqueuePQ);
            tabPage3.Controls.Add(lstPQ);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(cmbTypeOfPQ);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(txtValuePQ);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(591, 426);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Priority Queues";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(339, 20);
            label8.Name = "label8";
            label8.Size = new Size(80, 22);
            label8.TabIndex = 41;
            label8.Text = "Priority:";
            // 
            // txtPriority
            // 
            txtPriority.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPriority.Location = new Point(323, 45);
            txtPriority.Name = "txtPriority";
            txtPriority.Size = new Size(119, 30);
            txtPriority.TabIndex = 40;
            // 
            // btnSizePQ
            // 
            btnSizePQ.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSizePQ.Location = new Point(453, 163);
            btnSizePQ.Name = "btnSizePQ";
            btnSizePQ.Size = new Size(96, 42);
            btnSizePQ.TabIndex = 39;
            btnSizePQ.Text = "Size";
            btnSizePQ.UseVisualStyleBackColor = true;
            btnSizePQ.Click += btnSizePQ_Click;
            // 
            // btnPeekPQ
            // 
            btnPeekPQ.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeekPQ.Location = new Point(312, 163);
            btnPeekPQ.Name = "btnPeekPQ";
            btnPeekPQ.Size = new Size(96, 42);
            btnPeekPQ.TabIndex = 38;
            btnPeekPQ.Text = "Peek";
            btnPeekPQ.UseVisualStyleBackColor = true;
            btnPeekPQ.Click += btnPeekPQ_Click;
            // 
            // btnDequeuePQ
            // 
            btnDequeuePQ.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDequeuePQ.Location = new Point(171, 163);
            btnDequeuePQ.Name = "btnDequeuePQ";
            btnDequeuePQ.Size = new Size(96, 42);
            btnDequeuePQ.TabIndex = 37;
            btnDequeuePQ.Text = "Dequeue";
            btnDequeuePQ.UseVisualStyleBackColor = true;
            btnDequeuePQ.Click += btnDequeuePQ_Click;
            // 
            // btnEnqueuePQ
            // 
            btnEnqueuePQ.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnqueuePQ.Location = new Point(30, 163);
            btnEnqueuePQ.Name = "btnEnqueuePQ";
            btnEnqueuePQ.Size = new Size(96, 42);
            btnEnqueuePQ.TabIndex = 36;
            btnEnqueuePQ.Text = "Enqueue";
            btnEnqueuePQ.UseVisualStyleBackColor = true;
            btnEnqueuePQ.Click += btnEnqueuePQ_Click;
            // 
            // lstPQ
            // 
            lstPQ.Font = new Font("Swis721 Lt BT", 14.25F);
            lstPQ.FormattingEnabled = true;
            lstPQ.ItemHeight = 22;
            lstPQ.Location = new Point(215, 214);
            lstPQ.Name = "lstPQ";
            lstPQ.Size = new Size(122, 202);
            lstPQ.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(167, 84);
            label6.Name = "label6";
            label6.Size = new Size(266, 22);
            label6.TabIndex = 27;
            label6.Text = "Select type of Prority Queue";
            // 
            // cmbTypeOfPQ
            // 
            cmbTypeOfPQ.FormattingEnabled = true;
            cmbTypeOfPQ.Items.AddRange(new object[] { "Vector Of Vectors", "Vector Of Lists", "List Of Vectors", "List Of Lists" });
            cmbTypeOfPQ.Location = new Point(196, 109);
            cmbTypeOfPQ.Name = "cmbTypeOfPQ";
            cmbTypeOfPQ.Size = new Size(201, 23);
            cmbTypeOfPQ.TabIndex = 26;
            cmbTypeOfPQ.SelectedIndexChanged += cmbTypeOfPQ_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(181, 20);
            label7.Name = "label7";
            label7.Size = new Size(88, 22);
            label7.TabIndex = 25;
            label7.Text = "Number:";
            // 
            // txtValuePQ
            // 
            txtValuePQ.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValuePQ.Location = new Point(165, 45);
            txtValuePQ.Name = "txtValuePQ";
            txtValuePQ.Size = new Size(119, 30);
            txtValuePQ.TabIndex = 24;
            // 
            // QueuesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 450);
            Controls.Add(tabControl1);
            Controls.Add(label5);
            Controls.Add(txtValue);
            Name = "QueuesForm";
            Text = "QueuesForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtValue;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox txtQueueValue;
        private Button btnQueueSize;
        private Button btnQueuePeek;
        private Button btnDequeue;
        private Button btnEnqueue;
        private Label label2;
        private ComboBox cmbQueueType;
        private ListBox lstQueues;
        private TabPage tabPage3;
        private ListBox lstDoubleQueues;
        private Button btnDoubleQSize;
        private Button btnGetRear;
        private Button btnGetFront;
        private Button btnDeleteRear;
        private Button btnDeleteFront;
        private Button btnInsertRear;
        private Button btnInserFront;
        private Label label3;
        private ComboBox cmbDQType;
        private Label label4;
        private TextBox txtDQValue;
        private ListBox lstPQ;
        private Label label6;
        private ComboBox cmbTypeOfPQ;
        private Label label7;
        private TextBox txtValuePQ;
        private Button btnSizePQ;
        private Button btnPeekPQ;
        private Button btnDequeuePQ;
        private Button btnEnqueuePQ;
        private Label label8;
        private TextBox txtPriority;
    }
}