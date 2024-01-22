using RPGMap.dbRPGMap;
using RPGMap.dbRPGMap.entities;
using RPGMap.res.buttons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMap
{
    public partial class RPGMap : Form{
        private Fonts u = new Fonts();

        public RPGMap()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbTittle.Font = u.getFontLbTittle();
            bttGen.Font = u.getFontBtt();
            bttCont.Font = u.getFontBtt();
        }

        private void bttCont_Click(object sender, EventArgs e)
        {
            Content cont = new Content(this);
            cont.Show();
            this.Visible = false;
        }

        private void bttGen_Click(object sender, EventArgs e)
        {
            Generar generar = new Generar(this);
            generar.Show();
            this.Visible = false;
        }
    }
}
