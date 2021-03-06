﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        User usr = Program.usr;

        public int[] LocArr = new int[37];

        public int[] NumbersRed = new int[18];
        public int[] NumbersBlack = new int[18];
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            txtBalance.Text = usr.Money.ToString(); //actual Balance
            txtWinLose.Text = "0"; //win or lose in the actual round
            txtBet.Maximum = usr.Money; 

            Point R1Loc = RoulleteImg1.Location;
            Point R2Loc = RoulleteImg1.Location;

            R2Loc.X = R1Loc.X - 925;

            RoulleteImg1.Location = R1Loc;
            RouletteImg2.Location = R2Loc;

            LocArr[0] = 188;
            LocArr[32] = 163;
            LocArr[15] = 138;
            LocArr[19] = 113;
            LocArr[4] = 88;
            LocArr[21] = 63;
            LocArr[2] = 38;
            LocArr[25] = 13;
            LocArr[17] = 913;
            LocArr[34] = 888;
            LocArr[6] = 863;
            LocArr[27] = 838;
            LocArr[13] = 813;
            LocArr[36] = 788;
            LocArr[11] = 763;
            LocArr[30] = 738;
            LocArr[8] = 713;
            LocArr[23] = 688;
            LocArr[10] = 663;
            LocArr[5] = 638;
            LocArr[24] = 613;
            LocArr[16] = 588;
            LocArr[33] = 563;
            LocArr[1] = 538;
            LocArr[20] = 513;
            LocArr[14] = 488;
            LocArr[31] = 463;
            LocArr[9] = 438;
            LocArr[22] = 413;
            LocArr[18] = 388;
            LocArr[29] = 363;
            LocArr[7] = 338;
            LocArr[28] = 313;
            LocArr[12] = 288;
            LocArr[35] = 263;
            LocArr[3] = 238;
            LocArr[26] = 213;

            NumbersBlack[0] = 15;
            NumbersBlack[1] = 4;
            NumbersBlack[2] = 2;
            NumbersBlack[3] = 17;
            NumbersBlack[4] = 6;
            NumbersBlack[5] = 13;
            NumbersBlack[6] = 11;
            NumbersBlack[7] = 8;
            NumbersBlack[8] = 10;
            NumbersBlack[9] = 24;
            NumbersBlack[10] = 33;
            NumbersBlack[11] = 20;
            NumbersBlack[12] = 31;
            NumbersBlack[13] = 22;
            NumbersBlack[14] = 29;
            NumbersBlack[15] = 28;
            NumbersBlack[16] = 35;
            NumbersBlack[17] = 26;

            NumbersRed[0] = 32;
            NumbersRed[1] = 19;
            NumbersRed[2] = 21;
            NumbersRed[3] = 25;
            NumbersRed[4] = 34;
            NumbersRed[5] = 27;
            NumbersRed[6] = 36;
            NumbersRed[7] = 30;
            NumbersRed[8] = 23;
            NumbersRed[9] = 5;
            NumbersRed[10] = 16;
            NumbersRed[11] = 1;
            NumbersRed[12] = 14;
            NumbersRed[13] = 9;
            NumbersRed[14] = 18;
            NumbersRed[15] = 7;
            NumbersRed[16] = 12;
            NumbersRed[17] = 3;

            updateBalance();
        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            disableAll();               //Freeze input fields to avoid errors

            bool won = false;

            int multiplier = 2;

            Point R1Loc = RoulleteImg1.Location;
            Point R2Loc = RoulleteImg1.Location;

            Wheel whl = new Wheel();
            Random rdn = new Random();

            int goal = Convert.ToInt32(whl.Play());
            int bet = Convert.ToInt32(txtBet.Value);
            int betNr = Convert.ToInt32(txtNumber.Value);
            double vel = 20 + rdn.Next(0, 10);

            string history;

            //MessageBox.Show(goal.ToString());

            
            while ((R1Loc.X < LocArr[goal] - 6 || R1Loc.X > LocArr[goal] + 6) || vel > 5)
            {

                R1Loc.X = Convert.ToInt32(Math.Round(R1Loc.X + vel, 0));

                if (R1Loc.X > 925)
                {
                    R1Loc.X = R1Loc.X - 925;
                }

                R2Loc.X = R1Loc.X - 925;

                RoulleteImg1.Location = R1Loc;
                RouletteImg2.Location = R2Loc;

                vel = vel * .99;

                if (vel < 5)
                {
                    vel = 5;
                }

                await Task.Delay(1);
            }
            

            if (rdoNumber.Checked == true)          //check if number is given number when user checked 'Number' Radio Button
            {
                won = checkNumber(betNr, goal);
                multiplier = 34;
            }
            else if (rdo1Dozen.Checked == true)     //check if number is in the first dozen when user checked 'Dozen 1' Radio Button
            {
                won = checkDozend1(goal);
                multiplier = 2;
            }
            else if (rdo2Dozen.Checked == true)     //check if number is in the second dozen when user checked 'Dozen 2' Radio Button
            {
                won = checkDozend2(goal);
                multiplier = 2;
            }
            else if (rdo3Dozen.Checked == true)     //check if number is in the third dozen when user checked 'Dozen 3' Radio Button
            {
                won = checkDozend3(goal);
                multiplier = 2;
            }
            else if (rdoBlack.Checked == true)      //check if number is on the black half when user checked 'Black' Radio Button
            {
                won = checkBlack(goal);
                multiplier = 1;
            }
            else if (rdoRed.Checked == true)        //check if number is on the red half when user checked 'Red' Radio Button
            {
                won = checkRed(goal);
                multiplier = 1;
            }
            else                                    //handle error when no Radio Button is selected (this should not happen)
            {
                won = true;
                multiplier = 0;
                MessageBox.Show("Something went wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (won == true)                        //award user with points if he won
            {
                usr.Money += bet * multiplier;
                txtWinLose.Text = (bet * multiplier).ToString();
                txtWinLose.ForeColor = Color.Green;
                MessageBox.Show(usr.Name + " won " + (bet * multiplier).ToString() + " Points!", "You Won", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else                                    //deduct points from user if he lost
            {
                usr.Money -= bet;
                txtWinLose.Text = "-" + bet.ToString();
                txtWinLose.ForeColor = Color.Red;
                MessageBox.Show(usr.Name + " lost " + bet.ToString() + " Points!", "You Lost", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            history = goal.ToString();

            if(checkBlack(goal) == true)
            {
                history += ", black";
            }
            else
            {
                history += ", red";
            }
            if(checkDozend1(goal) == true)
            {
                history += ", dozen 1";
            }
            else if(checkDozend2(goal) == true)
            {
                history += ", dozen 2";
            }
            else
            {
                history += ", dozen 3";
            }
            lboHistory.Items.Insert(0, history);
            
            if (lboHistory.Items.Count > 7)
            {
                lboHistory.Items.RemoveAt(7);
            }

            enableAll();

            btnPlay.Focus();
        }

        private void rdoNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNumber.Checked == true)
            {
                txtNumber.ReadOnly = false;
            }
            else
            {
                txtNumber.ReadOnly = true;
            }
        }

        private bool checkDozend1 (int number)
        {
            bool ret;

            if (number > 0 && number < 13)
            {
                ret = true;
            }
            else
            {
                ret = false;
            }

            return ret;
        }

        private bool checkDozend2 (int number)
        {
            bool ret;

            if (number > 12 && number < 25)
            {
                ret = true;
            }
            else
            {
                ret = false;
            }

            return ret;
        }

        private bool checkDozend3 (int number)
        {
            bool ret;

            if (number > 24 && number < 37)
            {
                ret = true;
            }
            else
            {
                ret = false;
            }

            return ret;
        }

        private bool checkRed(int number)
        {
            bool ret;

            if (NumbersRed.Contains(number))
            {
                ret = true;
            }
            else
            {
                ret = false;
            }

            return ret;
        }

        private bool checkBlack(int number)
        {
            bool ret;

            if (NumbersBlack.Contains(number))
            {
                ret = true;
            }
            else
            {
                ret = false;
            }

            return ret;
        }

        private bool checkNumber(int number, int winningnumber)
        {
            bool ret;

            if (number == winningnumber)
            {
                ret = true;
            }
            else
            {
                ret = false;
            }

            return ret;
        }

        private void disableAll ()
        {
            rdo1Dozen.Enabled = false;
            rdo2Dozen.Enabled = false;
            rdo3Dozen.Enabled = false;
            rdoBlack.Enabled = false;
            rdoNumber.Enabled = false;
            rdoRed.Enabled = false;
            txtBet.Enabled = false;
            txtNumber.Enabled = false;
            btnPlay.Enabled = false;
        }

        private void enableAll()
        {
            rdo1Dozen.Enabled = true;
            rdo2Dozen.Enabled = true;
            rdo3Dozen.Enabled = true;
            rdoBlack.Enabled = true;
            rdoNumber.Enabled = true;
            rdoRed.Enabled = true;
            txtBet.Enabled = true;
            txtNumber.Enabled = true;
            btnPlay.Enabled = true;
        }

        private async void updateBalance()
        {
            while (true)
            {
                txtBalance.Text = usr.Money.ToString();
                txtBet.Maximum = usr.Money;
                await Task.Delay(1);
            }
        }

        private void panelMoney_Click(object sender, EventArgs e)
        {
            usr.Money += 100;
        }
        private void lblHelp_MouseEnter(object sender, EventArgs e)
        {
            Point helploc = lblHelp.Location;
            helploc.Y += 20;
            toolTipHelp.Show("At first you must set a bet.\nThen you have the choice\nbetween a number, a dozen or\na color.Select one and press\nthe play button.Now the\nprogramm tells you the\namount of what you have won\nor lost.\nTry again.", this, helploc, 10000);
        }
    }
}
