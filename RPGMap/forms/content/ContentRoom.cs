using RPGMap.dbRPGMap;
using RPGMap.dbRPGMap.entities;
using RPGMap.res;
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
    public partial class ContentRoom : Form
    {
        private Generar generar;
        private List<RoomTable> listaroom;
        private Fonts u = new Fonts();
        private Button bttAddroom;

        public ContentRoom()
        {
            InitializeComponent();
        }

        public ContentRoom(Generar generar, Button bttAddroom)
        {
            InitializeComponent();
            this.bttAddroom = bttAddroom;
            this.generar = generar;
            listaroom = CRDRoom.GetAll().Where(room => !generar.ListaRoom.Contains(room)).ToList();
        }

        private void bttGen_Click(object sender, EventArgs e)
        {
            if (generar.ListaRoom.Count > 0)
            {
                Methods.MostrarButton(bttAddroom);
            }
            this.Close();
        }

        private void Contentroom_Load(object sender, EventArgs e)
        {
            bttClose.Font = u.getFontBttMini();
            tittleRoom.Font = u.getFontLbTittleVecna();
            int buttonsPerRow = 2;
            int separation = 65;
            int currentX = 70;
            int currentY = 0;

            foreach (var room in listaroom)
            {
                //Caben bien nombres de 9 caracteres con formato nombre: dificultad
                ButtonAddCont roomButton = new ButtonAddCont(room, generar, layoutButtons);
                roomButton.Size = new Size(135, 62);

                // Verifica si agregar el botón en la fila actual superará el ancho del panel
                if (currentX + roomButton.Width + separation > layoutButtons.Width)
                {
                    // Si supera el ancho del panel, pasa a la siguiente fila
                    currentX = 0;
                    currentY += roomButton.Height + separation;
                }

                // Establece la posición del botón y agrégalo al contenedor
                roomButton.Location = new Point(currentX, currentY);
                roomButton.Font = u.getFontBttContent();
                roomButton.FlatStyle = FlatStyle.Flat;
                roomButton.BackgroundImage = Properties.Resources.rectangle_mini_mini;
                layoutButtons.Controls.Add(roomButton);

                // Actualiza la posición X para el próximo botón
                currentX += roomButton.Width + separation;

                // Verifica si se llegó al máximo de botones por fila
                if ((currentX + separation) / (roomButton.Width + separation) == buttonsPerRow)
                {
                    currentX = 70;
                    currentY += roomButton.Height + separation;
                }
            }
        }
    }
}
