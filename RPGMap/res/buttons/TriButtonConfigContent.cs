using RPGMap.dbRPGMap.entities;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMap.res
{
    // Clase que representa un contenido configurado con tres botones en un panel
    public class TriButtonConfigContent : Panel
    {
        private Fonts u;
        public ButtonConfigContent mainButton;
        private Button bttDown, bttUp;
        private Label label;
        private int cont;

        // Propiedad pública para acceder al valor 'cont' privado
        public int Cont
        {
            get { return cont; }
            set { cont = value; }
        }

        // Constructor de la clase TriButtonConfigContent
        public TriButtonConfigContent(Object tabla, Generar generar, Panel layoutButtons)
        {
            u = new Fonts();
            cont = 0;

            // Inicialización de los controles principales
            mainButton = new ButtonConfigContent(tabla, generar, layoutButtons);
            bttDown = new Button();
            bttUp = new Button();
            label = new Label();

            // Configuración del botón principal
            mainButton.Size = new Size(135, 62);
            mainButton.Location = new Point(0, 0);
            mainButton.FlatStyle = FlatStyle.Flat;
            mainButton.Font = u.getFontBttContent();
            mainButton.Image = Properties.Resources.rectangle_mini_mini;

            // Manejo del evento Click del botón principal
            mainButton.Click += (sender, args) =>
            {
                // Eliminar el elemento de la lista según el tipo de tabla
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

                // Eliminar este control del panel de botones
                layoutButtons.Controls.Remove(this);
            };

            // Configuración del botón de decremento
            bttDown.Size = new Size(38, 23);
            bttDown.Location = new Point(mainButton.Right + 5, mainButton.Bottom - 25);
            bttDown.FlatStyle = FlatStyle.Flat;
            bttDown.Image = Properties.Resources.arrow_down;
            bttDown.FlatAppearance.BorderSize = 0;

            // Configuración de eventos para el botón de decremento
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
                await Task.Run(() => Methods.DecrementarContador(label, ref cont));
            };

            bttDown.MouseUp += (sender, args) =>
            {
                Methods.decrementando = false;
            };

            // Configuración del botón de incremento
            bttUp.Size = new Size(38, 23);
            bttUp.Location = new Point(bttDown.Left, mainButton.Top + 5);
            bttUp.FlatStyle = FlatStyle.Flat;
            bttUp.FlatAppearance.BorderSize = 0;
            bttUp.Image = Properties.Resources.arrow;

            // Configuración de eventos para el botón de incremento
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
                await Task.Run(() => Methods.IncrementarContador(label, ref cont));
            };

            bttUp.MouseUp += (sender, args) =>
            {
                Methods.incrementando = false;
            };

            // Configuración de la etiqueta para mostrar el valor
            label.Size = new Size(70, 33);
            label.Location = new Point(bttDown.Right + 5, mainButton.Top + (mainButton.Height - label.Height) / 2);
            label.Text = cont.ToString();
            label.Font = u.getFontLbText();
            label.TextAlign = ContentAlignment.MiddleCenter;

            // Agregar los controles al panel
            Controls.Add(mainButton);
            Controls.Add(bttDown);
            Controls.Add(bttUp);
            Controls.Add(label);
        }

        // Método público para obtener el valor 'cont'
        public int GetCont()
        {
            return cont;
        }
    }
}
