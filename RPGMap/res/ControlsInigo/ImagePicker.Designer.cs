namespace CustomControls.Controls
{
    partial class ImagePicker
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(32, 115);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(124, 17);
            this.label.TabIndex = 4;
            this.label.Text = "Arrastra la imagen";
            // 
            // clear
            // 
            this.clear.BackgroundImage = global::RPGMap.Properties.Resources.rectangle_mini_mini_imagePicker;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Location = new System.Drawing.Point(260, 108);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(88, 33);
            this.clear.TabIndex = 5;
            this.clear.Text = "Limpiar";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.BackgroundImage = global::RPGMap.Properties.Resources.rectangle_mini_mini_imagePicker;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Location = new System.Drawing.Point(260, 158);
            this.submit.Margin = new System.Windows.Forms.Padding(2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(88, 33);
            this.submit.TabIndex = 2;
            this.submit.Text = "OK";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // browse
            // 
            this.browse.BackgroundImage = global::RPGMap.Properties.Resources.rectangle_mini_mini_imagePicker;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Location = new System.Drawing.Point(260, 58);
            this.browse.Margin = new System.Windows.Forms.Padding(2);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(88, 33);
            this.browse.TabIndex = 1;
            this.browse.Text = "Buscar";
            this.browse.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(2, 2);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(225, 244);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // ImagePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(375, 249);
            this.MinimumSize = new System.Drawing.Size(375, 249);
            this.Name = "ImagePicker";
            this.Size = new System.Drawing.Size(375, 249);
            this.Load += new System.EventHandler(this.ImagePicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button clear;
    }
}
