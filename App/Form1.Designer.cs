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
            this.RoulleteImg1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RouletteImg2 = new System.Windows.Forms.PictureBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RoulleteImg1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RouletteImg2)).BeginInit();
            this.SuspendLayout();
            // 
            // RoulleteImg1
            // 
            this.RoulleteImg1.ImageLocation = "C:\\Users\\Marcel\\Pictures\\Roulette.png";
            this.RoulleteImg1.Location = new System.Drawing.Point(0, 3);
            this.RoulleteImg1.Name = "RoulleteImg1";
            this.RoulleteImg1.Size = new System.Drawing.Size(925, 25);
            this.RoulleteImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoulleteImg1.TabIndex = 0;
            this.RoulleteImg1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RouletteImg2);
            this.panel1.Controls.Add(this.RoulleteImg1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 32);
            this.panel1.TabIndex = 1;
            // 
            // RouletteImg2
            // 
            this.RouletteImg2.ImageLocation = "C:\\Users\\Marcel\\Pictures\\Roulette.png";
            this.RouletteImg2.Location = new System.Drawing.Point(230, 3);
            this.RouletteImg2.Name = "RouletteImg2";
            this.RouletteImg2.Size = new System.Drawing.Size(925, 25);
            this.RouletteImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RouletteImg2.TabIndex = 2;
            this.RouletteImg2.TabStop = false;
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
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(242, 50);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Goto Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 546);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoulleteImg1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RouletteImg2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RoulleteImg1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox RouletteImg2;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnNext;
    }
}

