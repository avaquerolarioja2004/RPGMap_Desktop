
namespace RPGMap
{
    partial class InfoContEnemy
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
            this.tittleEditEnemies = new System.Windows.Forms.Label();
            this.layoutButtonsEdit = new System.Windows.Forms.Panel();
            this.bttCloseEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tittleEditEnemies
            // 
            this.tittleEditEnemies.AutoSize = true;
            this.tittleEditEnemies.BackColor = System.Drawing.Color.Transparent;
            this.tittleEditEnemies.Font = new System.Drawing.Font("Calibri", 48F);
            this.tittleEditEnemies.Location = new System.Drawing.Point(135, 16);
            this.tittleEditEnemies.Name = "tittleEditEnemies";
            this.tittleEditEnemies.Size = new System.Drawing.Size(285, 78);
            this.tittleEditEnemies.TabIndex = 13;
            this.tittleEditEnemies.Text = "Enemigos";
            // 
            // layoutButtonsEdit
            // 
            this.layoutButtonsEdit.AutoScroll = true;
            this.layoutButtonsEdit.BackColor = System.Drawing.Color.Transparent;
            this.layoutButtonsEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layoutButtonsEdit.Location = new System.Drawing.Point(12, 112);
            this.layoutButtonsEdit.Name = "layoutButtonsEdit";
            this.layoutButtonsEdit.Size = new System.Drawing.Size(496, 394);
            this.layoutButtonsEdit.TabIndex = 12;
            // 
            // bttCloseEdit
            // 
            this.bttCloseEdit.BackColor = System.Drawing.Color.Transparent;
            this.bttCloseEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttCloseEdit.FlatAppearance.BorderSize = 0;
            this.bttCloseEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCloseEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCloseEdit.Image = global::RPGMap.Properties.Resources.rectangle_mini;
            this.bttCloseEdit.Location = new System.Drawing.Point(148, 544);
            this.bttCloseEdit.Name = "bttCloseEdit";
            this.bttCloseEdit.Size = new System.Drawing.Size(230, 74);
            this.bttCloseEdit.TabIndex = 11;
            this.bttCloseEdit.Text = "CERRAR";
            this.bttCloseEdit.UseVisualStyleBackColor = false;
            this.bttCloseEdit.Click += new System.EventHandler(this.bttGen_Click);
            // 
            // InfoContEnemy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPGMap.Properties.Resources.popup;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(520, 635);
            this.Controls.Add(this.tittleEditEnemies);
            this.Controls.Add(this.layoutButtonsEdit);
            this.Controls.Add(this.bttCloseEdit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(520, 635);
            this.MinimumSize = new System.Drawing.Size(520, 635);
            this.Name = "InfoContEnemy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoContEnemy";
            this.Load += new System.EventHandler(this.InfoContEnemy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittleEditEnemies;
        private System.Windows.Forms.Panel layoutButtonsEdit;
        private System.Windows.Forms.Button bttCloseEdit;
    }
}