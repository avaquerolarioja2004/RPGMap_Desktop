using desktop;
using RPGMap.dbRPGMap.auxTables;
using RPGMap.dbRPGMap.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMap
{
    public partial class Map : Form
    {
        private readonly Generar generar;
        private readonly PictureBox pictureBox;

        public Map(Generar generar, string json)
        {
            InitializeComponent();
            this.generar = generar;

            const int padding = 80;
            int maxWidth = Width - 2 * padding;
            int maxHeight = bttBackToGen.Location.Y - 2 * padding;
            
            pictureBox = new PictureBox()
            {
                Location = new Point(padding, padding),
                Size = new Size(maxWidth, maxHeight),
                SizeMode = PictureBoxSizeMode.CenterImage,
                BackColor = Color.Transparent,
            };

            Controls.Add(pictureBox);

            generate(json);
            regenButton.Click += (s, e) => generate(json);
            regenButton.Location = new Point(
                (Width - regenButton.Width) / 2,
                bttBackToGen.Location.Y + bttBackToGen.Height / 2 - regenButton.Height / 2
            );
        }

        private void Map_FormClosed(object sender, FormClosedEventArgs e)
        {
            generar.Close();
        }

        private void bttLeft_Click(object sender, EventArgs e)
        {
            generar.Visible = true;
            Visible = false;
        }

        private void bttLeft_MouseEnter(object sender, EventArgs e)
        {
            bttBackToGen.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void generate(string json)
        {
            Image image = Algorithm.Generate(json);

            if(image != null)
            {
                decimal ratio = Math.Min(
                    pictureBox.Width / (decimal) image.Width,
                    pictureBox.Height / (decimal) image.Height
                );

                Size size = new Size(
                    (int) Math.Round(image.Width * ratio),
                    (int) Math.Round(image.Height * ratio)
                );

                pictureBox.Image = new Bitmap(image, size);
            }
        }
    }
}
