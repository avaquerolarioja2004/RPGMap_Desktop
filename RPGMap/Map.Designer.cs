
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
            this.regenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttBackToGen
            // 
            this.bttBackToGen.BackColor = System.Drawing.Color.Transparent;
            this.bttBackToGen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttBackToGen.FlatAppearance.BorderSize = 0;
            this.bttBackToGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttBackToGen.Image = global::RPGMap.Properties.Resources.arrow_left;
            this.bttBackToGen.Location = new System.Drawing.Point(46, 719);
            this.bttBackToGen.Margin = new System.Windows.Forms.Padding(4);
            this.bttBackToGen.Name = "bttBackToGen";
            this.bttBackToGen.Size = new System.Drawing.Size(81, 75);
            this.bttBackToGen.TabIndex = 4;
            this.bttBackToGen.UseVisualStyleBackColor = false;
            this.bttBackToGen.Click += new System.EventHandler(this.bttLeft_Click);
            this.bttBackToGen.MouseEnter += new System.EventHandler(this.bttLeft_MouseEnter);
            // 
            // regenButton
            // 
            this.regenButton.BackColor = System.Drawing.Color.Transparent;
            this.regenButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.regenButton.FlatAppearance.BorderSize = 0;
            this.regenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regenButton.Image = ((System.Drawing.Image)(resources.GetObject("regenButton.Image")));
            this.regenButton.Location = new System.Drawing.Point(673, 719);
            this.regenButton.Margin = new System.Windows.Forms.Padding(4);
            this.regenButton.Name = "regenButton";
            this.regenButton.Size = new System.Drawing.Size(81, 75);
            this.regenButton.TabIndex = 5;
            this.regenButton.UseVisualStyleBackColor = false;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPGMap.Properties.Resources.untitled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1537, 944);
            this.Controls.Add(this.regenButton);
            this.Controls.Add(this.bttBackToGen);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1555, 991);
            this.MinimumSize = new System.Drawing.Size(1555, 991);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPGMap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Map_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttBackToGen;
        private System.Windows.Forms.Button regenButton;
    }
}