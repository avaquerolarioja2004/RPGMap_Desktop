using RPGMap.dbRPGMap;
using RPGMap.dbRPGMap.entities;
using RPGMap.res.buttons;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPGMap
{
    public partial class PopUpBorrado : Form
    { 
        private Object e;
        private Fonts u;
        public bool borrado;

        public PopUpBorrado()
        {
            InitializeComponent();
        }

        public PopUpBorrado(Object e)
        {
            InitializeComponent();
            u = new Fonts();
            tittleDelete.Font = u.getFontLbTittleVecna();
            this.bttClose.Font = u.getFontBttContent();
            this.bttDelete.Font = u.getFontBttContent();
            info.Text = "¿Estás seguro que quieres realizar el borrado de este objeto de la base de datos?\n\n" +
                "Esta operación no se podrá revertir, tendrás que volver a crear el objeto.";
            info.AutoSize = true;
            info.TextAlign= ContentAlignment.MiddleCenter;
            info.MaximumSize = new System.Drawing.Size(450, 0);
            info.Font = u.getFontBttMini();
            this.e = e;
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
