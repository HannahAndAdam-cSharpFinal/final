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
    public partial class frmResource : Form
    {
        private string mResource;
        private int mCost;

        public string theResource
        {
            get { return mResource; }
        }

        public int theCost
        {
            get { return mCost; }
        }

        public frmResource()
        {
            InitializeComponent();
        }

        private void btnOK_GOLD_Click(object sender, EventArgs e)
        {
            mResource = "GOLD";
            mCost = Convert.ToInt32(lblGold.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_FOOD_Click(object sender, EventArgs e)
        {
            mResource = "FOOD";
            mCost = Convert.ToInt32(lblFood.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void frmResource_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            lblGold.Text = r.Next(150, 250).ToString();
            lblFood.Text = r.Next(100, 200).ToString();

        }
    }
}
