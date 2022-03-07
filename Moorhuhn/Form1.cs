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
    public partial class Form1 : Form
    {

        // List<PictureBox> items = new List<PictureBox>();
        PictureBox _box = null;
        Random rnd = new Random();
        Boolean start = false;
        int counter = 0;
        int time = 10;

        public Form1()
        {
            InitializeComponent();
            _box = new PictureBox();
            _box.Click += new EventHandler(PictureBoxClick);
            Controls.Add(_box);
            _box.Hide();
            
            lblTimer.Text = "Timeleft: "+time+" seconds";
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            start = true;
            
            timerTimeLeft.Start();

        }

        private void MakePictureBox()
        {
            if (_box == null)
                _box = new PictureBox();

            _box.Width = 50;
            _box.Height = 50;
            _box.BackColor = Color.Red;
            int x = rnd.Next(10, this.ClientSize.Width - _box.Width);
            int y = rnd.Next(100, this.ClientSize.Height - _box.Height);
            _box.Location = new Point(x, y);
            _box.Show();
            // items.Add(box);

        }

        private void PictureBoxClick(object sender, EventArgs e)
        {

            if (sender is PictureBox && start == true)
            {
                PictureBox box = (PictureBox)sender;
                //items.Remove(box);
                box.Hide();
                // Controls.Remove(box);
                counter++;

                lblTreffer.Text = "Score: " + counter;
            }

        }


        private void timerDelete_Tick(object sender, EventArgs e)
        {

            int i = rnd.Next(0, 5);

            if (start == true && i > 0 && i < 5)
            {
                MakePictureBox();

            }

        }

        private void timerTimeLeft_Tick(object sender, EventArgs e)
        {
            time--;
            lblTimer.Text = "Timeleft: " + time + " seconds";

            if (time == 0)
            {
                timerTimeLeft.Stop();
                start = false;
            }
        }
    }
}