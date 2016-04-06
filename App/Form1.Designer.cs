namespace Roulette_App
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.RouletteImg2 = new System.Windows.Forms.PictureBox();
            this.RoulleteImg1 = new System.Windows.Forms.PictureBox();
            this.ImgPin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RouletteImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoulleteImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImgPin);
            this.panel1.Controls.Add(this.RouletteImg2);
            this.panel1.Controls.Add(this.RoulleteImg1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 32);
            this.panel1.TabIndex = 1;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(323, 50);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(65, 23);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "--->";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 50);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // RouletteImg2
            // 
            this.RouletteImg2.Image = global::Roulette_App.Properties.Resources.Roulette;
            this.RouletteImg2.ImageLocation = "";
            this.RouletteImg2.Location = new System.Drawing.Point(230, 3);
            this.RouletteImg2.Name = "RouletteImg2";
            this.RouletteImg2.Size = new System.Drawing.Size(925, 25);
            this.RouletteImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RouletteImg2.TabIndex = 2;
            this.RouletteImg2.TabStop = false;
            // 
            // RoulleteImg1
            // 
            this.RoulleteImg1.Image = global::Roulette_App.Properties.Resources.Roulette;
            this.RoulleteImg1.ImageLocation = "";
            this.RoulleteImg1.Location = new System.Drawing.Point(0, 3);
            this.RoulleteImg1.Name = "RoulleteImg1";
            this.RoulleteImg1.Size = new System.Drawing.Size(925, 25);
            this.RoulleteImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoulleteImg1.TabIndex = 0;
            this.RoulleteImg1.TabStop = false;
            // 
            // ImgPin
            // 
            this.ImgPin.Image = global::Roulette_App.Properties.Resources.Pin;
            this.ImgPin.Location = new System.Drawing.Point(199, 3);
            this.ImgPin.Name = "ImgPin";
            this.ImgPin.Size = new System.Drawing.Size(2, 25);
            this.ImgPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPin.TabIndex = 4;
            this.ImgPin.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 546);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RouletteImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoulleteImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RoulleteImg1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox RouletteImg2;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox ImgPin;
    }
}

