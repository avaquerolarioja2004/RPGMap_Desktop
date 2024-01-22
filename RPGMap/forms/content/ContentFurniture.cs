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
    public partial class ContentFurniture : Form
    {
        private Generar generar;
        private List<FurnitureTable> listaobject;
        private Fonts u = new Fonts();
        private Button bttAddobject;

        public ContentFurniture()
        {
            InitializeComponent();
        }

        public ContentFurniture(Generar generar, Button bttAddobject)
        {
            InitializeComponent();
            this.bttAddobject = bttAddobject;
            this.generar = generar;
            listaobject = CRDFurniture.GetAllFurniture().Where(objeto => !generar.ListaFurniture.Contains(objeto)).ToList();
        }

        private void bttGen_Click(object sender, EventArgs e)
        {
            if (generar.ListaFurniture.Count > 0)
            {
                Methods.MostrarButton(bttAddobject);
            }
            this.Close();
        }

        private void Contentobject_Load(object sender, EventArgs e)
        {
            bttClose.Font = u.getFontBttMini();
            tittlefurniture.Font = u.getFontLbTittleVecna();
            int buttonsPerRow = 2;
            int separation = 65;
            int currentX = 70;
            int currentY = 0;

            foreach (var objeto in listaobject)
            {
                //Caben bien nombres de 9 caracteres con formato nombre: dificultad
                ButtonAddCont objectButton = new ButtonAddCont(objeto, generar, layoutButtons);
                objectButton.Size = new Size(135, 62);

                // Verifica si agregar el botón en la fila actual superará el ancho del panel
                if (currentX + objectButton.Width + separation > layoutButtons.Width)
                {
                    // Si supera el ancho del panel, pasa a la siguiente fila
                    currentX = 0;
                    currentY += objectButton.Height + separation;
                }

                // Establece la posición del botón y agrégalo al contenedor
                objectButton.Location = new Point(currentX, currentY);
                objectButton.Font = u.getFontBttContent();
                objectButton.FlatStyle = FlatStyle.Flat;
                objectButton.BackgroundImage = Properties.Resources.rectangle_mini_mini;
                layoutButtons.Controls.Add(objectButton);

                // Actualiza la posición X para el próximo botón
                currentX += objectButton.Width + separation;

                // Verifica si se llegó al máximo de botones por fila
                if ((currentX + separation) / (objectButton.Width + separation) == buttonsPerRow)
                {
                    currentX = 70;
                    currentY += objectButton.Height + separation;
                }
            }
        }
    }
}
