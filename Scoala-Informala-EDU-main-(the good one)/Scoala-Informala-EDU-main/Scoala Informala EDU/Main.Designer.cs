
namespace Scoala_Informala_EDU
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.RadioBtnMusic = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLearn
            // 
            this.btnLearn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLearn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLearn.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnLearn.FlatAppearance.BorderSize = 2;
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearn.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnLearn.Location = new System.Drawing.Point(36, 210);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(194, 43);
            this.btnLearn.TabIndex = 0;
            this.btnLearn.Text = "Learn C#";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.LearnClickEvent);
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuiz.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnQuiz.FlatAppearance.BorderSize = 2;
            this.btnQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiz.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnQuiz.Location = new System.Drawing.Point(36, 273);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(194, 43);
            this.btnQuiz.TabIndex = 1;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = true;
            this.btnQuiz.Click += new System.EventHandler(this.QuizClickEvent);
            // 
            // btnAbout
            // 
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnAbout.FlatAppearance.BorderSize = 2;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAbout.Location = new System.Drawing.Point(36, 395);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(194, 43);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.AboutClickEvent);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(36, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Job Interview Tips";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.JobClickEvent);
            // 
            // btnQuit
            // 
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnQuit.FlatAppearance.BorderSize = 2;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnQuit.Location = new System.Drawing.Point(36, 453);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(194, 43);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.QuitClickEvent);
            // 
            // RadioBtnMusic
            // 
            this.RadioBtnMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioBtnMusic.AutoSize = true;
            this.RadioBtnMusic.Location = new System.Drawing.Point(860, 12);
            this.RadioBtnMusic.Name = "RadioBtnMusic";
            this.RadioBtnMusic.Size = new System.Drawing.Size(112, 19);
            this.RadioBtnMusic.TabIndex = 9;
            this.RadioBtnMusic.Text = "Play/Stop Music";
            this.RadioBtnMusic.UseVisualStyleBackColor = true;
            this.RadioBtnMusic.CheckedChanged += new System.EventHandler(this.BtnRadioEvent);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::Scoala_Informala_EDU.Properties.Resources.MainBackround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.RadioBtnMusic);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.btnLearn);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoala Informala EDU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.CheckBox RadioBtnMusic;
    }
}

