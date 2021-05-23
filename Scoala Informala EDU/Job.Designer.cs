
namespace Scoala_Informala_EDU
{
    partial class Job
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("CV");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("DOs");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("DON\'Ts");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Interview", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Impostor Syndrome");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("TIPS  ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode5});
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.Btn_quiz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TreeView1
            // 
            this.TreeView1.CheckBoxes = true;
            this.TreeView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TreeView1.HotTracking = true;
            this.TreeView1.Location = new System.Drawing.Point(14, 31);
            this.TreeView1.Margin = new System.Windows.Forms.Padding(5);
            this.TreeView1.Name = "TreeView1";
            treeNode1.Name = "nCV";
            treeNode1.NodeFont = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode1.Text = "CV";
            treeNode2.Name = "nDo";
            treeNode2.NodeFont = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode2.Text = "DOs";
            treeNode3.Name = "nDonts";
            treeNode3.NodeFont = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode3.Text = "DON\'Ts";
            treeNode4.Name = "nInterview";
            treeNode4.NodeFont = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode4.Text = "Interview";
            treeNode5.Name = "nIS";
            treeNode5.NodeFont = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode5.Text = "Impostor Syndrome";
            treeNode6.Name = "nTIPS";
            treeNode6.NodeFont = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode6.Text = "TIPS  ";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.TreeView1.Size = new System.Drawing.Size(235, 174);
            this.TreeView1.TabIndex = 0;
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.TreeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // Btn_quiz
            // 
            this.Btn_quiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_quiz.BackColor = System.Drawing.Color.Yellow;
            this.Btn_quiz.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_quiz.Location = new System.Drawing.Point(539, 444);
            this.Btn_quiz.Name = "Btn_quiz";
            this.Btn_quiz.Size = new System.Drawing.Size(195, 35);
            this.Btn_quiz.TabIndex = 1;
            this.Btn_quiz.Text = "Quick Quiz!";
            this.Btn_quiz.UseVisualStyleBackColor = false;
            this.Btn_quiz.Click += new System.EventHandler(this.Btn_quiz_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(539, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 179);
            this.label1.TabIndex = 2;
            this.label1.Text = "How did you find the tips?\r\n\r\nFelling confident enough for a quick quiz?\r\n\r\nClick" +
    " on the Quick Quiz button for a short assessment!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(290, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(642, 210);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scoala_Informala_EDU.Properties.Resources.Background_tips;
            this.ClientSize = new System.Drawing.Size(944, 491);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_quiz);
            this.Controls.Add(this.TreeView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Job";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Interview Tips";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeView1;
        private System.Windows.Forms.Button Btn_quiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}