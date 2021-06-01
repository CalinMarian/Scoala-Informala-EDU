
namespace Scoala_Informala_EDU
{
    partial class Learn
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Introduction to Programming");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Types & Variables");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("C# Keywords");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Integer types and their ranges of values");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Intro", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBoxPDF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Introduction to Programming";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Types & Variables";
            treeNode3.Name = "Node3";
            treeNode3.Text = "C# Keywords";
            treeNode4.Name = "Node7";
            treeNode4.Text = "Integer types and their ranges of values";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Intro";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(283, 467);
            this.treeView1.TabIndex = 0;
            // 
            // pictureBoxPDF
            // 
            this.pictureBoxPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPDF.Location = new System.Drawing.Point(301, 12);
            this.pictureBoxPDF.Name = "pictureBoxPDF";
            this.pictureBoxPDF.Size = new System.Drawing.Size(631, 467);
            this.pictureBoxPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPDF.TabIndex = 1;
            this.pictureBoxPDF.TabStop = false;
            // 
            // Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 491);
            this.Controls.Add(this.pictureBoxPDF);
            this.Controls.Add(this.treeView1);
            this.Name = "Learn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBoxPDF;
    }
}