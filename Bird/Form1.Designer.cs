
namespace Bird
{
    partial class BirdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BirdForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.birdBox = new System.Windows.Forms.PictureBox();
            this.gravity = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 30;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // birdBox
            // 
            this.birdBox.Image = ((System.Drawing.Image)(resources.GetObject("birdBox.Image")));
            this.birdBox.Location = new System.Drawing.Point(30, 120);
            this.birdBox.Name = "birdBox";
            this.birdBox.Size = new System.Drawing.Size(34, 24);
            this.birdBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birdBox.TabIndex = 1;
            this.birdBox.TabStop = false;
            // 
            // gravity
            // 
            this.gravity.Enabled = true;
            this.gravity.Interval = 5;
            this.gravity.Tick += new System.EventHandler(this.gravity_Tick_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(322, 26);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(94, 39);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "label1";
            // 
            // BirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(746, 408);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.birdBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BirdForm";
            this.Text = "FlappyBird --- Dawid Bańczak";
            this.Load += new System.EventHandler(this.BirdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.PictureBox birdBox;
        private System.Windows.Forms.Timer gravity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label scoreLabel;
    }
}

