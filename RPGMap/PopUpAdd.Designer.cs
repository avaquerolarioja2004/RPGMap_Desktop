
namespace RPGMap
{
    partial class PopUpAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.bttClose = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.tittleAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 30;
            // 
            // bttClose
            // 
            this.bttClose.BackgroundImage = global::RPGMap.Properties.Resources.rectangle_mini_mini;
            this.bttClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClose.Location = new System.Drawing.Point(296, 605);
            this.bttClose.Name = "bttClose";
            this.bttClose.Size = new System.Drawing.Size(135, 62);
            this.bttClose.TabIndex = 29;
            this.bttClose.Text = "CERRAR";
            this.bttClose.UseVisualStyleBackColor = true;
            this.bttClose.Click += new System.EventHandler(this.bttClose_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.Color.Transparent;
            this.bttAdd.BackgroundImage = global::RPGMap.Properties.Resources.rectangle_mini_mini;
            this.bttAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdd.Location = new System.Drawing.Point(557, 605);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(135, 62);
            this.bttAdd.TabIndex = 28;
            this.bttAdd.Text = "AÑADIR";
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // tittleAdd
            // 
            this.tittleAdd.AutoSize = true;
            this.tittleAdd.BackColor = System.Drawing.Color.Transparent;
            this.tittleAdd.Font = new System.Drawing.Font("Calibri", 48F);
            this.tittleAdd.Location = new System.Drawing.Point(396, 9);
            this.tittleAdd.Name = "tittleAdd";
            this.tittleAdd.Size = new System.Drawing.Size(206, 78);
            this.tittleAdd.TabIndex = 27;
            this.tittleAdd.Text = "Añadir";
            // 
            // PopUpAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPGMap.Properties.Resources.backGroudAdd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(977, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttClose);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.tittleAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PopUpAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpAdd";
            this.Load += new System.EventHandler(this.PopUpAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttClose;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Label tittleAdd;
    }
}