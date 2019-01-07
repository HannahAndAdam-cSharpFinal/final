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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.goldTxtBox = new System.Windows.Forms.TextBox();
            this.foodTxtBox = new System.Windows.Forms.TextBox();
            this.goldLbl = new System.Windows.Forms.Label();
            this.foodLbl = new System.Windows.Forms.Label();
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
            this.foodBtn.Location = new System.Drawing.Point(565, 51);
            this.foodBtn.Name = "foodBtn";
            this.foodBtn.Size = new System.Drawing.Size(91, 85);
            this.foodBtn.TabIndex = 8;
            this.foodBtn.Text = "button7";
            this.foodBtn.UseVisualStyleBackColor = true;
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
            this.foodChoice1Btn.Location = new System.Drawing.Point(136, 142);
            this.foodChoice1Btn.Name = "foodChoice1Btn";
            this.foodChoice1Btn.Size = new System.Drawing.Size(91, 85);
            this.foodChoice1Btn.TabIndex = 10;
            this.foodChoice1Btn.UseVisualStyleBackColor = true;
            this.foodChoice1Btn.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // goldTxtBox
            // 
            this.goldTxtBox.Location = new System.Drawing.Point(785, 24);
            this.goldTxtBox.Name = "goldTxtBox";
            this.goldTxtBox.Size = new System.Drawing.Size(184, 20);
            this.goldTxtBox.TabIndex = 11;
            // 
            // foodTxtBox
            // 
            this.foodTxtBox.Location = new System.Drawing.Point(785, 52);
            this.foodTxtBox.Name = "foodTxtBox";
            this.foodTxtBox.Size = new System.Drawing.Size(184, 20);
            this.foodTxtBox.TabIndex = 12;
            // 
            // goldLbl
            // 
            this.goldLbl.AutoSize = true;
            this.goldLbl.Location = new System.Drawing.Point(731, 27);
            this.goldLbl.Name = "goldLbl";
            this.goldLbl.Size = new System.Drawing.Size(32, 13);
            this.goldLbl.TabIndex = 13;
            this.goldLbl.Text = "Gold ";
            // 
            // foodLbl
            // 
            this.foodLbl.AutoSize = true;
            this.foodLbl.Location = new System.Drawing.Point(734, 58);
            this.foodLbl.Name = "foodLbl";
            this.foodLbl.Size = new System.Drawing.Size(31, 13);
            this.foodLbl.TabIndex = 14;
            this.foodLbl.Text = "Food";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.grassBackground;
            this.ClientSize = new System.Drawing.Size(1015, 811);
            this.Controls.Add(this.foodLbl);
            this.Controls.Add(this.goldLbl);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox goldTxtBox;
        private System.Windows.Forms.TextBox foodTxtBox;
        private System.Windows.Forms.Label goldLbl;
        private System.Windows.Forms.Label foodLbl;
    }
}

