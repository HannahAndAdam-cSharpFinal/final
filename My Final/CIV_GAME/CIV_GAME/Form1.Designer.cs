namespace CIV_GAME
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pbCastle = new System.Windows.Forms.PictureBox();
            this.txtGold = new System.Windows.Forms.TextBox();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCastle)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCastle
            // 
            this.pbCastle.BackColor = System.Drawing.Color.Transparent;
            this.pbCastle.Image = global::CIV_GAME.Properties.Resources.castle;
            this.pbCastle.Location = new System.Drawing.Point(435, 251);
            this.pbCastle.Name = "pbCastle";
            this.pbCastle.Size = new System.Drawing.Size(115, 127);
            this.pbCastle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCastle.TabIndex = 1;
            this.pbCastle.TabStop = false;
            // 
            // txtGold
            // 
            this.txtGold.Location = new System.Drawing.Point(101, 11);
            this.txtGold.Name = "txtGold";
            this.txtGold.ReadOnly = true;
            this.txtGold.Size = new System.Drawing.Size(84, 20);
            this.txtGold.TabIndex = 2;
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(101, 47);
            this.txtFood.Name = "txtFood";
            this.txtFood.ReadOnly = true;
            this.txtFood.Size = new System.Drawing.Size(84, 20);
            this.txtFood.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(231, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(175, 51);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "GOLD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "FOOD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::CIV_GAME.Properties.Resources.grassBackground;
            this.ClientSize = new System.Drawing.Size(864, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.txtGold);
            this.Controls.Add(this.pbCastle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCastle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbCastle;
        private System.Windows.Forms.TextBox txtGold;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

