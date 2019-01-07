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
            this.castle = new System.Windows.Forms.Label();
            this.openSpot1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            // openSpot1
            // 
            this.openSpot1.BackColor = System.Drawing.Color.ForestGreen;
            this.openSpot1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emptyPlot;
            this.openSpot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openSpot1.Location = new System.Drawing.Point(120, 137);
            this.openSpot1.Name = "openSpot1";
            this.openSpot1.Size = new System.Drawing.Size(97, 92);
            this.openSpot1.TabIndex = 1;
            this.openSpot1.UseVisualStyleBackColor = false;
            this.openSpot1.Click += new System.EventHandler(this.openSpot1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emptyPlot;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(120, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 92);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emptyPlot;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(120, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 92);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emptyPlot;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(764, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 92);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emptyPlot;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(764, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 92);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.ForestGreen;
            this.button5.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emptyPlot;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(764, 401);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 92);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.grassBackground;
            this.ClientSize = new System.Drawing.Size(1015, 811);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openSpot1);
            this.Controls.Add(this.castle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label castle;
        private System.Windows.Forms.Button openSpot1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

