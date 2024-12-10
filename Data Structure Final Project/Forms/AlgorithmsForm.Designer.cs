namespace Data_Structure_Final_Project
{
    partial class AlgorithmsForm
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
            lstNumbersSort = new ListBox();
            cmbAlgoritms = new ComboBox();
            btnSort = new Button();
            btnSetNumbers = new Button();
            SuspendLayout();
            // 
            // lstNumbersSort
            // 
            lstNumbersSort.Font = new Font("Segoe UI", 14F);
            lstNumbersSort.FormattingEnabled = true;
            lstNumbersSort.ItemHeight = 25;
            lstNumbersSort.Location = new Point(24, 97);
            lstNumbersSort.Name = "lstNumbersSort";
            lstNumbersSort.Size = new Size(454, 354);
            lstNumbersSort.TabIndex = 26;
            // 
            // cmbAlgoritms
            // 
            cmbAlgoritms.FormattingEnabled = true;
            cmbAlgoritms.Location = new Point(24, 32);
            cmbAlgoritms.Name = "cmbAlgoritms";
            cmbAlgoritms.Size = new Size(180, 23);
            cmbAlgoritms.TabIndex = 25;
            // 
            // btnSort
            // 
            btnSort.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSort.Location = new Point(449, 20);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(180, 42);
            btnSort.TabIndex = 24;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnSetNumbers
            // 
            btnSetNumbers.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetNumbers.Location = new Point(260, 20);
            btnSetNumbers.Name = "btnSetNumbers";
            btnSetNumbers.Size = new Size(171, 42);
            btnSetNumbers.TabIndex = 23;
            btnSetNumbers.Text = "Generate Numbers";
            btnSetNumbers.UseVisualStyleBackColor = true;
            btnSetNumbers.Click += btnSetNumbers_Click;
            // 
            // AlgorithmsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 471);
            Controls.Add(lstNumbersSort);
            Controls.Add(cmbAlgoritms);
            Controls.Add(btnSort);
            Controls.Add(btnSetNumbers);
            Name = "AlgorithmsForm";
            Text = "AlgorithmsForm";
            ResumeLayout(false);
        }

        #endregion
        private ListBox lstNumbersSort;
        private ComboBox cmbAlgoritms;
        private Button btnSort;
        private Button btnSetNumbers;

    }
}