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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                Program.usr.Name = txtUsername.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte gib einen Benutzernamen ein!", "Fehler", MessageBoxButtons.OK);
            }
            
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
