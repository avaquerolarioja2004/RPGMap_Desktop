using RPGMap.res.buttons;
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
    public partial class Content : Form
    {
        private RPGMap rpgMap;
        public char tipe;
        public Content(RPGMap rpgMap)
        {
            InitializeComponent();
            this.rpgMap = rpgMap;
            this.Size = new Size(1555, 991);
        }

        private void Content_Load(object sender, EventArgs e)
        {
            ButtonsMoveInContent btt = new ButtonsMoveInContent(lbTittle, this, bttInfo, bttAdd);
            btt.Location = new Point(12, 227);
            this.Controls.Add(btt);
        }

        private void bttLeft_Click(object sender, EventArgs e)
        {
            rpgMap.Visible = true;
            Visible = false;
        }

        private void Content_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.rpgMap.Close();
        }

        private void bttLeft_MouseEnter(object sender, EventArgs e)
        {
            bttLeft.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttInfo_MouseEnter(object sender, EventArgs e)
        {
            bttInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttAdd_MouseEnter(object sender, EventArgs e)
        {
            bttAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            PopUpAdd p = new PopUpAdd(this);
            p.ShowDialog();
        }

        private void bttInfo_Click(object sender, EventArgs e)
        {
            PopUpInformacion p = new PopUpInformacion(this);
            p.ShowDialog();
        }
    }
}
