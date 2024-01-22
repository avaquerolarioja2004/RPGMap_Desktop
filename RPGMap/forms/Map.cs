using RPGMap.dbRPGMap.auxTables;
using RPGMap.dbRPGMap.entities;
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
        private int difficulty, corridor, sDoor;
        private List<EnemyTable> listaEnemy;
        private List<AuxFurniture> listaFurniture1;
        private List<AuxObject> listaObject1;
        private List<AuxRoom> listaRoom1;

        public Map()
        {
            InitializeComponent();
        }


        public Map(Generar generar, List<EnemyTable> listaEnemy, List<AuxFurniture> listaFurniture1, List<AuxObject> listaObject1, List<AuxRoom> listaRoom1, int difficulty, int corridor, int sDoor)
        {
            InitializeComponent();
            this.generar = generar;
            this.listaEnemy = listaEnemy;
            this.listaFurniture1 = listaFurniture1;
            this.listaObject1 = listaObject1;
            this.listaRoom1 = listaRoom1;
            this.sDoor = sDoor;
            this.corridor = corridor;
            this.difficulty = difficulty;
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
