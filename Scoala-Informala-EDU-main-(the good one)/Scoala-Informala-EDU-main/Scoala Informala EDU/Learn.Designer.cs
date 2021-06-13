
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Learn));
            this.pictureBoxLearn = new System.Windows.Forms.PictureBox();
            this.linkLbl = new System.Windows.Forms.LinkLabel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLearn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLearn
            // 
            resources.ApplyResources(this.pictureBoxLearn, "pictureBoxLearn");
            this.pictureBoxLearn.Name = "pictureBoxLearn";
            this.pictureBoxLearn.TabStop = false;
            // 
            // linkLbl
            // 
            resources.ApplyResources(this.linkLbl, "linkLbl");
            this.linkLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLbl.Name = "linkLbl";
            this.linkLbl.TabStop = true;
            this.linkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClickedEvent);
            // 
            // btnPrev
            // 
            resources.ApplyResources(this.btnPrev, "btnPrev");
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.BackgroundImage = global::Scoala_Informala_EDU.Properties.Resources.GetStarted;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NextClickEvent);
            // 
            // Learn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.linkLbl);
            this.Controls.Add(this.pictureBoxLearn);
            this.Name = "Learn";
            this.Load += new System.EventHandler(this.Learn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLearn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLearn;
        private System.Windows.Forms.LinkLabel linkLbl;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
    }
}