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
using System.IO;
using System.Reflection;

namespace rr_game
{
    public partial class Form1 : Form
    {
        game bndook47 = new game();
        private int shotsRemain = 1;                // This integer holds the value for the bullets to aim and shoot
        private int shootAwayBullets = 6;           // This integer holds the value for the shoot away bullets


        public Form1()
        {
            InitializeComponent();
            btn_Load.Enabled = true;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = false;
            btn_ShootAway.Enabled = false;
        }

        game bbndook47 = new game();
        Random random = new Random();
        //below coding for load button//
        private void Btn_Load_Click(object sender, EventArgs e)
        {

            btn_Load.Enabled = false;
            btn_Spin.Enabled = true;
            btn_Shoot.Enabled = false;
            btn_ShootAway.Enabled = false;
            //coding for images//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("rr_game.Resources.load.gif");
            Bitmap bmp = new Bitmap(myStream);
            pic_box_main.Image = bmp;
            //coding for sounds//
            try
            {
                SoundPlayer player = new SoundPlayer(rr_game.Properties.Resources.load);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
        }

        private int generateRandomNumberInRange(int max)
        {
            Random r = new Random();
            int rInt = r.Next(0, max);      // for integer Range
            return rInt;
        }

        //below coding for spin button//
        private void Btn_Spin_Click(object sender, EventArgs e)
        {
            bndook47.Spin();
            btn_Load.Enabled = false;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = true;
            btn_ShootAway.Enabled = true;
            //coding for images//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("rr_game.Resources.spin.gif");
            Bitmap bmp = new Bitmap(myStream);
            pic_box_main.Image = bmp;
            //coding for sounds//
            try
            {
                SoundPlayer player = new SoundPlayer(rr_game.Properties.Resources.spin);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
        }

        public int changeBullet(int value)
        {
            if (value == 6)
            {
                value = 1;
            }
            else
            {
                value++;
            }
            return value;
        }

        //below coding shoot button//
        private void Btn_Shoot_Click(object sender, EventArgs e)
        {

            btn_Load.Enabled = false;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = true;
            btn_ShootAway.Enabled = true;
            //coding for images//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("rr_game.Resources.shoot.jpg");
            Bitmap bmp = new Bitmap(myStream);
            pic_box_main.Image = bmp;

            //coding for sounds//
            try
            {
                SoundPlayer player = new SoundPlayer(rr_game.Properties.Resources.shoot);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }

            if (shotsRemain > 0)
            {
                --shotsRemain;
                if (shotsRemain <= 0)
                {
                    btn_Shoot.Enabled = false;
                    btn_ShootAway.Enabled = false;
                    int currentPick = generateRandomNumberInRange(100);
                    if (currentPick % 2 == 0)
                    {
                        label1.Text = "You Lose!";
                    }
                    else
                    {
                        label1.Text = "You Win!";
                    }
                }
            }
        }

        //below coding for shoot away button//
        private void Btn_ShootAway_Click(object sender, EventArgs e)
        {
            btn_Load.Enabled = false;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = true;
            btn_ShootAway.Enabled = true;
            //coding for images//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("rr_game.Resources.shoot.jpg");
            Bitmap bmp = new Bitmap(myStream);
            pic_box_main.Image = bmp;
            //coding for sounds//
            try
            {
                SoundPlayer player = new SoundPlayer(rr_game.Properties.Resources.shoot);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }

            if (shootAwayBullets > 0)
            {
                --shootAwayBullets;
                if (shootAwayBullets <= 0)
                {
                    btn_Shoot.Enabled = false;
                    btn_ShootAway.Enabled = false;
                    label1.Text = "You Lost!";
                }
            }
        }

        //below coding for play again button//
        private void Btn_PlayAgain_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            btn_Load.Enabled = true;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = false;
            btn_ShootAway.Enabled = false;
            shotsRemain = 1;
            shootAwayBullets = 1;
        }
        //below coding for exit button//
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
