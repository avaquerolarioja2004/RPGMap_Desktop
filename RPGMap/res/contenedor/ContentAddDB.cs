using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using CustomControls.Controls;
using System.Runtime.ConstrainedExecution;
using System.IO;

namespace RPGMap.res.contenedor
{
    class ContentAddDB:Panel
    {
        private PopUpAdd p;
        private Fonts f;
        public ContentAddDB(char tipe, PopUpAdd p)
        {
            this.p = p;
            f = new Fonts();
            this.Size = new Size(887, 483);
            this.Location = new Point(43, 102);
            this.BackColor = Color.Transparent;
            this.BackgroundImageLayout= ImageLayout.None;
            if (tipe == 'R')
            {
                RoomPicker roomPicker = new RoomPicker
                {
                    Location = new Point(167, 28)
                };

                p.DimProvider = () => (roomPicker.X, roomPicker.Y);

                Controls.Add(roomPicker);
            }
            else if (tipe == 'O')
            {

                // Label indicating the purpose with increased font size
                Label nameLabel = new Label();
                nameLabel.Text = "Nombre:";
                nameLabel.Location = new Point(156, 48*3);
                nameLabel.Font = f.getFontLbText();
                nameLabel.AutoSize = true;
                this.Controls.Add(nameLabel);

                // TextBox for user input with increased font size
                TextBox nameTextBox = new TextBox();
                nameTextBox.Location = new Point(nameLabel.Right + 10, 48 *3);
                nameTextBox.Font = f.getFontLbText();
                this.Controls.Add(nameTextBox);

                // ImagePicker centered beneath TextBox
                ImagePicker imagePicker = new ImagePicker();
                imagePicker.Location = new Point(nameTextBox.Right + 50, 48);
                this.Controls.Add(imagePicker);
                
                p.ImageProvider = () => {
                    MemoryStream ms = new MemoryStream();
                    Image image = imagePicker.Image;
                    image.Save(ms, image.RawFormat);
                    return ms.ToArray();
                };

                // Add space between the TextBox and ImagePicker
                int spacing = 20;

                // Handle text input in the TextBox
                nameTextBox.TextChanged += (sender, e) =>
                {
                    this.p.name = nameTextBox.Text;
                };
            }
            else if (tipe == 'E')
            {
                int difi = 0;
                // Label indicating some information for option 'E'
                Label infoLabelE = new Label();
                infoLabelE.Text = "Nombre:";
                infoLabelE.Location = new Point(156, 48 * 2);
                infoLabelE.Font = f.getFontLbText();
                infoLabelE.AutoSize = true;
                this.Controls.Add(infoLabelE);

                // TextBox for user input related to option 'E'
                TextBox textBoxE = new TextBox();
                textBoxE.Location = new Point(infoLabelE.Right + 10, 48 * 2);
                textBoxE.Font = f.getFontLbText();
                this.Controls.Add(textBoxE);

                // Label for level
                Label levelLabel = new Label();
                levelLabel.Size = new Size(160, 33);
                levelLabel.Location = new Point(156, 48 * 4);
                levelLabel.Text = "Dificultad:";
                levelLabel.Font = f.getFontLbText();
                levelLabel.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(levelLabel);

                // Label for level
                Label dif = new Label();
                dif.Size = new Size(70, 33);
                dif.Location = new Point(levelLabel.Right+1, 48 * 4);
                dif.Text = difi+"";
                dif.Font = f.getFontLbText();
                dif.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(dif);

                // Buttons for adjusting the level
                Button bttDown = new Button();
                bttDown.Size = new Size(38, 23);
                bttDown.Location = new Point(dif.Right +1, dif.Bottom - 7);
                bttDown.FlatStyle = FlatStyle.Flat;
                bttDown.Image = Properties.Resources.arrow_down;
                bttDown.FlatAppearance.BorderSize = 0;
                bttDown.MouseEnter += (sender, args) =>
                {
                    bttDown.FlatAppearance.MouseOverBackColor = Color.Transparent;
                };

                bttDown.MouseEnter += (sender, args) =>
                {
                    bttDown.BackColor = Color.Transparent;
                };

                bttDown.MouseDown += async (sender, args) =>
                {
                    Methods.decrementando = true;
                    await Task.Run(() => Methods.DecrementarContador(dif, ref difi));
                    this.p.difficulty = difi;
                };

                bttDown.MouseUp += (sender, args) =>
                {
                    Methods.decrementando = false;
                };

                Button bttUp = new Button();
                bttUp.Size = new Size(38, 23);
                bttUp.Location = new Point(bttDown.Left, dif.Top - 7);
                bttUp.FlatStyle = FlatStyle.Flat;
                bttUp.FlatAppearance.BorderSize = 0;
                bttUp.Image = Properties.Resources.arrow;
                bttUp.MouseEnter += (sender, args) =>
                {
                    bttUp.FlatAppearance.MouseOverBackColor = Color.Transparent;
                };

                bttUp.MouseEnter += (sender, args) =>
                {
                    bttUp.BackColor = Color.Transparent;
                };

                bttUp.MouseDown += async (sender, args) =>
                {
                    Methods.incrementando = true;
                    await Task.Run(() => Methods.IncrementarContador(dif, ref difi));
                    this.p.difficulty = difi;
                };

                bttUp.MouseUp += (sender, args) =>
                {
                    Methods.incrementando = false;
                };

                this.Controls.Add(bttDown);
                this.Controls.Add(bttUp);

                // ImagePicker centered beneath TextBox
                ImagePicker imagePicker = new ImagePicker();
                imagePicker.Location = new Point(bttDown.Right + 25, 48);

                p.ImageProvider = () => {
                    MemoryStream ms = new MemoryStream();
                    Image image = imagePicker.Image;
                    image.Save(ms, image.RawFormat);
                    return ms.ToArray();
                };

                this.Controls.Add(imagePicker);
                textBoxE.TextChanged += (sender, e) =>
                {
                    this.p.name = textBoxE.Text;
                };
            }
            else if (tipe == 'F')
            {
                int xValue = 0;
                int yValue = 0;

                // Label indicating some information for option 'F'
                Label infoLabelF = new Label();
                infoLabelF.Text = "Nombre:";
                infoLabelF.Location = new Point(156, 48);
                infoLabelF.Font = f.getFontLbText();
                infoLabelF.AutoSize = true;
                this.Controls.Add(infoLabelF);

                // TextBox for user input related to option 'F'
                TextBox textBoxF = new TextBox();
                textBoxF.Location = new Point(infoLabelF.Right + 10, 48);
                textBoxF.Font = f.getFontLbText();
                this.Controls.Add(textBoxF);

                // Label for X value
                Label xLabel = new Label();
                xLabel.Size = new Size(70, 33);
                xLabel.Location = new Point(156, (int)(48 * 2.5));
                xLabel.Text = "X:";
                xLabel.Font = f.getFontLbText();
                xLabel.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(xLabel);

                // Label for X value
                Label xValueLabel = new Label();
                xValueLabel.Size = new Size(70, 33);
                xValueLabel.Location = new Point(xLabel.Right + 1, (int)(48 * 2.5));
                xValueLabel.Text = xValue.ToString();
                xValueLabel.Font = f.getFontLbText();
                xValueLabel.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(xValueLabel);

                // Buttons for adjusting X value
                Button bttXDown = new Button();
                bttXDown.Size = new Size(38, 23);
                bttXDown.Location = new Point(xValueLabel.Right + 1, xValueLabel.Bottom - 7);
                bttXDown.FlatStyle = FlatStyle.Flat;
                bttXDown.Image = Properties.Resources.arrow_down;
                bttXDown.FlatAppearance.BorderSize = 0;
                bttXDown.MouseEnter += (sender, args) =>
                {
                    bttXDown.FlatAppearance.MouseOverBackColor = Color.Transparent;
                };

                bttXDown.MouseEnter += (sender, args) =>
                {
                    bttXDown.BackColor = Color.Transparent;
                };

                bttXDown.MouseDown += async (sender, args) =>
                {
                    Methods.decrementando = true;
                    await Task.Run(() => Methods.DecrementarContador(xValueLabel, ref xValue));
                    this.p.X = xValue;
                };

                bttXDown.MouseUp += (sender, args) =>
                {
                    Methods.decrementando = false;
                };

                Button bttXUp = new Button();
                bttXUp.Size = new Size(38, 23);
                bttXUp.Location = new Point(bttXDown.Left, xValueLabel.Top - 7);
                bttXUp.FlatStyle = FlatStyle.Flat;
                bttXUp.FlatAppearance.BorderSize = 0;
                bttXUp.Image = Properties.Resources.arrow;
                bttXUp.MouseEnter += (sender, args) =>
                {
                    bttXUp.FlatAppearance.MouseOverBackColor = Color.Transparent;
                };

                bttXUp.MouseEnter += (sender, args) =>
                {
                    bttXUp.BackColor = Color.Transparent;
                };

                bttXUp.MouseDown += async (sender, args) =>
                {
                    Methods.incrementando = true;
                    await Task.Run(() => Methods.IncrementarContador10(xValueLabel, ref xValue));
                    this.p.X = xValue;
                };

                bttXUp.MouseUp += (sender, args) =>
                {
                    Methods.incrementando = false;
                };

                this.Controls.Add(bttXDown);
                this.Controls.Add(bttXUp);

                // Label for Y value
                Label yLabel = new Label();
                yLabel.Size = new Size(70, 33);
                yLabel.Location = new Point(156, 48 * 4);
                yLabel.Text = "Y:";
                yLabel.Font = f.getFontLbText();
                yLabel.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(yLabel);

                // Label for Y value
                Label yValueLabel = new Label();
                yValueLabel.Size = new Size(70, 33);
                yValueLabel.Location = new Point(yLabel.Right + 1, 48 * 4);
                yValueLabel.Text = yValue.ToString();
                yValueLabel.Font = f.getFontLbText();
                yValueLabel.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(yValueLabel);

                // Buttons for adjusting Y value
                Button bttYDown = new Button();
                bttYDown.Size = new Size(38, 23);
                bttYDown.Location = new Point(yValueLabel.Right + 1, yValueLabel.Bottom - 7);
                bttYDown.FlatStyle = FlatStyle.Flat;
                bttYDown.Image = Properties.Resources.arrow_down;
                bttYDown.FlatAppearance.BorderSize = 0;
                bttYDown.MouseEnter += (sender, args) =>
                {
                    bttYDown.FlatAppearance.MouseOverBackColor = Color.Transparent;
                };

                bttYDown.MouseEnter += (sender, args) =>
                {
                    bttYDown.BackColor = Color.Transparent;
                };

                bttYDown.MouseDown += async (sender, args) =>
                {
                    Methods.decrementando = true;
                    await Task.Run(() => Methods.DecrementarContador(yValueLabel, ref yValue));
                    this.p.Y = yValue;
                };

                bttYDown.MouseUp += (sender, args) =>
                {
                    Methods.decrementando = false;
                };

                Button bttYUp = new Button();
                bttYUp.Size = new Size(38, 23);
                bttYUp.Location = new Point(bttYDown.Left, yValueLabel.Top - 7);
                bttYUp.FlatStyle = FlatStyle.Flat;
                bttYUp.FlatAppearance.BorderSize = 0;
                bttYUp.Image = Properties.Resources.arrow;
                bttYUp.MouseEnter += (sender, args) =>
                {
                    bttYUp.FlatAppearance.MouseOverBackColor = Color.Transparent;
                };

                bttYUp.MouseEnter += (sender, args) =>
                {
                    bttYUp.BackColor = Color.Transparent;
                };

                bttYUp.MouseDown += async (sender, args) =>
                {
                    Methods.incrementando = true;
                    await Task.Run(() => Methods.IncrementarContador10(yValueLabel, ref yValue));
                    this.p.Y = yValue;
                };

                bttYUp.MouseUp += (sender, args) =>
                {
                    Methods.incrementando = false;
                };

                this.Controls.Add(bttYDown);
                this.Controls.Add(bttYUp);

                // Label for "Cubre visibilidad"
                Label cubreVisibilidadLabel = new Label();
                cubreVisibilidadLabel.Text = "Cubre visibilidad:";
                cubreVisibilidadLabel.Location = new Point(156, (int)(48 * 5.5));
                cubreVisibilidadLabel.Font = f.getFontLbText();
                cubreVisibilidadLabel.AutoSize = true;
                this.Controls.Add(cubreVisibilidadLabel);

                // Checkbox for "Cubre visibilidad"
                CheckBox cubreVisibilidadCheckBox = new CheckBox();
                cubreVisibilidadCheckBox.Location = new Point(cubreVisibilidadLabel.Right + 10, (int)(48 * 5.5) + 12);
                this.Controls.Add(cubreVisibilidadCheckBox);

                ImagePicker imagePicker = new ImagePicker();
                imagePicker.Location = new Point(cubreVisibilidadCheckBox.Right + 15, 48);
                this.Controls.Add(imagePicker);

                p.ImageProvider = () => {
                    MemoryStream ms = new MemoryStream();
                    Image image = imagePicker.Image;
                    image.Save(ms, image.RawFormat);
                    return ms.ToArray();
                };

                textBoxF.TextChanged += (sender, e) =>
                {
                    this.p.name = textBoxF.Text;
                };
                cubreVisibilidadCheckBox.CheckedChanged += (sender, e) =>
                {
                    this.p.covers=cubreVisibilidadCheckBox.Checked;
                };
            }
        }
    }
}
