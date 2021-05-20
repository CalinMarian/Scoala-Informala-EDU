
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("CV");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("DOs");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("DON\'Ts");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Interview", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Impostor Syndrome");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("TIPS  ", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode10,
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_quiz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTips = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(14, 14);
            this.treeView1.Margin = new System.Windows.Forms.Padding(5);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "nCV";
            treeNode7.NodeFont = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode7.Text = "CV";
            treeNode8.Name = "nDo";
            treeNode8.NodeFont = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode8.Text = "DOs";
            treeNode9.Name = "nDonts";
            treeNode9.NodeFont = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode9.Text = "DON\'Ts";
            treeNode10.Name = "nInterview";
            treeNode10.NodeFont = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode10.Text = "Interview";
            treeNode11.Name = "nIS";
            treeNode11.NodeFont = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode11.Text = "Impostor Syndrome";
            treeNode12.Name = "nTIPS";
            treeNode12.NodeFont = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode12.Text = "TIPS  ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(235, 174);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_quiz
            // 
            this.btn_quiz.BackColor = System.Drawing.Color.Yellow;
            this.btn_quiz.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_quiz.Location = new System.Drawing.Point(737, 444);
            this.btn_quiz.Name = "btn_quiz";
            this.btn_quiz.Size = new System.Drawing.Size(195, 35);
            this.btn_quiz.TabIndex = 1;
            this.btn_quiz.Text = "Quick Quiz!";
            this.btn_quiz.UseVisualStyleBackColor = false;
            this.btn_quiz.Click += new System.EventHandler(this.btn_quiz_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(737, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 214);
            this.label1.TabIndex = 2;
            this.label1.Text = "How did you find the tips?\r\n\r\nFelling confident enough for a quick quiz?\r\n\r\nClick" +
    " on the Quick Quiz button for a short assessment!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTips
            // 
            this.btnTips.Location = new System.Drawing.Point(14, 392);
            this.btnTips.Name = "btnTips";
            this.btnTips.Size = new System.Drawing.Size(174, 49);
            this.btnTips.TabIndex = 3;
            this.btnTips.Text = "TIPS";
            this.btnTips.UseVisualStyleBackColor = true;
            this.btnTips.Click += new System.EventHandler(this.btnTips_Click);
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scoala_Informala_EDU.Properties.Resources.Background_tips;
            this.ClientSize = new System.Drawing.Size(944, 491);
            this.Controls.Add(this.btnTips);
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
        private System.Windows.Forms.Button btnTips;
    }
}