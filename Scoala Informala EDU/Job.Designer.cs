
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("TIPS", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_quiz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(21, 21);
            this.treeView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.treeView1.Name = "treeView1";
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
            treeNode6.Text = "TIPS";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(235, 174);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_quiz
            // 
            this.btn_quiz.BackColor = System.Drawing.Color.Yellow;
            this.btn_quiz.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_quiz.Location = new System.Drawing.Point(702, 444);
            this.btn_quiz.Name = "btn_quiz";
            this.btn_quiz.Size = new System.Drawing.Size(195, 35);
            this.btn_quiz.TabIndex = 1;
            this.btn_quiz.Text = "Quick Quiz!";
            this.btn_quiz.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(651, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 216);
            this.label1.TabIndex = 2;
            this.label1.Text = "How did you find the tips?\r\n\r\nFelling confident enough for a quick quiz?\r\n\r\nClick" +
    " on the Quick Quiz button for a shor assessment!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scoala_Informala_EDU.Properties.Resources.Background_tips;
            this.ClientSize = new System.Drawing.Size(944, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_quiz);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Job";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Interview Tips";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_quiz;
        private System.Windows.Forms.Label label1;
    }
}