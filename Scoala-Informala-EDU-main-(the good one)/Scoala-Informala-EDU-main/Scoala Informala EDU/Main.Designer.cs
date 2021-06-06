
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
            this.components = new System.ComponentModel.Container();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnJob = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSoundOFF = new System.Windows.Forms.Button();
            this.btnSoundON = new System.Windows.Forms.Button();
            this.lblSound = new System.Windows.Forms.Label();
            this.TextScrolling = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            // btnJob
            // 
            this.btnJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJob.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnJob.FlatAppearance.BorderSize = 2;
            this.btnJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJob.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnJob.Location = new System.Drawing.Point(36, 332);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(194, 43);
            this.btnJob.TabIndex = 2;
            this.btnJob.Text = "Job Interview Tips";
            this.btnJob.UseVisualStyleBackColor = true;
            this.btnJob.Click += new System.EventHandler(this.JobClickEvent);
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
            // btnSoundOFF
            // 
            this.btnSoundOFF.BackgroundImage = global::Scoala_Informala_EDU.Properties.Resources.MusicOFF;
            this.btnSoundOFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSoundOFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoundOFF.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSoundOFF.Location = new System.Drawing.Point(916, 12);
            this.btnSoundOFF.Name = "btnSoundOFF";
            this.btnSoundOFF.Size = new System.Drawing.Size(56, 55);
            this.btnSoundOFF.TabIndex = 10;
            this.btnSoundOFF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSoundOFF.UseVisualStyleBackColor = true;
            this.btnSoundOFF.Click += new System.EventHandler(this.SoundOffEvent);
            // 
            // btnSoundON
            // 
            this.btnSoundON.BackgroundImage = global::Scoala_Informala_EDU.Properties.Resources.MusicON;
            this.btnSoundON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSoundON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoundON.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSoundON.Location = new System.Drawing.Point(916, 12);
            this.btnSoundON.Name = "btnSoundON";
            this.btnSoundON.Size = new System.Drawing.Size(56, 55);
            this.btnSoundON.TabIndex = 11;
            this.btnSoundON.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSoundON.UseVisualStyleBackColor = true;
            this.btnSoundON.Visible = false;
            this.btnSoundON.Click += new System.EventHandler(this.SoundOnEvent);
            // 
            // lblSound
            // 
            this.lblSound.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSound.Location = new System.Drawing.Point(916, 70);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(56, 35);
            this.lblSound.TabIndex = 12;
            this.lblSound.Text = "Sound ON/OFF";
            this.lblSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextScrolling
            // 
            this.TextScrolling.AutoSize = true;
            this.TextScrolling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TextScrolling.Location = new System.Drawing.Point(12, 12);
            this.TextScrolling.Name = "TextScrolling";
            this.TextScrolling.Size = new System.Drawing.Size(38, 15);
            this.TextScrolling.TabIndex = 13;
            this.TextScrolling.Text = "label1";
            this.TextScrolling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::Scoala_Informala_EDU.Properties.Resources.MainBackround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.TextScrolling);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.btnSoundON);
            this.Controls.Add(this.btnSoundOFF);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnJob);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.btnLearn);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoala Informala EDU";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnJob;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSoundOFF;
        private System.Windows.Forms.Button btnSoundON;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Label TextScrolling;
        private System.Windows.Forms.Timer timer1;
    }
}

