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
    public partial class PopUpOutGen : Form
    {
        private Fonts u;
        public bool borrado;

        public PopUpOutGen()
        {
            InitializeComponent();
            u = new Fonts();
            tittleDelete.Font = u.getFontLbTittleVecna();
            this.bttClose.Font = u.getFontBttContent();
            this.bttDelete.Font = u.getFontBttContent();
            info.Text = "¿Estás seguro que quieres quitar este objeto de la generación del mapa?\n\n" +
                "Esta operación se puede revertir volviendo a añadir el objeto.";
            info.AutoSize = true;
            info.TextAlign = ContentAlignment.MiddleCenter;
            info.MaximumSize = new System.Drawing.Size(450, 0);
            info.Font = u.getFontBttMini();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.borrado = true;
            this.Close();
        }

        private void bttClose_Click_1(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
