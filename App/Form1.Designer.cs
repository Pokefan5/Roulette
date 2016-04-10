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
            this.panelWheel = new System.Windows.Forms.Panel();
            this.ImgPin = new System.Windows.Forms.PictureBox();
            this.RouletteImg2 = new System.Windows.Forms.PictureBox();
            this.RoulleteImg1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.rdoNumber = new System.Windows.Forms.RadioButton();
            this.rdo1Dozen = new System.Windows.Forms.RadioButton();
            this.rdo2Dozen = new System.Windows.Forms.RadioButton();
            this.rdo3Dozen = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoBlack = new System.Windows.Forms.RadioButton();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtWinLose = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.NumericUpDown();
            this.txtBet = new System.Windows.Forms.NumericUpDown();
            this.panelMoney = new System.Windows.Forms.Panel();
            this.panelWheel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouletteImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoulleteImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWheel
            // 
            this.panelWheel.Controls.Add(this.ImgPin);
            this.panelWheel.Controls.Add(this.RouletteImg2);
            this.panelWheel.Controls.Add(this.RoulleteImg1);
            this.panelWheel.Location = new System.Drawing.Point(12, 12);
            this.panelWheel.Name = "panelWheel";
            this.panelWheel.Size = new System.Drawing.Size(400, 32);
            this.panelWheel.TabIndex = 1;
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
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(12, 175);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(175, 13);
            this.lblSelect.TabIndex = 4;
            this.lblSelect.Text = "Select, on what do you want to bet:";
            // 
            // rdoNumber
            // 
            this.rdoNumber.AutoSize = true;
            this.rdoNumber.Checked = true;
            this.rdoNumber.Location = new System.Drawing.Point(15, 191);
            this.rdoNumber.Name = "rdoNumber";
            this.rdoNumber.Size = new System.Drawing.Size(92, 17);
            this.rdoNumber.TabIndex = 5;
            this.rdoNumber.TabStop = true;
            this.rdoNumber.Text = "Number (0-36)";
            this.rdoNumber.UseVisualStyleBackColor = true;
            this.rdoNumber.CheckedChanged += new System.EventHandler(this.rdoNumber_CheckedChanged);
            // 
            // rdo1Dozen
            // 
            this.rdo1Dozen.AutoSize = true;
            this.rdo1Dozen.Location = new System.Drawing.Point(15, 215);
            this.rdo1Dozen.Name = "rdo1Dozen";
            this.rdo1Dozen.Size = new System.Drawing.Size(68, 17);
            this.rdo1Dozen.TabIndex = 6;
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
            this.rdoBlack.Text = "Black";
            this.rdoBlack.UseVisualStyleBackColor = true;
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Location = new System.Drawing.Point(268, 241);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(29, 13);
            this.lblBet.TabIndex = 12;
            this.lblBet.Text = "Bet: ";
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.Location = new System.Drawing.Point(239, 263);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(55, 13);
            this.lblWinLose.TabIndex = 13;
            this.lblWinLose.Text = "Won/Lost";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(251, 287);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 14;
            this.lblBalance.Text = "Balance";
            // 
            // txtWinLose
            // 
            this.txtWinLose.BackColor = System.Drawing.Color.White;
            this.txtWinLose.Location = new System.Drawing.Point(303, 262);
            this.txtWinLose.Name = "txtWinLose";
            this.txtWinLose.ReadOnly = true;
            this.txtWinLose.Size = new System.Drawing.Size(100, 20);
            this.txtWinLose.TabIndex = 16;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.Location = new System.Drawing.Point(303, 284);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 17;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(113, 191);
            this.txtNumber.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(47, 20);
            this.txtNumber.TabIndex = 18;
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(303, 239);
            this.txtBet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(100, 20);
            this.txtBet.TabIndex = 19;
            // 
            // panelMoney
            // 
            this.panelMoney.Location = new System.Drawing.Point(405, 330);
            this.panelMoney.Name = "panelMoney";
            this.panelMoney.Size = new System.Drawing.Size(17, 17);
            this.panelMoney.TabIndex = 20;
            this.panelMoney.Click += new System.EventHandler(this.panelMoney_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 346);
            this.Controls.Add(this.panelMoney);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtWinLose);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.rdoBlack);
            this.Controls.Add(this.rdoRed);
            this.Controls.Add(this.rdo3Dozen);
            this.Controls.Add(this.rdo2Dozen);
            this.Controls.Add(this.rdo1Dozen);
            this.Controls.Add(this.rdoNumber);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.panelWheel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelWheel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouletteImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoulleteImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RoulleteImg1;
        private System.Windows.Forms.Panel panelWheel;
        private System.Windows.Forms.PictureBox RouletteImg2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox ImgPin;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.RadioButton rdoNumber;
        private System.Windows.Forms.RadioButton rdo1Dozen;
        private System.Windows.Forms.RadioButton rdo2Dozen;
        private System.Windows.Forms.RadioButton rdo3Dozen;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoBlack;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtWinLose;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.NumericUpDown txtNumber;
        private System.Windows.Forms.NumericUpDown txtBet;
        private System.Windows.Forms.Panel panelMoney;
    }
}

