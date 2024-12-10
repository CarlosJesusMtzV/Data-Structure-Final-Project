using System.Xml.Linq;

namespace Data_Structure_Final_Project
{
    partial class GraphsForm
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
            btnAddNode = new Button();
            txtNode = new TextBox();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            btnAddEdge = new Button();
            btnRemoveEdge = new Button();
            txtGraphRepresentation = new TextBox();
            txtWeight = new TextBox();
            chkDirected = new CheckBox();
            btnShowDFS = new Button();
            txtStartNode = new TextBox();
            btnRemoveNode = new Button();
            btnShowBFS = new Button();
            btnShowDFSRecursive = new Button();
            btnRemoveAll = new Button();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label22 = new Label();
            label23 = new Label();
            SuspendLayout();
            // 
            // btnAddNode
            // 
            btnAddNode.Location = new Point(171, 88);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(75, 23);
            btnAddNode.TabIndex = 1;
            btnAddNode.Text = "Add Node";
            btnAddNode.UseVisualStyleBackColor = true;
            btnAddNode.Click += btnAddNode_Click;
            // 
            // txtNode
            // 
            txtNode.Location = new Point(161, 55);
            txtNode.Name = "txtNode";
            txtNode.Size = new Size(180, 23);
            txtNode.TabIndex = 2;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(152, 185);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(104, 23);
            txtFrom.TabIndex = 4;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(152, 223);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(104, 23);
            txtTo.TabIndex = 6;
            // 
            // btnAddEdge
            // 
            btnAddEdge.Location = new Point(289, 185);
            btnAddEdge.Name = "btnAddEdge";
            btnAddEdge.Size = new Size(75, 23);
            btnAddEdge.TabIndex = 8;
            btnAddEdge.Text = "Add Edge";
            btnAddEdge.UseVisualStyleBackColor = true;
            btnAddEdge.Click += btnAddEdge_Click;
            // 
            // btnRemoveEdge
            // 
            btnRemoveEdge.Location = new Point(289, 223);
            btnRemoveEdge.Name = "btnRemoveEdge";
            btnRemoveEdge.Size = new Size(75, 39);
            btnRemoveEdge.TabIndex = 9;
            btnRemoveEdge.Text = "Remove Edge";
            btnRemoveEdge.UseVisualStyleBackColor = true;
            btnRemoveEdge.Click += btnRemoveEdge_Click;
            // 
            // txtGraphRepresentation
            // 
            txtGraphRepresentation.Font = new Font("Microsoft Sans Serif", 14F);
            txtGraphRepresentation.Location = new Point(512, 70);
            txtGraphRepresentation.Multiline = true;
            txtGraphRepresentation.Name = "txtGraphRepresentation";
            txtGraphRepresentation.Size = new Size(362, 303);
            txtGraphRepresentation.TabIndex = 12;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(152, 257);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(104, 23);
            txtWeight.TabIndex = 13;
            // 
            // chkDirected
            // 
            chkDirected.AutoSize = true;
            chkDirected.Location = new Point(152, 286);
            chkDirected.Name = "chkDirected";
            chkDirected.Size = new Size(70, 19);
            chkDirected.TabIndex = 15;
            chkDirected.Text = "Directed";
            chkDirected.UseVisualStyleBackColor = true;
            // 
            // btnShowDFS
            // 
            btnShowDFS.Location = new Point(160, 415);
            btnShowDFS.Name = "btnShowDFS";
            btnShowDFS.Size = new Size(75, 39);
            btnShowDFS.TabIndex = 16;
            btnShowDFS.Text = "Show DFS Algorithm";
            btnShowDFS.UseVisualStyleBackColor = true;
            btnShowDFS.Click += btnShowDFS_Click;
            // 
            // txtStartNode
            // 
            txtStartNode.Location = new Point(183, 386);
            txtStartNode.Name = "txtStartNode";
            txtStartNode.Size = new Size(104, 23);
            txtStartNode.TabIndex = 17;
            // 
            // btnRemoveNode
            // 
            btnRemoveNode.Location = new Point(266, 88);
            btnRemoveNode.Name = "btnRemoveNode";
            btnRemoveNode.Size = new Size(75, 23);
            btnRemoveNode.TabIndex = 20;
            btnRemoveNode.Text = "Remove";
            btnRemoveNode.UseVisualStyleBackColor = true;
            btnRemoveNode.Click += btnRemoveNode_Click;
            // 
            // btnShowBFS
            // 
            btnShowBFS.Location = new Point(79, 415);
            btnShowBFS.Name = "btnShowBFS";
            btnShowBFS.Size = new Size(75, 39);
            btnShowBFS.TabIndex = 21;
            btnShowBFS.Text = "Show BFS Algorithm";
            btnShowBFS.UseVisualStyleBackColor = true;
            btnShowBFS.Click += btnShowBFS_Click;
            // 
            // btnShowDFSRecursive
            // 
            btnShowDFSRecursive.Location = new Point(241, 415);
            btnShowDFSRecursive.Name = "btnShowDFSRecursive";
            btnShowDFSRecursive.Size = new Size(75, 39);
            btnShowDFSRecursive.TabIndex = 23;
            btnShowDFSRecursive.Text = "Show DFS Recursive Algorithm";
            btnShowDFSRecursive.UseVisualStyleBackColor = true;
            btnShowDFSRecursive.Click += btnShowDFSRecursive_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new Point(512, 41);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(84, 23);
            btnRemoveAll.TabIndex = 24;
            btnRemoveAll.Text = "Remove All";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Swis721 Lt BT", 15F, FontStyle.Bold);
            label29.Location = new Point(147, 349);
            label29.Name = "label29";
            label29.Size = new Size(109, 24);
            label29.TabIndex = 32;
            label29.Text = "Traversals";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Swis721 Lt BT", 15F, FontStyle.Bold);
            label28.Location = new Point(161, 146);
            label28.Name = "label28";
            label28.Size = new Size(72, 24);
            label28.TabIndex = 31;
            label28.Text = "Edges";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Swis721 Lt BT", 15F, FontStyle.Bold);
            label27.Location = new Point(171, 18);
            label27.Name = "label27";
            label27.Size = new Size(73, 24);
            label27.TabIndex = 30;
            label27.Text = "Nodes";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(82, 388);
            label26.Name = "label26";
            label26.Size = new Size(98, 19);
            label26.TabIndex = 29;
            label26.Text = "Node Start:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(80, 257);
            label25.Name = "label25";
            label25.Size = new Size(68, 19);
            label25.TabIndex = 28;
            label25.Text = "Weight:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(67, 223);
            label24.Name = "label24";
            label24.Size = new Size(81, 19);
            label24.TabIndex = 27;
            label24.Text = "Node To:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(47, 185);
            label22.Name = "label22";
            label22.Size = new Size(101, 19);
            label22.TabIndex = 26;
            label22.Text = "Node From:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(49, 55);
            label23.Name = "label23";
            label23.Size = new Size(106, 19);
            label23.TabIndex = 25;
            label23.Text = "Node Name:";
            // 
            // GraphsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 466);
            Controls.Add(btnAddNode);
            Controls.Add(txtNode);
            Controls.Add(txtFrom);
            Controls.Add(txtTo);
            Controls.Add(btnAddEdge);
            Controls.Add(btnRemoveEdge);
            Controls.Add(txtGraphRepresentation);
            Controls.Add(txtWeight);
            Controls.Add(chkDirected);
            Controls.Add(btnShowDFS);
            Controls.Add(txtStartNode);
            Controls.Add(btnRemoveNode);
            Controls.Add(btnShowBFS);
            Controls.Add(btnShowDFSRecursive);
            Controls.Add(btnRemoveAll);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label22);
            Controls.Add(label23);
            Name = "GraphsForm";
            Text = "GraphsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddNode;
        private TextBox txtNode;
        private TextBox txtFrom;
        private TextBox txtTo;
        private Button btnAddEdge;
        private Button btnRemoveEdge;
        private TextBox txtGraphRepresentation;
        private TextBox txtWeight;
        private CheckBox chkDirected;
        private Button btnShowDFS;
        private TextBox txtStartNode;
        private Button btnRemoveNode;
        private Button btnShowBFS;
        private Button btnShowDFSRecursive;
        private Button btnRemoveAll;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label22;
        private Label label23;


    }
}