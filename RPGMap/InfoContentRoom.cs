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
    public partial class InfoContentRoom : Form
    {
        private Generar generar;
        private List<RoomTable> listaroom;
        private Fonts u = new Fonts();
        private Button bttAddroom;

        public InfoContentRoom()
        {
            InitializeComponent();
        }

        public InfoContentRoom(Generar generar, Button bttAddroom)
        {
            InitializeComponent();
            this.bttAddroom = bttAddroom;
            this.generar = generar;
            listaroom = generar.ListaRoom;
        }

        private void bttGen_Click(object sender, EventArgs e)
        {
            if (generar.ListaRoom.Count < 1)
            {
                Methods.OcultarButton(bttAddroom);
            }
            generar.ListaRoomAux = new List<dbRPGMap.auxTables.AuxRoom>();

            foreach (RoomTable room in listaroom)
            {
                foreach (Control control in layoutButtons.Controls)
                {
                    if (control is TriButtonConfigContent triButton)
                    {
                        int cont = triButton.GetCont();
                        generar.ListaRoomAux.Add(new dbRPGMap.auxTables.AuxRoom(room, cont));
                    }
                }
            }

            this.Close();
        }


        private void Contentobject_Load(object sender, EventArgs e)
        {
            bttClose.Font = u.getFontBttMini();
            tittleRoom.Font = u.getFontLbTittleVecna();
            int buttonsPerRow = 1;
            int separation = 45;
            int currentX = 80;
            int currentY = 0;

            foreach (var objeto in listaroom)
            {
                TriButtonConfigContent objectButton = new TriButtonConfigContent(objeto, generar, layoutButtons);
                objectButton.Size = new Size(350, 100);

                // Verifica si agregar el panel en la fila actual superará el ancho del contenedor
                if (currentX + objectButton.Width + separation > layoutButtons.Width)
                {
                    // Si supera el ancho del contenedor, pasa a la siguiente fila
                    currentX = 80;
                    currentY += objectButton.Height + separation;
                }

                // Establece la posición del panel y agrégalo al contenedor
                objectButton.Location = new Point(currentX, currentY);
                layoutButtons.Controls.Add(objectButton);

                // Actualiza la posición X para el próximo panel
                currentX += objectButton.Width + separation;

                // Verifica si se llegó al máximo de paneles por fila
                if ((currentX + separation) / (objectButton.Width + separation) == buttonsPerRow)
                {
                    currentX = 80;
                    currentY += objectButton.Height + separation;
                }
            }
        }
    }
}
