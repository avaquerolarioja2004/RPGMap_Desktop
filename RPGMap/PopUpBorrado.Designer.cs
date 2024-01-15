
namespace RPGMap
{
    partial class PopUpBorrado
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
            this.tittleDelete = new System.Windows.Forms.Label();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tittleDelete
            // 
            this.tittleDelete.AutoSize = true;
            this.tittleDelete.BackColor = System.Drawing.Color.Transparent;
            this.tittleDelete.Font = new System.Drawing.Font("Calibri", 48F);
            this.tittleDelete.Location = new System.Drawing.Point(139, 57);
            this.tittleDelete.Name = "tittleDelete";
            this.tittleDelete.Size = new System.Drawing.Size(244, 78);
            this.tittleDelete.TabIndex = 21;
            this.tittleDelete.Text = "Borrado";
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.Transparent;
            this.bttDelete.BackgroundImage = global::RPGMap.Properties.Resources.rectangle_mini_mini;
            this.bttDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete.Location = new System.Drawing.Point(324, 506);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(135, 62);
            this.bttDelete.TabIndex = 23;
            this.bttDelete.Text = "BORRAR";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttClose
            // 
            this.bttClose.BackgroundImage = global::RPGMap.Properties.Resources.rectangle_mini_mini;
            this.bttClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClose.Location = new System.Drawing.Point(64, 506);
            this.bttClose.Name = "bttClose";
            this.bttClose.Size = new System.Drawing.Size(135, 62);
            this.bttClose.TabIndex = 24;
            this.bttClose.Text = "CERRAR";
            this.bttClose.UseVisualStyleBackColor = true;
            this.bttClose.Click += new System.EventHandler(this.bttClose_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 25;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Location = new System.Drawing.Point(44, 171);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(35, 13);
            this.info.TabIndex = 26;
            this.info.Text = "label2";
            // 
            // PopUpBorrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPGMap.Properties.Resources.popup;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(520, 635);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttClose);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.tittleDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(520, 635);
            this.MinimumSize = new System.Drawing.Size(520, 635);
            this.Name = "PopUpBorrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpBorrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittleDelete;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info;
    }
}