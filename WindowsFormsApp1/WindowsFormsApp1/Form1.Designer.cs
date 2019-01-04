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
            this.SuspendLayout();
            // 
            // castle
            // 
            this.castle.BackColor = System.Drawing.Color.Transparent;
            this.castle.Image = global::WindowsFormsApp1.Properties.Resources.castle;
            this.castle.Location = new System.Drawing.Point(359, 168);
            this.castle.Name = "castle";
            this.castle.Size = new System.Drawing.Size(289, 295);
            this.castle.TabIndex = 0;
            // 
            // openSpot1
            // 
            this.openSpot1.BackColor = System.Drawing.Color.Transparent;
            this.openSpot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openSpot1.Image = global::WindowsFormsApp1.Properties.Resources.emptyPlot;
            this.openSpot1.Location = new System.Drawing.Point(177, 117);
            this.openSpot1.Name = "openSpot1";
            this.openSpot1.Size = new System.Drawing.Size(176, 172);
            this.openSpot1.TabIndex = 1;
            this.openSpot1.UseVisualStyleBackColor = false;
            this.openSpot1.Click += new System.EventHandler(this.openSpot1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.grassBackground;
            this.ClientSize = new System.Drawing.Size(1015, 811);
            this.Controls.Add(this.openSpot1);
            this.Controls.Add(this.castle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label castle;
        private System.Windows.Forms.Button openSpot1;
    }
}

