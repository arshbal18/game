using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assiment_russinan_roullete
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }
        shooted obj_shooted=new shooted();
        private void loadedbtn_Click(object sender, EventArgs e)
        {
            spinedbtn.Enabled = true;//it enables the spin button
            loadedbtn.Enabled = false;//it disables the load button
            pictureBox1.Visible = true;
            obj_shooted.loaded = 1;//it sets the value of loaded to 1
            
            pictureBox1.Image = Image.FromFile(@"C:\Users\Akash bal\Desktop\assiment russinan_roullete\res\load.gif");// it is for the picture box
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Akash bal\Desktop\assiment russinan_roullete\res\load.wav");

        }

        private void spinedbtn_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\Akash bal\Desktop\assiment russinan_roullete\res\spin.gif");//it is for the piture box
            pictureBox1.Image = img;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Akash bal\Desktop\assiment russinan_roullete\res\spin.wav");//it is for the sound
            player.Play();

            Random rnd = new Random();
            obj_shooted.spined = rnd.Next(1, 7);//it sets the value of spined from 1 to 7 
          
            shootedbtn.Enabled = true;
            spinedbtn .Enabled = false;
        }

        private void shootbtn_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\Akash bal\Desktop\assiment russinan_roullete\res\shoot.gif");//it is for the piture box
            pictureBox1.Image = img;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Akash bal\Desktop\assiment russinan_roullete\res\shoot.wav");//it is for the sound
            player.Play();
            obj_shooted .sco = obj_shooted.mainshoot(0);
            if (obj_shooted.sco == 10)
            {
                MessageBox.Show("You Won score=10");
                shootedbtn.Enabled = false;//it disables the shooted button
            }
            else if (obj_shooted.sco == 5)
            {
                MessageBox.Show("You Won score=5");
                shootedbtn.Enabled = false;//it disables the shooted button

            }
            else
            {
                MessageBox.Show("You losse");
                shootedbtn.Enabled = false;//it disables the shooted button

            }
        }

        private void pybtn_Click(object sender, EventArgs e)
        {
            (new game()).Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
