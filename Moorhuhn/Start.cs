using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moorhuhn
{
    public partial class Start : Form
    {

        

        public Start()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(rbEasy.Checked == true || rbMedium.Checked == true || rbHard.Checked == true)
            {
                Form1 setForm = new Form1();
                setForm.Show();
                this.Hide();
            }
            else
            {
                lblChooseDifficulty.Text = "Choose a difficulty!";
            }

        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Dou you really wanna quit?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }



        }
    }
}
