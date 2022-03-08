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
        PictureBox _box2 = null;
        Random rnd = new Random();
        Boolean start = false;
        int counter = 0;
        int time = 20;
        Start obj = new Start();

        public Form1()
        {
            InitializeComponent();
          
            _box = new PictureBox();
            _box.Click += new EventHandler(PictureBoxClick);
            Controls.Add(_box);
            _box.Hide();

            _box2 = new PictureBox();
            _box2.Click += new EventHandler(PictureBoxClick);
            Controls.Add(_box2);
            _box2.Hide();



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
        private void MakePictureBox2()
        {
            if (_box2 == null)
                _box2 = new PictureBox();

            _box2.Width = 50;
            _box2.Height = 50;
            _box2.BackColor = Color.Red;
            int x = rnd.Next(10, this.ClientSize.Width - _box2.Width);
            int y = rnd.Next(100, this.ClientSize.Height - _box2.Height);
            _box2.Location = new Point(x, y);
            _box2.Show();
            // items.Add(box);

        }

        private void PictureBoxClick(object sender, EventArgs e)
        {

            if (sender is PictureBox && start == true)
            {
                PictureBox box = (PictureBox)sender;
                box.Hide();
                counter++;

                lblTreffer.Text = "Score: " + counter;
            }
        }


        private void timerDelete_Tick(object sender, EventArgs e)
        {
           
           int i = rnd.Next(0, 10);

            if (start == true && i > 0 && i < 10)
            {
                MakePictureBox();
            }

        }
        private void timerDelete2_Tick(object sender, EventArgs e)
        {
                int i = rnd.Next(0, 10);

                if (start == true && i > 0 && i < 10)
                {
                    if (obj.medium == true || obj.hard == true)
                    {
                        MakePictureBox2();
                    }

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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start setForm = new Start();
            setForm.Show();
        }

        
    }
}