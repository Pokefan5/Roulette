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
            this.ImgPin = new System.Windows.Forms.PictureBox();
            this.RouletteImg2 = new System.Windows.Forms.PictureBox();
            this.RoulleteImg1 = new System.Windows.Forms.PictureBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoNumber = new System.Windows.Forms.RadioButton();
            this.rdo1Dozen = new System.Windows.Forms.RadioButton();
            this.rdo2Dozen = new System.Windows.Forms.RadioButton();
            this.rdo3Dozen = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoBlack = new System.Windows.Forms.RadioButton();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouletteImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoulleteImg1)).BeginInit();
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
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select, on what do you want to bet:";
            // 
            // rdoNumber
            // 
            this.rdoNumber.AutoSize = true;
            this.rdoNumber.Location = new System.Drawing.Point(15, 191);
            this.rdoNumber.Name = "rdoNumber";
            this.rdoNumber.Size = new System.Drawing.Size(92, 17);
            this.rdoNumber.TabIndex = 5;
            this.rdoNumber.TabStop = true;
            this.rdoNumber.Text = "Number (0-36)";
            this.rdoNumber.UseVisualStyleBackColor = true;
            // 
            // rdo1Dozen
            // 
            this.rdo1Dozen.AutoSize = true;
            this.rdo1Dozen.Location = new System.Drawing.Point(15, 215);
            this.rdo1Dozen.Name = "rdo1Dozen";
            this.rdo1Dozen.Size = new System.Drawing.Size(68, 17);
            this.rdo1Dozen.TabIndex = 6;
            this.rdo1Dozen.TabStop = true;
            this.rdo1Dozen.Text = "1. Dozen";
            this.rdo1Dozen.UseVisualStyleBackColor = true;
            // 
            // rdo2Dozen
            // 
            this.rdo2Dozen.AutoSize = true;
            this.rdo2Dozen.Location = new System.Drawing.Point(15, 239);
            this.rdo2Dozen.Name = "rdo2Dozen";
            this.rdo2Dozen.Size = new System.Drawing.Size(68, 17);
            this.rdo2Dozen.TabIndex = 7;
            this.rdo2Dozen.TabStop = true;
            this.rdo2Dozen.Text = "2. Dozen";
            this.rdo2Dozen.UseVisualStyleBackColor = true;
            // 
            // rdo3Dozen
            // 
            this.rdo3Dozen.AutoSize = true;
            this.rdo3Dozen.Location = new System.Drawing.Point(15, 263);
            this.rdo3Dozen.Name = "rdo3Dozen";
            this.rdo3Dozen.Size = new System.Drawing.Size(68, 17);
            this.rdo3Dozen.TabIndex = 8;
            this.rdo3Dozen.TabStop = true;
            this.rdo3Dozen.Text = "3. Dozen";
            this.rdo3Dozen.UseVisualStyleBackColor = true;
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(15, 287);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(45, 17);
            this.rdoRed.TabIndex = 9;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            // 
            // rdoBlack
            // 
            this.rdoBlack.AutoSize = true;
            this.rdoBlack.Location = new System.Drawing.Point(15, 311);
            this.rdoBlack.Name = "rdoBlack";
            this.rdoBlack.Size = new System.Drawing.Size(52, 17);
            this.rdoBlack.TabIndex = 10;
            this.rdoBlack.TabStop = true;
            this.rdoBlack.Text = "Black";
            this.rdoBlack.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(113, 191);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bet: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Won/Lose";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Balance";
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(303, 236);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(100, 20);
            this.txtBet.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(303, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(303, 284);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 346);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.rdoBlack);
            this.Controls.Add(this.rdoRed);
            this.Controls.Add(this.rdo3Dozen);
            this.Controls.Add(this.rdo2Dozen);
            this.Controls.Add(this.rdo1Dozen);
            this.Controls.Add(this.rdoNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouletteImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoulleteImg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RoulleteImg1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox RouletteImg2;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox ImgPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoNumber;
        private System.Windows.Forms.RadioButton rdo1Dozen;
        private System.Windows.Forms.RadioButton rdo2Dozen;
        private System.Windows.Forms.RadioButton rdo3Dozen;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoBlack;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

