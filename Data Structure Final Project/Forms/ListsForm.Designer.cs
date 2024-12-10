namespace Data_Structure_Final_Project
{
    partial class ListsForm
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
            btnCount = new Button();
            btnContains = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            label5 = new Label();
            txtValue = new TextBox();
            lstSimpleLinkedList = new ListBox();
            cmbListType = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCount.Location = new Point(545, 128);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(96, 42);
            btnCount.TabIndex = 13;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnContains
            // 
            btnContains.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContains.Location = new Point(404, 128);
            btnContains.Name = "btnContains";
            btnContains.Size = new Size(96, 42);
            btnContains.TabIndex = 12;
            btnContains.Text = "Contains";
            btnContains.UseVisualStyleBackColor = true;
            btnContains.Click += btnContains_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(263, 128);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(96, 42);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(122, 128);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 42);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(197, 43);
            label5.Name = "label5";
            label5.Size = new Size(88, 22);
            label5.TabIndex = 9;
            label5.Text = "Number:";
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValue.Location = new Point(183, 68);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(119, 30);
            txtValue.TabIndex = 8;
            // 
            // lstSimpleLinkedList
            // 
            lstSimpleLinkedList.Font = new Font("Swis721 Lt BT", 14.25F);
            lstSimpleLinkedList.FormattingEnabled = true;
            lstSimpleLinkedList.ItemHeight = 22;
            lstSimpleLinkedList.Location = new Point(331, 205);
            lstSimpleLinkedList.Name = "lstSimpleLinkedList";
            lstSimpleLinkedList.Size = new Size(122, 202);
            lstSimpleLinkedList.TabIndex = 0;
            // 
            // cmbListType
            // 
            cmbListType.FormattingEnabled = true;
            cmbListType.Location = new Point(353, 68);
            cmbListType.Name = "cmbListType";
            cmbListType.Size = new Size(201, 23);
            cmbListType.TabIndex = 14;
            cmbListType.SelectedIndexChanged += cmbListType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 43);
            label1.Name = "label1";
            label1.Size = new Size(168, 22);
            label1.TabIndex = 15;
            label1.Text = "Select type of list";
            // 
            // ListsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 449);
            Controls.Add(label1);
            Controls.Add(cmbListType);
            Controls.Add(btnCount);
            Controls.Add(btnContains);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(txtValue);
            Controls.Add(lstSimpleLinkedList);
            Name = "ListsForm";
            Text = "ListsForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCount;
        private Button btnContains;
        private Button btnRemove;
        private Button btnAdd;
        private Label label5;
        private TextBox txtValue;
        private ListBox lstSimpleLinkedList;
        private ComboBox cmbListType;
        private Label label1;
    }
}