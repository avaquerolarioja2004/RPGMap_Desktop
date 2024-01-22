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
    public partial class InfoContentObject : Form
    {
        private Generar generar;
        private List<ObjectTable> listaobjectTable;
        private Fonts u = new Fonts();
        private Button bttAddobjectTable;

        public InfoContentObject()
        {
            InitializeComponent();
        }

        public InfoContentObject(Generar generar, Button bttAddobjectTable)
        {
            InitializeComponent();
            this.bttAddobjectTable = bttAddobjectTable;
            this.generar = generar;
            listaobjectTable = generar.ListaObject;
        }

        private void bttGen_Click(object sender, EventArgs e)
        {
            if (generar.ListaObject.Count < 1)
            {
                Methods.OcultarButton(bttAddobjectTable);
            }
            generar.ListaObjectAux = new List<dbRPGMap.auxTables.AuxObject>();

            foreach (ObjectTable objectTable in listaobjectTable)
            {
                foreach (Control control in layoutButtons.Controls)
                {
                    if (control is TriButtonConfigContent triButton)
                    {
                        int cont = triButton.GetCont();
                        generar.ListaObjectAux.Add(new dbRPGMap.auxTables.AuxObject(objectTable, cont));
                    }
                }
            }

            this.Close();
        }


        private void Contentobject_Load(object sender, EventArgs e)
        {
            bttClose.Font = u.getFontBttMini();
            tittleObject.Font = u.getFontLbTittleVecna();
            int buttonsPerRow = 1;
            int separation = 45;
            int currentX = 80;
            int currentY = 0;

            foreach (var objeto in listaobjectTable)
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
