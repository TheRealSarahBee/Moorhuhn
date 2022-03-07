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
        
        List<PictureBox> items = new List<PictureBox>();
        PictureBox box = new PictureBox();
        Random rnd = new Random();
        Boolean start = false;       
        int counter = 0;
       
        public Form1()
        {
            InitializeComponent();
            
        }
            

        private void btnStart_Click(object sender, EventArgs e)
        {
            start = true;

        }

        private void MakePictureBox()
        {
               
                box.Width = 50;
                box.Height = 50;
                box.BackColor = Color.Red;
                int x = rnd.Next(10, this.ClientSize.Width - box.Width);
                int y = rnd.Next(10, this.ClientSize.Height - box.Height);
                box.Location = new Point(x, y);

                items.Add(box);
                Controls.Add(box);

            
                box.Click += new EventHandler(PictureBoxClick);

        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            
            if (sender is PictureBox)
            {
                PictureBox box = (PictureBox)sender;
                items.Remove(box);
                Controls.Remove(box);
                counter++;
              
                lblTreffer.Text = "Treffer: " + counter;
            }

        }


        private void timerDelete_Tick(object sender, EventArgs e)
        {
            
            int i = rnd.Next(0, 5);

            if(start == true && i>0 && i<5)
            {
                MakePictureBox();
                
            }

            
            

        }
    }
}
