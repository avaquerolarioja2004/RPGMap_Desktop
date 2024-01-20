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
    public partial class PopUpInformacion : Form
    {
        private Fonts u;
        private Content c;

        public PopUpInformacion(Content c)
        {
            InitializeComponent();
            this.c = c;
            char tipe = c.tipe;
            u = new Fonts();
            tittleDelete.Font = u.getFontLbTittleVecna();
            this.bttClose.Font = u.getFontBttContent();
            SetInfoLabelText(); // Call the method to set the info label text
            info.AutoSize = true;
            info.TextAlign = ContentAlignment.MiddleCenter;
            info.MaximumSize = new System.Drawing.Size(450, 0);
            info.Font = u.getFontBttMini();
        }

        private void SetInfoLabelText()
        {
            switch (c.tipe)
            {
                case 'R':
                    info.Text = "PARA AÑADIR UNA SALA DEBES DE SELECIONAR EL ALTO Y EL ANCHO HACIENDO USO DE LA CUADRICULA SELECCIONANDO CON EL CURSOR.\nTENDRÁ QUE REFRESCAR LA PANTALLA PARA VER LOS CAMBIOS.";
                    break;
                case 'O':
                    info.Text = "PARA AÑADIR UN OBJETO DEBES DE DARLE UN NOMBRE Y AÑADIR UNA IMAGEN PARA QUE APAREZCA EN EL MAPA, HACIENDO CLICK EN EL BOTÓN DE AÑADIR." +
                        "\nTENDRÁ QUE REFRESCAR LA PANTALLA PARA VER LOS CAMBIOS.";
                    break;
                case 'F':
                    info.Text = "PARA AÑADIR UN MUEBLE DEBES DE DARLE UN NOMBRE, UN VALOR A SU ALTO Y ANCHO, INDICAR SI CUBRE LA VISIBILIDAD O NO Y" +
                        " AÑADIR UNA IMAGEN PARA QUE APAREZCA EN EL MAPA, HACIENDO CLICK EN EL BOTÓN DE AÑADIR.\nTENDRÁ QUE REFRESCAR LA PANTALLA PARA VER LOS CAMBIOS.";
                    break;
                case 'E':
                    info.Text = "PARA AÑADIR UN ENEMIGO DEBES DE DARLE UN NOMBRE, ELEGIR UNA DIFICULTAD Y AÑADIR UNA IMAGEN PARA QUE " +
                        "APAREZCA EN EL MAPA, HACIENDO CLICK EN EL BOTÓN DE AÑADIR.\nTENDRÁ QUE REFRESCAR LA PANTALLA PARA VER LOS CAMBIOS.";
                    break;
            }
        }

        private void bttClose_Click_1(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
