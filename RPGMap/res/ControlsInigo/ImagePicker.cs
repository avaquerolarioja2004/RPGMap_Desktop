using RPGMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.Controls
{
    public partial class ImagePicker : UserControl
    {
        private Fonts f;

        public Image Image { get; private set; }

        public ImagePicker()
        {
            InitializeComponent();
            f = new Fonts();
            pictureBox.BorderStyle = BorderStyle.FixedSingle;

            pictureBox.AllowDrop = true;
            pictureBox.DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            };

            pictureBox.DragDrop += (s, e) =>
            {
                string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);

                if(files.Length == 1)
                {
                    SetImage(files[0]);
                }
                else
                {
                    MessageBox.Show("Más de un archivo arrastrado", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            browse.Click += (s, e) =>
            {
                using (OpenFileDialog dialog = new OpenFileDialog()
                {
                    AddExtension = true,
                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = "png",
                    Title = "Selecciona una imagen",
                    Filter = "Image Files|*.png"
                })
                {
                    if(dialog.ShowDialog() == DialogResult.OK)
                    {
                        SetImage(dialog.FileName);
                    }
                }
            };

            clear.Click += (s, e) => SetImage(null);
        }

        private void SetImage(string file)
        {
            if(file != null)
            {
                if(Path.GetExtension(file) == ".png")
                {
                    Image = Image.FromFile(file);
                    label.Visible = false;

                    pictureBox.Image = new Bitmap(Image, pictureBox.Size);
                }
                else
                {
                    MessageBox.Show("Selecciona una imagen .png", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                pictureBox.Image = Image = null;
                label.Visible = true;
            }
        }

        private void ImagePicker_Load(object sender, EventArgs e)
        {
            this.browse.Font = f.getFontBttRoomPicker();
            this.clear.Font = f.getFontBttRoomPicker();
            this.browse.BackgroundImage = RPGMap.Properties.Resources.rectangle_mini_mini_imagePicker;
            this.clear.BackgroundImage = RPGMap.Properties.Resources.rectangle_mini_mini_imagePicker;
            this.label.Font = f.getFontLbRoomPicker();
        }
    }
}
