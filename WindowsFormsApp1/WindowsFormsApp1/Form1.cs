using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int score = 500;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();


            
        }
        
        private void openSpot1_Click(object sender, EventArgs e)
        {


            goldMineBtn.Visible = true;
            foodBtn.Visible = true;

             
        }

        private void goldMineBtn_Click(object sender, EventArgs e)
        {
            goldMineChoice1Btn.Visible = true;
            foodChoice1Btn.Visible = false;
            goldMineBtn.Visible = false;
            foodBtn.Visible = false;
            openSpot1btn.Visible = false;

            
        }

        private void foodBtn_Click(object sender, EventArgs e)
        {
            goldMineChoice1Btn.Visible = false;
            foodChoice1Btn.Visible = true;
            goldMineBtn.Visible = false;
            foodBtn.Visible = false;
            openSpot1btn.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score = score + 1;
        }

        private void goldMineChoice1Btn_Click(object sender, EventArgs e)
        {

            score = score + 1;
            goldTxtBox.Text = score + " gold";
        }

    }
}
