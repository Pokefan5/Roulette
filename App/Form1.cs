using System;
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

        public int[] LocArr = new int[37];
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
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

        }

        private async void btnRight_Click(object sender, EventArgs e)
        {
            double vel = 20;
            while (vel > 0)
            {
                Point R1Loc = RoulleteImg1.Location;
                Point R2Loc = RoulleteImg1.Location;

                R1Loc.X = Convert.ToInt32(Math.Round(R1Loc.X + vel, 0));

                if (R1Loc.X > 925)
                {
                    R1Loc.X = R1Loc.X - 925;
                }

                R2Loc.X = R1Loc.X - 925;

                RoulleteImg1.Location = R1Loc;
                RouletteImg2.Location = R2Loc;

                vel = vel * .99;

                if (vel < 1)
                {
                    vel = 1;
                }

                await Task.Delay(1);
            }
        }
        //185
        private async void btnNext_Click(object sender, EventArgs e)
        {
            Point R1Loc = RoulleteImg1.Location;
            Point R2Loc = RoulleteImg1.Location;

            Wheel whl = new Wheel();
            Random rdn = new Random();
            int x = Convert.ToInt32(whl.Play());
            double vel = 20 + rdn.Next(0, 10);

            while ((R1Loc.X < LocArr[x] - 6 || R1Loc.X > LocArr[x] + 6) || vel > 5)
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
        }


    }
}
