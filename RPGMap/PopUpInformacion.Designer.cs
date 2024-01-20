
namespace RPGMap
{
    partial class PopUpInformacion
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
            this.info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttClose = new System.Windows.Forms.Button();
            this.tittleDelete = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Location = new System.Drawing.Point(15, 19);
            this.info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(45, 16);
            this.info.TabIndex = 36;
            this.info.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 35;
            // 
            // bttClose
            // 
            this.bttClose.BackgroundImage = global::RPGMap.Properties.Resources.rectangle_mini_mini;
            this.bttClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClose.Location = new System.Drawing.Point(272, 642);
            this.bttClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttClose.Name = "bttClose";
            this.bttClose.Size = new System.Drawing.Size(180, 76);
            this.bttClose.TabIndex = 34;
            this.bttClose.Text = "CERRAR";
            this.bttClose.UseVisualStyleBackColor = true;
            this.bttClose.Click += new System.EventHandler(this.bttClose_Click_1);
            // 
            // tittleDelete
            // 
            this.tittleDelete.AutoSize = true;
            this.tittleDelete.BackColor = System.Drawing.Color.Transparent;
            this.tittleDelete.Font = new System.Drawing.Font("Calibri", 48F);
            this.tittleDelete.Location = new System.Drawing.Point(141, 26);
            this.tittleDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tittleDelete.Name = "tittleDelete";
            this.tittleDelete.Size = new System.Drawing.Size(350, 78);
            this.tittleDelete.TabIndex = 32;
            this.tittleDelete.Text = "Información";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.info);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 491);
            this.panel1.TabIndex = 37;
            // 
            // PopUpInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPGMap.Properties.Resources.popup;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(693, 782);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttClose);
            this.Controls.Add(this.tittleDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(693, 782);
            this.MinimumSize = new System.Drawing.Size(693, 782);
            this.Name = "PopUpInformacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpInformacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttClose;
        private System.Windows.Forms.Label tittleDelete;
        private System.Windows.Forms.Panel panel1;
    }
}