
namespace RPGMap
{
    partial class Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.bttBackToGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttBackToGen
            // 
            this.bttBackToGen.BackColor = System.Drawing.Color.Transparent;
            this.bttBackToGen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttBackToGen.FlatAppearance.BorderSize = 0;
            this.bttBackToGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttBackToGen.Image = global::RPGMap.Properties.Resources.arrow_left;
            this.bttBackToGen.Location = new System.Drawing.Point(34, 693);
            this.bttBackToGen.Name = "bttBackToGen";
            this.bttBackToGen.Size = new System.Drawing.Size(61, 61);
            this.bttBackToGen.TabIndex = 4;
            this.bttBackToGen.UseVisualStyleBackColor = false;
            this.bttBackToGen.Click += new System.EventHandler(this.bttLeft_Click);
            this.bttBackToGen.MouseEnter += new System.EventHandler(this.bttLeft_MouseEnter);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPGMap.Properties.Resources.untitled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1155, 775);
            this.Controls.Add(this.bttBackToGen);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1171, 814);
            this.MinimumSize = new System.Drawing.Size(1171, 814);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPGMap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Map_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttBackToGen;
    }
}