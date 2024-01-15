
namespace RPGMap
{
    partial class Content
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Content));
            this.bttLeft = new System.Windows.Forms.Button();
            this.lbTittle = new System.Windows.Forms.Label();
            this.lbRaya = new System.Windows.Forms.Label();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttLeft
            // 
            this.bttLeft.BackColor = System.Drawing.Color.Transparent;
            this.bttLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttLeft.FlatAppearance.BorderSize = 0;
            this.bttLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttLeft.Image = global::RPGMap.Properties.Resources.arrow_left;
            this.bttLeft.Location = new System.Drawing.Point(52, 849);
            this.bttLeft.Margin = new System.Windows.Forms.Padding(4);
            this.bttLeft.Name = "bttLeft";
            this.bttLeft.Size = new System.Drawing.Size(81, 75);
            this.bttLeft.TabIndex = 4;
            this.bttLeft.UseVisualStyleBackColor = false;
            this.bttLeft.Click += new System.EventHandler(this.bttLeft_Click);
            this.bttLeft.MouseEnter += new System.EventHandler(this.bttLeft_MouseEnter);
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.BackColor = System.Drawing.Color.Transparent;
            this.lbTittle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.Location = new System.Drawing.Point(652, 11);
            this.lbTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(441, 97);
            this.lbTittle.TabIndex = 7;
            this.lbTittle.Text = "CONTENIDO";
            // 
            // lbRaya
            // 
            this.lbRaya.AutoSize = true;
            this.lbRaya.BackColor = System.Drawing.Color.Transparent;
            this.lbRaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRaya.Location = new System.Drawing.Point(241, 49);
            this.lbRaya.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRaya.Name = "lbRaya";
            this.lbRaya.Size = new System.Drawing.Size(1050, 69);
            this.lbRaya.TabIndex = 8;
            this.lbRaya.Text = "______________________________";
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.Color.Transparent;
            this.bttAdd.FlatAppearance.BorderSize = 0;
            this.bttAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdd.Image = global::RPGMap.Properties.Resources.boton_aniadir;
            this.bttAdd.Location = new System.Drawing.Point(1128, 42);
            this.bttAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(45, 46);
            this.bttAdd.TabIndex = 34;
            this.bttAdd.UseVisualStyleBackColor = false;
            // 
            // bttInfo
            // 
            this.bttInfo.BackColor = System.Drawing.Color.Transparent;
            this.bttInfo.FlatAppearance.BorderSize = 0;
            this.bttInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttInfo.Image = global::RPGMap.Properties.Resources.info;
            this.bttInfo.Location = new System.Drawing.Point(573, 42);
            this.bttInfo.Margin = new System.Windows.Forms.Padding(4);
            this.bttInfo.Name = "bttInfo";
            this.bttInfo.Size = new System.Drawing.Size(45, 46);
            this.bttInfo.TabIndex = 35;
            this.bttInfo.UseVisualStyleBackColor = false;
            // 
            // Content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPGMap.Properties.Resources.untitled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1537, 944);
            this.Controls.Add(this.bttInfo);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.lbRaya);
            this.Controls.Add(this.bttLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1555, 991);
            this.MinimumSize = new System.Drawing.Size(1555, 991);
            this.Name = "Content";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPGMap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Content_FormClosed);
            this.Load += new System.EventHandler(this.Content_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttLeft;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Label lbRaya;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttInfo;
    }
}