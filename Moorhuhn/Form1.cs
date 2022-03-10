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
        PictureBox _box3 = null;
        Random rnd = new Random();
        Boolean start = false;
        int counter = 0;
        int time = 20;
        int totalcount = 0;
        
        
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

            _box3 = new PictureBox();
            _box3.Click += new EventHandler(PictureBoxClick);
            Controls.Add(_box3);
            _box3.Hide();

            if (Start.level == 1)
            {
                timerDelete2.Enabled = false;
                timerDelete3.Enabled = false;
                
            }
            
            if(Start.level == 2)
            { 
                timerDelete2.Enabled = true;
                timerDelete3.Enabled = false;
            }

            if(Start.level == 3)
            {
                timerDelete2.Enabled = true;
                timerDelete3.Enabled = true;
            }
            Start.level = 0;
            lblTimer.Text = "Timeleft: "+time+" seconds";
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            start = true;
            
            timerTimeLeft.Start();

        }

        private void MakePictureBox()
        {
            totalcount++;
            if (_box == null)
                _box = new PictureBox();

            _box.Width = 50;
            _box.Height = 50;
            _box.BackColor = Color.Red;
            int x = rnd.Next(10, this.ClientSize.Width - _box.Width);
            int y = rnd.Next(100, this.ClientSize.Height - _box.Height);
            _box.Location = new Point(x, y);
            _box.Show();

        }
        private void MakePictureBox2()
        {
            totalcount++;
            if (_box2 == null)
                _box2 = new PictureBox();

            _box2.Width = 50;
            _box2.Height = 50;
            _box2.BackColor = Color.Red;
            int x = rnd.Next(10, this.ClientSize.Width - _box2.Width);
            int y = rnd.Next(100, this.ClientSize.Height - _box2.Height);
            _box2.Location = new Point(x, y);
            _box2.Show();

        }

        private void MakePictureBox3()
        {
            totalcount++;
            if (_box3 == null)
                _box3 = new PictureBox();

            _box3.Width = 50;
            _box3.Height = 50;
            _box3.BackColor = Color.Red;
            int x = rnd.Next(10, this.ClientSize.Width - _box3.Width);
            int y = rnd.Next(100, this.ClientSize.Height - _box3.Height);
            _box3.Location = new Point(x, y);
            _box3.Show();

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
                MakePictureBox2();
            }
        }

        private void timerDelete3_Tick(object sender, EventArgs e)
        {
            int i = rnd.Next(0, 10);

            if (start == true && i > 0 && i < 10)
            {
                MakePictureBox3();
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
                DialogResult dialog = MessageBox.Show("Total Score: " + counter + " of " + totalcount);
                if(dialog == DialogResult.OK)
                {
                    this.Close();
                }
                
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {         
            Start setForm = new Start();
            setForm.Show();

        }

        
    }
}