using System;
using System.IO;
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
    public partial class Highscore : Form
    {



        public Highscore()
        {
            InitializeComponent();        
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            txtHighscore.Text = txtName.Text +": "+ Form1.counter + " of " + Form1.totalcount;
            Form1.counter = 0;
            Form1.totalcount = 0;
        }
    }
}
