namespace CIV_GAME
{
    partial class frmResource
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK_GOLD = new System.Windows.Forms.Button();
            this.lblGold = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.btnOK_FOOD = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK_GOLD
            // 
            this.btnOK_GOLD.Location = new System.Drawing.Point(64, 169);
            this.btnOK_GOLD.Name = "btnOK_GOLD";
            this.btnOK_GOLD.Size = new System.Drawing.Size(64, 29);
            this.btnOK_GOLD.TabIndex = 0;
            this.btnOK_GOLD.Text = "GOLD";
            this.btnOK_GOLD.UseVisualStyleBackColor = true;
            this.btnOK_GOLD.Click += new System.EventHandler(this.btnOK_GOLD_Click);
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(80, 144);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(25, 13);
            this.lblGold.TabIndex = 3;
            this.lblGold.Text = "250";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CIV_GAME.Properties.Resources.foodChoice;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(207, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CIV_GAME.Properties.Resources.goldMine;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(46, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(244, 144);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(25, 13);
            this.lblFood.TabIndex = 5;
            this.lblFood.Text = "250";
            // 
            // btnOK_FOOD
            // 
            this.btnOK_FOOD.Location = new System.Drawing.Point(218, 169);
            this.btnOK_FOOD.Name = "btnOK_FOOD";
            this.btnOK_FOOD.Size = new System.Drawing.Size(64, 29);
            this.btnOK_FOOD.TabIndex = 6;
            this.btnOK_FOOD.Text = "FOOD";
            this.btnOK_FOOD.UseVisualStyleBackColor = true;
            this.btnOK_FOOD.Click += new System.EventHandler(this.btnOK_FOOD_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(218, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 260);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK_FOOD);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOK_GOLD);
            this.Name = "frmResource";
            this.Text = "Select a resource";
            this.Load += new System.EventHandler(this.frmResource_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK_GOLD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Button btnOK_FOOD;
        private System.Windows.Forms.Button btnCancel;
    }
}