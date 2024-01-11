
namespace RPGMap
{
    partial class RPGMap
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPGMap));
            this.bttGen = new System.Windows.Forms.Button();
            this.bttCont = new System.Windows.Forms.Button();
            this.lbTittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttGen
            // 
            this.bttGen.BackColor = System.Drawing.Color.Yellow;
            this.bttGen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttGen.BackgroundImage")));
            this.bttGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGen.Location = new System.Drawing.Point(70, 502);
            this.bttGen.Margin = new System.Windows.Forms.Padding(2);
            this.bttGen.Name = "bttGen";
            this.bttGen.Size = new System.Drawing.Size(336, 108);
            this.bttGen.TabIndex = 0;
            this.bttGen.Text = "GENERAR";
            this.bttGen.UseVisualStyleBackColor = false;
            this.bttGen.Click += new System.EventHandler(this.bttGen_Click);
            // 
            // bttCont
            // 
            this.bttCont.BackColor = System.Drawing.Color.Yellow;
            this.bttCont.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttCont.BackgroundImage")));
            this.bttCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCont.Location = new System.Drawing.Point(762, 502);
            this.bttCont.Margin = new System.Windows.Forms.Padding(2);
            this.bttCont.Name = "bttCont";
            this.bttCont.Size = new System.Drawing.Size(336, 108);
            this.bttCont.TabIndex = 1;
            this.bttCont.Text = "CONTENIDO";
            this.bttCont.UseVisualStyleBackColor = false;
            this.bttCont.Click += new System.EventHandler(this.bttCont_Click);
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.BackColor = System.Drawing.Color.Transparent;
            this.lbTittle.Font = new System.Drawing.Font("DRAGON HUNTER", 91.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.Location = new System.Drawing.Point(302, 86);
            this.lbTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(572, 132);
            this.lbTittle.TabIndex = 2;
            this.lbTittle.Text = "RPGMap";
            // 
            // RPGMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1153, 687);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.bttCont);
            this.Controls.Add(this.bttGen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1169, 726);
            this.MinimumSize = new System.Drawing.Size(1169, 726);
            this.Name = "RPGMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPGMap";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttGen;
        private System.Windows.Forms.Button bttCont;
        private System.Windows.Forms.Label lbTittle;
    }
}

