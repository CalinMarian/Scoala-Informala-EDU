
namespace Scoala_Informala_EDU
{
    partial class Tips
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
            this.btnCV = new System.Windows.Forms.Button();
            this.btnInterview = new System.Windows.Forms.Button();
            this.btnIS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCV
            // 
            this.btnCV.Location = new System.Drawing.Point(43, 181);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(137, 65);
            this.btnCV.TabIndex = 0;
            this.btnCV.Text = "CV";
            this.btnCV.UseVisualStyleBackColor = true;
            this.btnCV.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInterview
            // 
            this.btnInterview.Location = new System.Drawing.Point(287, 181);
            this.btnInterview.Name = "btnInterview";
            this.btnInterview.Size = new System.Drawing.Size(137, 65);
            this.btnInterview.TabIndex = 1;
            this.btnInterview.Text = "Interview";
            this.btnInterview.UseVisualStyleBackColor = true;
            this.btnInterview.Click += new System.EventHandler(this.btnInterview_Click);
            // 
            // btnIS
            // 
            this.btnIS.Location = new System.Drawing.Point(532, 181);
            this.btnIS.Name = "btnIS";
            this.btnIS.Size = new System.Drawing.Size(137, 65);
            this.btnIS.TabIndex = 2;
            this.btnIS.Text = "Impostor Syndrome";
            this.btnIS.UseVisualStyleBackColor = true;
            this.btnIS.Click += new System.EventHandler(this.btnIS_Click);
            // 
            // Tips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 441);
            this.Controls.Add(this.btnIS);
            this.Controls.Add(this.btnInterview);
            this.Controls.Add(this.btnCV);
            this.Name = "Tips";
            this.Text = "Tips";
            this.Load += new System.EventHandler(this.Tips_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btnInterview;
        private System.Windows.Forms.Button btnIS;
    }
}