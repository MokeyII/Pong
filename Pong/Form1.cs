using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class MainWindow : Form
    {

        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;
        public MainWindow()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket.Top = playground.Bottom - (playground.Bottom / 50);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);  //Set the center of the racket to the position of the curser

            ball.Left += speed_left;  //Move the ball
            ball.Top += speed_top;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top; // Change direction
                point += 1;
                Random randomGen = new Random();
                KnownColor[] name = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                KnownColor randomColorName = name[randomGen.Next(name.Length)];
                Color randomColor = Color.FromKnownColor(randomColorName);
                ball.BackColor = randomColor;
                racket.BackColor = randomColor;
            }

            if(ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if(ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if(ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
                Random randomGen = new Random();
                KnownColor[] name = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                KnownColor randomColorName = name[randomGen.Next(name.Length)];
                Color randomColor = Color.FromKnownColor(randomColorName);
                playground.BackColor = randomColor;
            }
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false; //Ball is out -> Stop the game
                label1.Show();
                label2.Show();
            }
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
        }
    }
}
