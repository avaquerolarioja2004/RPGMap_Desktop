using RPGMap.dbRPGMap.entities;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMap.res
{
    public class TriButtonConfigContent : Panel
    {
        private Fonts u;
        public ButtonConfigContent mainButton;
        private Button bttDown, bttUp;
        private Label label;
        private int cont;
        public int Cont
        {
            get { return cont; }
            set { cont = value; }
        }

        public TriButtonConfigContent(Object tabla, Generar generar, Panel layoutButtons)
        {
            u = new Fonts();
            cont = 0;
            mainButton = new ButtonConfigContent(tabla, generar, layoutButtons);
            bttDown = new Button();
            bttUp = new Button();
            label = new Label();

            mainButton.Size = new Size(135, 62);
            mainButton.Location = new Point(0, 0);
            mainButton.FlatStyle = FlatStyle.Flat;
            mainButton.Font = u.getFontBttContent();
            mainButton.Image = Properties.Resources.rectangle_mini_mini;
            mainButton.Click += (sender, args) =>
            {
                switch (tabla)
                {
                    case EnemyTable _:
                        generar.ListaEnemy.Remove((EnemyTable)tabla);
                        break;
                    case RoomTable _:
                        generar.ListaRoom.Remove((RoomTable)tabla);
                        break;
                    case FurnitureTable _:
                        generar.ListaFurniture.Remove((FurnitureTable)tabla);
                        break;
                    case ObjectTable _:
                        generar.ListaObject.Remove((ObjectTable)tabla);
                        break;
                }

                layoutButtons.Controls.Remove(this);
            };

            bttDown.Size = new Size(38, 23);
            bttDown.Location = new Point(mainButton.Right + 5, mainButton.Bottom - 25);
            bttDown.FlatStyle = FlatStyle.Flat;
            bttDown.Image = Properties.Resources.arrow_down;
            bttDown.FlatAppearance.BorderSize = 0;
            bttDown.Click += (sender, args) =>
            {
                if (cont > 0)
                {
                    cont--;
                    label.Text = cont.ToString();
                }
            };

            bttDown.MouseEnter += (sender, args) =>
            {
                bttDown.BackColor = Color.Transparent;
            };

            bttDown.MouseDown += async (sender, args) =>
            {
                Methods.decrementando = true;
                await Task.Run(() => Methods.DecrementarContador(label, ref cont));
            };

            bttDown.MouseUp += (sender, args) =>
            {
                Methods.decrementando = false;
            };

            bttUp.Size = new Size(38, 23);
            bttUp.Location = new Point(bttDown.Left, mainButton.Top + 5);
            bttUp.FlatStyle = FlatStyle.Flat;
            bttUp.FlatAppearance.BorderSize = 0;
            bttUp.Image = Properties.Resources.arrow;
            bttUp.Click += (sender, args) =>
            {
                if (cont < 100)
                {
                    cont++;
                    label.Text = cont.ToString();
                }
            };

            bttUp.MouseEnter +=(sender, args) =>
            {
                bttUp.BackColor = Color.Transparent;
            };

            bttUp.MouseDown+= async (sender, args) =>
            {
                Methods.incrementando = true;
                await Task.Run(() => Methods.IncrementarContador(label, ref cont));
            };

            bttUp.MouseUp += (sender, args) =>
            {
                Methods.incrementando = false;
            };

            label.Size = new Size(70, 33);
            label.Location = new Point(bttDown.Right + 5, mainButton.Top + (mainButton.Height - label.Height) / 2);
            label.Text = cont.ToString();
            label.Font = u.getFontLbText();
            label.TextAlign = ContentAlignment.MiddleCenter;

            Controls.Add(mainButton);
            Controls.Add(bttDown);
            Controls.Add(bttUp);
            Controls.Add(label);
        }
        public int GetCont()
        {
            return cont;
        }
    }
}
