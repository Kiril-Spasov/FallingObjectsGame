using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace FallingObjectsGame
{
    public partial class FormFallingObjects : Form
    {
        public FormFallingObjects()
        {
            InitializeComponent();
        }

        Graphics g;
        Random r = new Random();

        //Use Image array for the spaceship images to simulate animation.
        Image[] spaceShipImages = new Image[12];
        //Stores the images for the falling objects.
        Image[] fallingObjects = new Image[6];
        //Stores the X pos for each falling object.
        int[] ObjPosX = new int[6];
        //Stores the Y pos for each falling object.
        int[] ObjPosY = new int[6];
        //Stores the speed for each falling object.
        int[] speed = new int[6];

        //Stores spaceship image.
        Image spaceShip;
        //Stores background image.
        Image background;
        SoundPlayer getPointsSound = new SoundPlayer();
        
        //Counter for timer2 simulating spaceship animation.
        int count = 0;

        //Initial X and Y pos for the spaceship.
        int spaceShipX;
        int spaceShipY;

        //Counter for total points.
        int points;

        bool startFlag;
        int seconds = 60;

        private void FormFallingObjects_Load(object sender, EventArgs e)
        {
            //Set the Graphics object to point at panel1.
            g = panel1.CreateGraphics();

            //Load get points sound.
            getPointsSound.SoundLocation = Application.StartupPath + @"\bonussound.wav";
            getPointsSound.LoadAsync();

            //Load background image.
            background = Image.FromFile(Application.StartupPath + @"\space-background.png");

            //Load falling objects images.
            for (int i = 1; i <= 5; i++)
            {
                fallingObjects[i] = Image.FromFile(Application.StartupPath + @"\icons\object" + i.ToString() + ".png");
            }

            //Load spaceship images.
            for (int i = 0; i <= 11; i++)
            {
                spaceShipImages[i] = Image.FromFile(Application.StartupPath + @"\space-ship-images\spaceship" + i.ToString() + "-removebg-preview.png");
            }
            spaceShip = Image.FromFile(Application.StartupPath + @"\spaceship0-removebg-preview.png");
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            countdownTimer.Enabled = true;
            timer1.Enabled = true;
            timer3.Enabled = true;
            startFlag = true;

            //Set spaceship initial pos at the bottom center of the panel.
            spaceShipX = panel1.Width / 2;
            spaceShipY = panel1.Height - spaceShip.Height;
            
            //Set the X pos for the falling objects on a proper distance from each other.
            //Set random speed for each object.
            int x = 10;
            for (int i = 1; i <= 5; i++)
            {
                ObjPosX[i] = x;
                x = x + 85;
                speed[i] = r.Next(2, 7);
            }

            //Gives form focus, so it can accept keydown events.
            this.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Redraw background each tick to simulate animation.
            g.DrawImage(background, 0, 0);
            //Redraw spaceship
            g.DrawImage(spaceShip, spaceShipX, spaceShipY);


            for (int i = 1; i <= 5; i++)
            {
                //Redraw each object
                g.DrawImage(fallingObjects[i], ObjPosX[i], ObjPosY[i]);
                //Increment pos Y of each object with the speed variable to simulate movement.
                ObjPosY[i] += speed[i];

                //Check if the object is below the level of the space ship.             
                if (ObjPosY[i] + fallingObjects[i].Height > spaceShipY)
                {
                    //Check if it's on the left side.
                    if (ObjPosX[i] < spaceShipX)
                    {
                        //Check if there is collision.
                        if (ObjPosX[i] + fallingObjects[i].Width > spaceShipX)
                        {
                            //Reinitialize pos. Set to -20 so it appears gradually from the top.
                            ObjPosY[i] = -20;
                            //Reinitialize new random speed.
                            speed[i] = r.Next(2, 7);

                            getPointsSound.Play();

                            //Depending on the speed we give certain points.
                            if (speed[i] >= 5)
                            {
                                points += 5; 
                            }
                            else
                            {
                                points += 2;
                            }
                        }
                        //If above is not true the object passed on the left side without collision.
                        //We restart it with new random speed.
                        else if (ObjPosY[i] > this.Height)
                        {
                            ObjPosY[i] = -20;
                            speed[i] = r.Next(2, 7);
                        }
                    }
                    //Check if it's on the right side.
                    else if (ObjPosX[i] > spaceShipX)
                    {
                        //Check if there is a collision.
                        if (spaceShipX + spaceShip.Width > ObjPosX[i])
                        {
                            ObjPosY[i] = -20;
                            speed[i] = r.Next(2, 7);
                            getPointsSound.Play();

                            if (speed[i] >= 5)
                            {
                                points += 5;
                            }
                            else
                            {
                                points += 2;
                            }
                        }
                        //If above is not true the object passed on the right side without collision.
                        //We restart it with new random speed.
                        else if (ObjPosY[i] > this.Height)
                        {
                            ObjPosY[i] = -20;
                            speed[i] = r.Next(2, 7);
                        }
                    }
                }
                TxtPoints.Text = points.ToString();
            }    
        }

        //Using timer2 to simulate spaceship animation.
        private void timer2_Tick(object sender, EventArgs e)
        {
            spaceShip = spaceShipImages[count];
            count++;
            if (count > 11)
                count = 0;
        }

        private void FormFallingObjects_KeyDown(object sender, KeyEventArgs e)
        {
            if (startFlag)
            {
                if (e.KeyCode == Keys.A)
                {
                    spaceShipX -= 5;
                }
                else if (e.KeyCode == Keys.D)
                {
                    spaceShipX += 5;
                }            
            }
            g.DrawImage(spaceShip, spaceShipX, spaceShipY);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            TxtGameOver.Text = "GAME OVER";
            TxtGameOver.Visible = true;
        }
        
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            TxtTimeLeft.Text = seconds.ToString();
            seconds--;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer3.Enabled = false;
            countdownTimer.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
