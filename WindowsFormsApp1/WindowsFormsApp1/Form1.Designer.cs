namespace WindowsFormsApp1
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
            this.castle = new System.Windows.Forms.Label();
            this.openSpot1btn = new System.Windows.Forms.Button();
            this.openSpot2btn = new System.Windows.Forms.Button();
            this.openSpot3btn = new System.Windows.Forms.Button();
            this.openSpot4btn = new System.Windows.Forms.Button();
            this.openSpot5btn = new System.Windows.Forms.Button();
            this.openSpot6btn = new System.Windows.Forms.Button();
            this.goldMineBtn = new System.Windows.Forms.Button();
            this.foodBtn = new System.Windows.Forms.Button();
            this.goldMineChoice1Btn = new System.Windows.Forms.Button();
            this.foodChoice1Btn = new System.Windows.Forms.Button();
            this.goldMine1Timer = new System.Windows.Forms.Timer(this.components);
            this.goldTxtBox = new System.Windows.Forms.TextBox();
            this.foodTxtBox = new System.Windows.Forms.TextBox();
            this.food1Timer = new System.Windows.Forms.Timer(this.components);
            this.goldMineChoice2Btn = new System.Windows.Forms.Button();
            this.foodChoice2Btn = new System.Windows.Forms.Button();
            this.goldMineChoice3Btn = new System.Windows.Forms.Button();
            this.goldMineChoice4Btn = new System.Windows.Forms.Button();
            this.goldMineChoice5Btn = new System.Windows.Forms.Button();
            this.goldMineChoice6Btn = new System.Windows.Forms.Button();
            this.foodChoice3Btn = new System.Windows.Forms.Button();
            this.foodChoice4Btn = new System.Windows.Forms.Button();
            this.foodChoice5Btn = new System.Windows.Forms.Button();
            this.foodChoice6Btn = new System.Windows.Forms.Button();
            this.errorTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // castle
            // 
            this.castle.BackColor = System.Drawing.Color.Transparent;
            this.castle.Image = global::WindowsFormsApp1.Properties.Resources.castle;
            this.castle.Location = new System.Drawing.Point(350, 150);
            this.castle.Name = "castle";
            this.castle.Size = new System.Drawing.Size(289, 295);
            this.castle.TabIndex = 0;
            // 
            // openSpot1btn
            // 
            this.openSpot1btn.BackColor = System.Drawing.Color.ForestGreen;
            this.openSpot1btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emptyPlot;
            this.openSpot1btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openSpot1btn.Location = new System.Drawing.Point(120, 137);
            this.openSpot1btn.Name = "openSpot1btn";
            this.openSpot1btn.Size = new System.Drawing.Size(97, 92);
            this.openSpot1btn.TabIndex = 1;
            this.openSpot1btn.UseVisualStyleBackColor = false;
            this.openSpot1btn.Click += new System.EventHandler(this.openSpot1_Click);
            // 
            // openSpot2btn
            // 
            this.openSpot2btn.BackColor = System.Drawing.Color.ForestGreen;
            this.openSpot2btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emptyPlot;
            this.openSpot2btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openSpot2btn.Location = new System.Drawing.Point(120, 266);
            this.openSpot2btn.Name = "openSpot2btn";
            this.openSpot2btn.Size = new System.Drawing.Size(97, 92);
            this.openSpot2btn.TabIndex = 2;
            this.openSpot2btn.UseVisualStyleBackColor = false;
            this.openSpot2btn.Click += new System.EventHandler(this.openSpot2btn_Click);
            // 
            // openSpot3btn
            // 
            this.openSpot3btn.BackColor = System.Drawing.Color.ForestGreen;
            this.openSpot3btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emptyPlot;
            this.openSpot3btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openSpot3btn.Location = new System.Drawing.Point(120, 401);
            this.openSpot3btn.Name = "openSpot3btn";
            this.openSpot3btn.Size = new System.Drawing.Size(97, 92);
            this.openSpot3btn.TabIndex = 3;
            this.openSpot3btn.UseVisualStyleBackColor = false;
            // 
            // openSpot4btn
            // 
            this.openSpot4btn.BackColor = System.Drawing.Color.ForestGreen;
            this.openSpot4btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emptyPlot;
            this.openSpot4btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openSpot4btn.Location = new System.Drawing.Point(764, 128);
            this.openSpot4btn.Name = "openSpot4btn";
            this.openSpot4btn.Size = new System.Drawing.Size(97, 92);
            this.openSpot4btn.TabIndex = 4;
            this.openSpot4btn.UseVisualStyleBackColor = false;
            // 
            // openSpot5btn
            // 
            this.openSpot5btn.BackColor = System.Drawing.Color.ForestGreen;
            this.openSpot5btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emptyPlot;
            this.openSpot5btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openSpot5btn.Location = new System.Drawing.Point(764, 266);
            this.openSpot5btn.Name = "openSpot5btn";
            this.openSpot5btn.Size = new System.Drawing.Size(97, 92);
            this.openSpot5btn.TabIndex = 5;
            this.openSpot5btn.UseVisualStyleBackColor = false;
            // 
            // openSpot6btn
            // 
            this.openSpot6btn.BackColor = System.Drawing.Color.ForestGreen;
            this.openSpot6btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emptyPlot;
            this.openSpot6btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openSpot6btn.Location = new System.Drawing.Point(764, 401);
            this.openSpot6btn.Name = "openSpot6btn";
            this.openSpot6btn.Size = new System.Drawing.Size(97, 92);
            this.openSpot6btn.TabIndex = 6;
            this.openSpot6btn.UseVisualStyleBackColor = false;
            // 
            // goldMineBtn
            // 
            this.goldMineBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.goldMineBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.goldMine;
            this.goldMineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goldMineBtn.Location = new System.Drawing.Point(353, 52);
            this.goldMineBtn.Name = "goldMineBtn";
            this.goldMineBtn.Size = new System.Drawing.Size(90, 95);
            this.goldMineBtn.TabIndex = 7;
            this.goldMineBtn.UseVisualStyleBackColor = false;
            this.goldMineBtn.Visible = false;
            this.goldMineBtn.Click += new System.EventHandler(this.goldMineBtn_Click);
            // 
            // foodBtn
            // 
            this.foodBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.foodBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.foodChoice;
            this.foodBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodBtn.Location = new System.Drawing.Point(565, 51);
            this.foodBtn.Name = "foodBtn";
            this.foodBtn.Size = new System.Drawing.Size(90, 96);
            this.foodBtn.TabIndex = 8;
            this.foodBtn.UseVisualStyleBackColor = false;
            this.foodBtn.Visible = false;
            this.foodBtn.Click += new System.EventHandler(this.foodBtn_Click);
            // 
            // goldMineChoice1Btn
            // 
            this.goldMineChoice1Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.goldMineChoice1Btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.goldMine;
            this.goldMineChoice1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goldMineChoice1Btn.Location = new System.Drawing.Point(120, 137);
            this.goldMineChoice1Btn.Name = "goldMineChoice1Btn";
            this.goldMineChoice1Btn.Size = new System.Drawing.Size(86, 90);
            this.goldMineChoice1Btn.TabIndex = 9;
            this.goldMineChoice1Btn.UseVisualStyleBackColor = false;
            this.goldMineChoice1Btn.Visible = false;
            this.goldMineChoice1Btn.Click += new System.EventHandler(this.goldMineChoice1Btn_Click);
            // 
            // foodChoice1Btn
            // 
            this.foodChoice1Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.foodChoice1Btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.foodChoice;
            this.foodChoice1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodChoice1Btn.Location = new System.Drawing.Point(136, 137);
            this.foodChoice1Btn.Name = "foodChoice1Btn";
            this.foodChoice1Btn.Size = new System.Drawing.Size(93, 90);
            this.foodChoice1Btn.TabIndex = 10;
            this.foodChoice1Btn.UseVisualStyleBackColor = false;
            this.foodChoice1Btn.Visible = false;
            this.foodChoice1Btn.Click += new System.EventHandler(this.foodChoice1Btn_Click);
            // 
            // goldMine1Timer
            // 
            this.goldMine1Timer.Interval = 500;
            this.goldMine1Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // goldTxtBox
            // 
            this.goldTxtBox.Location = new System.Drawing.Point(785, 24);
            this.goldTxtBox.Name = "goldTxtBox";
            this.goldTxtBox.Size = new System.Drawing.Size(184, 20);
            this.goldTxtBox.TabIndex = 11;
            this.goldTxtBox.Text = "500 gold";
            // 
            // foodTxtBox
            // 
            this.foodTxtBox.Location = new System.Drawing.Point(785, 52);
            this.foodTxtBox.Name = "foodTxtBox";
            this.foodTxtBox.Size = new System.Drawing.Size(184, 20);
            this.foodTxtBox.TabIndex = 12;
            // 
            // food1Timer
            // 
            this.food1Timer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // goldMineChoice2Btn
            // 
            this.goldMineChoice2Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.goldMineChoice2Btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.goldMine;
            this.goldMineChoice2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goldMineChoice2Btn.Location = new System.Drawing.Point(120, 268);
            this.goldMineChoice2Btn.Name = "goldMineChoice2Btn";
            this.goldMineChoice2Btn.Size = new System.Drawing.Size(86, 90);
            this.goldMineChoice2Btn.TabIndex = 13;
            this.goldMineChoice2Btn.UseVisualStyleBackColor = false;
            this.goldMineChoice2Btn.Visible = false;
            this.goldMineChoice2Btn.Click += new System.EventHandler(this.goldMineChoice2Btn_Click);
            // 
            // foodChoice2Btn
            // 
            this.foodChoice2Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.foodChoice2Btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.foodChoice;
            this.foodChoice2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodChoice2Btn.Location = new System.Drawing.Point(139, 267);
            this.foodChoice2Btn.Name = "foodChoice2Btn";
            this.foodChoice2Btn.Size = new System.Drawing.Size(93, 90);
            this.foodChoice2Btn.TabIndex = 14;
            this.foodChoice2Btn.UseVisualStyleBackColor = false;
            this.foodChoice2Btn.Visible = false;
            // 
            // goldMineChoice3Btn
            // 
            this.goldMineChoice3Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.goldMineChoice3Btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.goldMine;
            this.goldMineChoice3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goldMineChoice3Btn.Location = new System.Drawing.Point(120, 403);
            this.goldMineChoice3Btn.Name = "goldMineChoice3Btn";
            this.goldMineChoice3Btn.Size = new System.Drawing.Size(86, 90);
            this.goldMineChoice3Btn.TabIndex = 15;
            this.goldMineChoice3Btn.UseVisualStyleBackColor = false;
            this.goldMineChoice3Btn.Visible = false;
            // 
            // goldMineChoice4Btn
            // 
            this.goldMineChoice4Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.goldMineChoice4Btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.goldMine;
            this.goldMineChoice4Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goldMineChoice4Btn.Location = new System.Drawing.Point(764, 130);
            this.goldMineChoice4Btn.Name = "goldMineChoice4Btn";
            this.goldMineChoice4Btn.Size = new System.Drawing.Size(86, 90);
            this.goldMineChoice4Btn.TabIndex = 16;
            this.goldMineChoice4Btn.UseVisualStyleBackColor = false;
            this.goldMineChoice4Btn.Visible = false;
            // 
            // goldMineChoice5Btn
            // 
            this.goldMineChoice5Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.goldMineChoice5Btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.goldMine;
            this.goldMineChoice5Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goldMineChoice5Btn.Location = new System.Drawing.Point(764, 268);
            this.goldMineChoice5Btn.Name = "goldMineChoice5Btn";
            this.goldMineChoice5Btn.Size = new System.Drawing.Size(86, 90);
            this.goldMineChoice5Btn.TabIndex = 17;
            this.goldMineChoice5Btn.UseVisualStyleBackColor = false;
            this.goldMineChoice5Btn.Visible = false;
            // 
            // goldMineChoice6Btn
            // 
            this.goldMineChoice6Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.goldMineChoice6Btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.goldMine;
            this.goldMineChoice6Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goldMineChoice6Btn.Location = new System.Drawing.Point(764, 401);
            this.goldMineChoice6Btn.Name = "goldMineChoice6Btn";
            this.goldMineChoice6Btn.Size = new System.Drawing.Size(86, 90);
            this.goldMineChoice6Btn.TabIndex = 18;
            this.goldMineChoice6Btn.UseVisualStyleBackColor = false;
            this.goldMineChoice6Btn.Visible = false;
            // 
            // foodChoice3Btn
            // 
            this.foodChoice3Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.foodChoice3Btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.foodChoice;
            this.foodChoice3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodChoice3Btn.Location = new System.Drawing.Point(136, 402);
            this.foodChoice3Btn.Name = "foodChoice3Btn";
            this.foodChoice3Btn.Size = new System.Drawing.Size(93, 90);
            this.foodChoice3Btn.TabIndex = 19;
            this.foodChoice3Btn.UseVisualStyleBackColor = false;
            this.foodChoice3Btn.Visible = false;
            // 
            // foodChoice4Btn
            // 
            this.foodChoice4Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.foodChoice4Btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.foodChoice;
            this.foodChoice4Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodChoice4Btn.Location = new System.Drawing.Point(785, 130);
            this.foodChoice4Btn.Name = "foodChoice4Btn";
            this.foodChoice4Btn.Size = new System.Drawing.Size(93, 90);
            this.foodChoice4Btn.TabIndex = 20;
            this.foodChoice4Btn.UseVisualStyleBackColor = false;
            this.foodChoice4Btn.Visible = false;
            // 
            // foodChoice5Btn
            // 
            this.foodChoice5Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.foodChoice5Btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.foodChoice;
            this.foodChoice5Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodChoice5Btn.Location = new System.Drawing.Point(786, 268);
            this.foodChoice5Btn.Name = "foodChoice5Btn";
            this.foodChoice5Btn.Size = new System.Drawing.Size(93, 90);
            this.foodChoice5Btn.TabIndex = 21;
            this.foodChoice5Btn.UseVisualStyleBackColor = false;
            this.foodChoice5Btn.Visible = false;
            // 
            // foodChoice6Btn
            // 
            this.foodChoice6Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.foodChoice6Btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.foodChoice;
            this.foodChoice6Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodChoice6Btn.Location = new System.Drawing.Point(785, 401);
            this.foodChoice6Btn.Name = "foodChoice6Btn";
            this.foodChoice6Btn.Size = new System.Drawing.Size(93, 90);
            this.foodChoice6Btn.TabIndex = 22;
            this.foodChoice6Btn.UseVisualStyleBackColor = false;
            this.foodChoice6Btn.Visible = false;
            // 
            // errorTxtBox
            // 
            this.errorTxtBox.Location = new System.Drawing.Point(377, 266);
            this.errorTxtBox.Margin = new System.Windows.Forms.Padding(10, 50, 10, 10);
            this.errorTxtBox.MaximumSize = new System.Drawing.Size(400, 400);
            this.errorTxtBox.Multiline = true;
            this.errorTxtBox.Name = "errorTxtBox";
            this.errorTxtBox.Size = new System.Drawing.Size(262, 31);
            this.errorTxtBox.TabIndex = 23;
            this.errorTxtBox.Text = "You do not have enough gold for this item!";
            this.errorTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.errorTxtBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.grassBackground;
            this.ClientSize = new System.Drawing.Size(1015, 811);
            this.Controls.Add(this.errorTxtBox);
            this.Controls.Add(this.foodChoice6Btn);
            this.Controls.Add(this.foodChoice5Btn);
            this.Controls.Add(this.foodChoice4Btn);
            this.Controls.Add(this.foodChoice3Btn);
            this.Controls.Add(this.goldMineChoice6Btn);
            this.Controls.Add(this.goldMineChoice5Btn);
            this.Controls.Add(this.goldMineChoice4Btn);
            this.Controls.Add(this.goldMineChoice3Btn);
            this.Controls.Add(this.foodChoice2Btn);
            this.Controls.Add(this.goldMineChoice2Btn);
            this.Controls.Add(this.foodTxtBox);
            this.Controls.Add(this.goldTxtBox);
            this.Controls.Add(this.foodChoice1Btn);
            this.Controls.Add(this.goldMineChoice1Btn);
            this.Controls.Add(this.foodBtn);
            this.Controls.Add(this.goldMineBtn);
            this.Controls.Add(this.openSpot6btn);
            this.Controls.Add(this.openSpot5btn);
            this.Controls.Add(this.openSpot4btn);
            this.Controls.Add(this.openSpot3btn);
            this.Controls.Add(this.openSpot2btn);
            this.Controls.Add(this.openSpot1btn);
            this.Controls.Add(this.castle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label castle;
        private System.Windows.Forms.Button openSpot1btn;
        private System.Windows.Forms.Button openSpot2btn;
        private System.Windows.Forms.Button openSpot3btn;
        private System.Windows.Forms.Button openSpot4btn;
        private System.Windows.Forms.Button openSpot5btn;
        private System.Windows.Forms.Button openSpot6btn;
        private System.Windows.Forms.Button goldMineBtn;
        private System.Windows.Forms.Button foodBtn;
        private System.Windows.Forms.Button goldMineChoice1Btn;
        private System.Windows.Forms.Button foodChoice1Btn;
        private System.Windows.Forms.Timer goldMine1Timer;
        private System.Windows.Forms.TextBox goldTxtBox;
        private System.Windows.Forms.TextBox foodTxtBox;
        private System.Windows.Forms.Timer food1Timer;
        private System.Windows.Forms.Button goldMineChoice2Btn;
        private System.Windows.Forms.Button foodChoice2Btn;
        private System.Windows.Forms.Button goldMineChoice3Btn;
        private System.Windows.Forms.Button goldMineChoice4Btn;
        private System.Windows.Forms.Button goldMineChoice5Btn;
        private System.Windows.Forms.Button goldMineChoice6Btn;
        private System.Windows.Forms.Button foodChoice3Btn;
        private System.Windows.Forms.Button foodChoice4Btn;
        private System.Windows.Forms.Button foodChoice5Btn;
        private System.Windows.Forms.Button foodChoice6Btn;
        private System.Windows.Forms.TextBox errorTxtBox;
    }
}

