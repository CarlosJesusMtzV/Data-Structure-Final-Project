using System.Windows.Forms;

namespace Data_Structure_Final_Project
{
    partial class StacksForm
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
            btnSize = new Button();
            btnPeek = new Button();
            btnPop = new Button();
            btnPush = new Button();
            label8 = new Label();
            txtStackValue = new TextBox();
            lstStaticStack = new ListBox();
            cmbStackType = new ComboBox();
            SuspendLayout();
            // 
            // btnSize
            // 
            btnSize.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSize.Location = new Point(434, 90);
            btnSize.Name = "btnSize";
            btnSize.Size = new Size(96, 42);
            btnSize.TabIndex = 15;
            btnSize.Text = "Size";
            btnSize.UseVisualStyleBackColor = true;
            btnSize.Click += btnSize_Click;
            // 
            // btnPeek
            // 
            btnPeek.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnPeek.Location = new Point(296, 90);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(96, 42);
            btnPeek.TabIndex = 14;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnPop
            // 
            btnPop.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnPop.Location = new Point(158, 90);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(96, 42);
            btnPop.TabIndex = 13;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnPush
            // 
            btnPush.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnPush.Location = new Point(20, 90);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(96, 42);
            btnPush.TabIndex = 12;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(215, 14);
            label8.Name = "label8";
            label8.Size = new Size(91, 24);
            label8.TabIndex = 11;
            label8.Text = "Number:";
            // 
            // txtStackValue
            // 
            txtStackValue.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStackValue.Location = new Point(204, 41);
            txtStackValue.Name = "txtStackValue";
            txtStackValue.Size = new Size(119, 30);
            txtStackValue.TabIndex = 10;
            // 
            // lstStaticStack
            // 
            lstStaticStack.Font = new Font("Microsoft Sans Serif", 14.25F);
            lstStaticStack.FormattingEnabled = true;
            lstStaticStack.ItemHeight = 24;
            lstStaticStack.Location = new Point(204, 170);
            lstStaticStack.Name = "lstStaticStack";
            lstStaticStack.Size = new Size(119, 268);
            lstStaticStack.TabIndex = 2;
            // 
            // cmbStackType
            // 
            cmbStackType.FormattingEnabled = true;
            cmbStackType.Items.AddRange(new object[] { "Static", "Dynamic" });
            cmbStackType.Location = new Point(339, 41);
            cmbStackType.Name = "cmbStackType";
            cmbStackType.Size = new Size(121, 23);
            cmbStackType.TabIndex = 16;
            cmbStackType.SelectedIndexChanged += cmbStackType_SelectedIndexChanged;
            // 
            // StacksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 450);
            Controls.Add(cmbStackType);
            Controls.Add(btnSize);
            Controls.Add(btnPeek);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(label8);
            Controls.Add(txtStackValue);
            Controls.Add(lstStaticStack);
            Name = "StacksForm";
            Text = "StacksForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSize;
        private Button btnPeek;
        private Button btnPop;
        private Button btnPush;
        private Label label8;
        private TextBox txtStackValue;
        private ListBox lstStaticStack;
        private ComboBox cmbStackType;
    }
}