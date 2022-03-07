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
                
            }

        }

        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            rbEasy.Checked = true;
            
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            rbMedium.Checked = true;
            
        }

        private void rbHard_CheckedChanged(object sender, EventArgs e)
        {
            rbHard.Checked = true;
            
        }
    }
}
