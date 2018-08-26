using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BulletGame
{
    public partial class Form1 : Form
    {
        private char[] bulletArray = new char[6];
        private int noOfBullets =0;
        private int rand;
        private int count = 0;
        private int score = 0;
        private int id = 0;
        private SoundPlayer  gunFire,gunLoad,shellFall,spinBullet,bulletEmpty; 

        public Form1()
        {
            InitializeComponent();
            gunFire = new SoundPlayer(@"gunfire.wav");
            gunLoad = new SoundPlayer(@"loadgun.wav");
            shellFall = new SoundPlayer(@"shellFall.wav");
            spinBullet =  new SoundPlayer(@"spinBullet.wav");
            bulletEmpty = new SoundPlayer(@"bulletEmpty.wav");
            for (int i = 0; i < 6; i++)
            {
                bulletArray[i] = '_';
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Load :
            if(noOfBullets <6)
            {
                noOfBullets = 1;
                label1.Text = "Bullet Loaded ";
                pictureBox1.Image = Image.FromFile(@"1gs.jpg");
                gunLoad.Play();
                    if (bulletArray[id] == '_')
                    {
                        bulletArray[id] = 'B';
                    }
                id++;
                
            }
            else
                MessageBox.Show("Space Not Available");
                
        }

        private int idx = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            //Fire Bullet
            if(noOfBullets >0)
            {
                
                if (bulletArray[idx] == 'B')
                {
                    pictureBox1.Image = Image.FromFile(@"0gs.jpg");
                    pictureBox2.Image = Image.FromFile(@"shoot.png");
                    bulletArray[idx] = '_';
                    gunFire.Play();
                   // shellFall.Play();
                    noOfBullets = 0;
                    count =0;
                  //  score += 1;
                    textBox2.Text = "You Win";
                    MessageBox.Show("You Win");

                }
                else
                {
                    idx++;
                    bulletEmpty.Play();
                    MessageBox.Show("Missed Fire ");
                    pictureBox1.Image = Image.FromFile(@""+(Convert .ToInt32 (rand - idx) + 1) +"gs.jpg");
                    count ++;
                    if (count >= 2)
                    {
                        textBox2.Text = "You Loss";
                        MessageBox.Show("You Loss");

                       // count = 0;
                       // score = 0;
                    }
                    
                }

                   
                
            }
            else
            {
                gunLoad.Play();
                pictureBox1.Image = Image.FromFile(@"0gs.jpg");
               MessageBox.Show("Sorry! you have no Bullets.");
            }
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Play Again: 
            label1.Text = "Empty Bullet";
            pictureBox1.Image = Image.FromFile(@"0gs.jpg");
            pictureBox2.Image = Image.FromFile(@"bird.gif");
            noOfBullets = 0;
            count = 0;
            score = 0;
            id = 0;
            idx = 0;
          
            textBox2.Text = "";
            for (int i = 0; i < 6; i++)
            {
                bulletArray[i] = '_';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         //   spining
            if (noOfBullets > 0)
            {
                Random rnd = new Random();
                rand = rnd.Next(1, 7)-1;
                spinBullet.Play();
                pictureBox1.Image = Image.FromFile(@""+ (rand + 1) +"gs.jpg");
                for(int i=0;i<6;i++)
                    if(bulletArray [i]=='B')
                    {
                        bulletArray[i] = '_';
                        bulletArray[rand] = 'B';
                    }
            }
            else
                MessageBox.Show("Sorry! you have no Bullets.\nPlaese Load Bullet First");
        /*    bulletString = "";
            for (int i = 0; i < 6; i++)
            {
                bulletString += bulletArray[i] + ",";
            }
            textBox3.Text = bulletString;
            */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
