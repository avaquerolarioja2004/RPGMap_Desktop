
namespace RPGMap
{
    partial class InfoContentFurniture
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
            this.tittlefurniture = new System.Windows.Forms.Label();
            this.layoutButtons = new System.Windows.Forms.Panel();
            this.bttClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tittlefurniture
            // 
            this.tittlefurniture.AutoSize = true;
            this.tittlefurniture.BackColor = System.Drawing.Color.Transparent;
            this.tittlefurniture.Font = new System.Drawing.Font("Calibri", 48F);
            this.tittlefurniture.Location = new System.Drawing.Point(135, 18);
            this.tittlefurniture.Name = "tittlefurniture";
            this.tittlefurniture.Size = new System.Drawing.Size(260, 78);
            this.tittlefurniture.TabIndex = 25;
            this.tittlefurniture.Text = "Muebles";
            // 
            // layoutButtons
            // 
            this.layoutButtons.AutoScroll = true;
            this.layoutButtons.BackColor = System.Drawing.Color.Transparent;
            this.layoutButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layoutButtons.Location = new System.Drawing.Point(12, 110);
            this.layoutButtons.Name = "layoutButtons";
            this.layoutButtons.Size = new System.Drawing.Size(496, 394);
            this.layoutButtons.TabIndex = 24;
            // 
            // bttClose
            // 
            this.bttClose.BackColor = System.Drawing.Color.Transparent;
            this.bttClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttClose.FlatAppearance.BorderSize = 0;
            this.bttClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttClose.Image = global::RPGMap.Properties.Resources.rectangle_mini;
            this.bttClose.Location = new System.Drawing.Point(148, 542);
            this.bttClose.Name = "bttClose";
            this.bttClose.Size = new System.Drawing.Size(230, 74);
            this.bttClose.TabIndex = 23;
            this.bttClose.Text = "CERRAR";
            this.bttClose.UseVisualStyleBackColor = false;
            this.bttClose.Click += new System.EventHandler(this.bttGen_Click);
            // 
            // InfoContentFurniture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPGMap.Properties.Resources.popup;
            this.ClientSize = new System.Drawing.Size(520, 635);
            this.Controls.Add(this.tittlefurniture);
            this.Controls.Add(this.layoutButtons);
            this.Controls.Add(this.bttClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(520, 635);
            this.MinimumSize = new System.Drawing.Size(520, 635);
            this.Name = "InfoContentFurniture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoContentFurniture";
            this.Load += new System.EventHandler(this.Contentobject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittlefurniture;
        private System.Windows.Forms.Panel layoutButtons;
        private System.Windows.Forms.Button bttClose;
    }
}