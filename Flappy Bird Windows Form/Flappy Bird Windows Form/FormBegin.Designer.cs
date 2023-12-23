namespace Flappy_Bird_Windows_Form
{
    partial class FormBegin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBegin));
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHighestScore = new System.Windows.Forms.Button();
            this.HighestScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(371, 357);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(190, 108);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(192)))), ((int)(((byte)(202)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("VNI-Truck", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(933, 145);
            this.label1.TabIndex = 1;
            this.label1.Text = "FLAPPY BIRD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHighestScore
            // 
            this.btnHighestScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnHighestScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHighestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighestScore.Location = new System.Drawing.Point(371, 507);
            this.btnHighestScore.Name = "btnHighestScore";
            this.btnHighestScore.Size = new System.Drawing.Size(190, 108);
            this.btnHighestScore.TabIndex = 0;
            this.btnHighestScore.Text = "HIGHEST SCORE";
            this.btnHighestScore.UseVisualStyleBackColor = false;
            this.btnHighestScore.Click += new System.EventHandler(this.btnHighestScore_Click);
            // 
            // HighestScore
            // 
            this.HighestScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(192)))), ((int)(((byte)(202)))));
            this.HighestScore.Font = new System.Drawing.Font("VNI-Truck", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighestScore.ForeColor = System.Drawing.Color.Yellow;
            this.HighestScore.Location = new System.Drawing.Point(315, 135);
            this.HighestScore.Name = "HighestScore";
            this.HighestScore.Size = new System.Drawing.Size(304, 82);
            this.HighestScore.TabIndex = 2;
            this.HighestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.flappybirdsgif_zmhh_1400166618;
            this.pictureBox1.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.flappybirdsgif_zmhh_1400166618;
            this.pictureBox1.Location = new System.Drawing.Point(0, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(933, 635);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(933, 753);
            this.Controls.Add(this.HighestScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHighestScore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBegin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBegin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHighestScore;
        private System.Windows.Forms.Label HighestScore;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}