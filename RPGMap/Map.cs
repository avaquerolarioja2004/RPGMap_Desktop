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
    public partial class Map : Form
    {
        private Generar generar;

        public Map()
        {
            InitializeComponent();
        }

        public Map(Generar generar)
        {
            InitializeComponent();
            this.generar = generar;
        }

        private void Map_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.generar.Close();
        }

        private void bttLeft_Click(object sender, EventArgs e)
        {
            this.generar.Visible = true;
            Visible = false;
        }

        private void bttLeft_MouseEnter(object sender, EventArgs e)
        {
            bttBackToGen.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
    }
}
