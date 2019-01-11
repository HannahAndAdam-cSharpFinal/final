using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIV_GAME
{
    public partial class Form1 : Form
    {
        private int totalGold;
        private int totalFood;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseClick += PB_Main_Mouse_Click;

            ResetGame();
        }

        private void PB_PLOT_CLICK(object sender, EventArgs e)
        {
            PictureBox oPictureBox = (PictureBox)sender;

            if ((int)oPictureBox.Tag == 1)
            {
                frmResource f = new frmResource();
                f.StartPosition = FormStartPosition.CenterParent;
                var result = f.ShowDialog();   
                
                if (result == DialogResult.OK)
                {
                    if (f.theResource == "GOLD")
                    {
                        oPictureBox.Image = Image.FromFile(Application.StartupPath + "\\goldmine.png");
                        oPictureBox.Tag = 2;

                        totalGold += f.theCost;
                        txtGold.Text = totalGold.ToString();
                    }
                    else if (f.theResource == "FOOD")
                    {
                        oPictureBox.Image = Image.FromFile(Application.StartupPath + "\\foodchoice.png");
                        oPictureBox.Tag = 2;

                        totalFood += f.theCost;
                        txtFood.Text = totalFood.ToString();
                    }
                }
            }
        }

        private void PB_Main_Mouse_Click(object sender, EventArgs e)
        {
            if (this.Controls.Count < 15 && timer1.Enabled == true)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                Point coordinates = me.Location;

                var picture = new PictureBox
                {
                    Name = "gameBox",
                    Size = new Size(55, 55),
                    Location = new Point(coordinates.X, coordinates.Y),
                    Image = Image.FromFile(Application.StartupPath + "\\emptyPlot.png"),

                };

                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Visible = true;
                picture.Tag = 1;
                picture.Click += new System.EventHandler(this.PB_PLOT_CLICK);

                this.Controls.Add(picture);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            totalGold -= 75;
            totalFood -= 50;

            txtGold.Text = totalGold.ToString();
            txtFood.Text = totalFood.ToString();

            // gold or food are less than 0, turn off the timer and reset the game
            if (totalGold < 0 || totalFood < 0) 
            {
                timer1.Enabled = false;

                if (totalGold < 0)
                {
                    txtGold.BackColor = Color.Red;
                }
                else if (totalFood < 0)
                {
                    txtFood.BackColor = Color.Red;
                }

                MessageBox.Show("You have run out of resources.  You lose.  You must maintain both gold and food.  If you would like to play again, please click the 'New Game' button.");
                ResetGame();
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    PictureBox picture = control as PictureBox;//picture 
                    if (picture != null)
                    {
                        if (picture.Name == "gameBox")
                        {
                            if ((int)picture.Tag == 2)
                            {
                                this.Controls.Remove(picture);
                            }
                        }
                    }
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ResetGame();

            btnNewGame.Visible = false;

            timer1.Enabled = true;
        }

        private void ResetGame()
        {
            foreach (Control control in this.Controls)//the collection of controls,
            {
                PictureBox picture = control as PictureBox; 
                if (picture != null)
                {
                    if (picture.Name == "gameBox")
                    {
                        this.Controls.Remove(picture); /*this removes the picture so 
                        that the game has a finite endgame*/
                    }
                }
            }

            txtFood.BackColor = Color.White;
            txtGold.BackColor = Color.White;

            totalGold = 500;
            totalFood = 500;

            txtFood.Text = totalFood.ToString();
            txtGold.Text = totalGold.ToString();

            timer1.Enabled = false;

            btnNewGame.Visible = true;
        }
    }
}
