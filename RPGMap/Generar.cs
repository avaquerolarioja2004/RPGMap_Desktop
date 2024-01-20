using RPGMap.dbRPGMap.auxTables;
using RPGMap.dbRPGMap.entities;
using RPGMap.res;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMap
{
    public partial class Generar : Form
    {
        private List<EnemyTable> listaEnemy;
        private List<AuxRoom> listaRoomAux;
        private List<AuxObject> listaObjectAux;
        private List<AuxFurniture> listaFurnitureAux;
        private List<RoomTable> listaRoom;
        private List<ObjectTable> listaObject;
        private List<FurnitureTable> listaFurniture;
        private RPGMap mainForm;
        private Fonts u = new Fonts();
        private int contDifficulty=0;
        private int contSDoor = 0;
        private int contCorridor = 0;

        public List<EnemyTable> ListaEnemy
        {
            get { return listaEnemy; }
            set { listaEnemy = value; }
        }

        public List<AuxRoom> ListaRoomAux
        {
            get { return listaRoomAux; }
            set { listaRoomAux = value; }
        }

        public List<AuxObject> ListaObjectAux
        {
            get { return listaObjectAux; }
            set { listaObjectAux = value; }
        }

        public List<AuxFurniture> ListaFurnitureAux
        {
            get { return listaFurnitureAux; }
            set { listaFurnitureAux = value; }
        }

        public List<RoomTable> ListaRoom
        {
            get { return listaRoom; }
            set { listaRoom = value; }
        }

        public List<ObjectTable> ListaObject
        {
            get { return listaObject; }
            set { listaObject = value; }
        }

        public List<FurnitureTable> ListaFurniture
        {
            get { return listaFurniture; }
            set { listaFurniture = value; }
        }

        public Generar()
        {
            InitializeComponent();
        }

        public Generar(RPGMap mainForm)
        {
            InitializeComponent();
            this.Size = new Size(1555, 991);
            this.mainForm = mainForm;
            listaEnemy = new List<EnemyTable>();
            listaRoomAux = new List<AuxRoom>();
            listaObjectAux = new List<AuxObject>();
            listaFurnitureAux = new List<AuxFurniture>();
            listaRoom = new List<RoomTable>();
            listaObject = new List<ObjectTable>();
            listaFurniture = new List<FurnitureTable>();
        }

        private void Generar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainForm.Close();
        }

        private void bttRigth_Click(object sender, EventArgs e)
        {
            Map m = new Map(this, listaEnemy, listaFurnitureAux, listaObjectAux, listaRoomAux, contDifficulty, contCorridor, contSDoor);
            m.Show();
            Visible = false;
        }

        private void bttLeft_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            Visible = false;
        }

        private void bttLeft_MouseEnter(object sender, EventArgs e)
        {
            bttLeft.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttRigth_MouseEnter(object sender, EventArgs e)
        {
            bttGen.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void Generar_Load(object sender, EventArgs e)
        {
            difficulty.Text = contDifficulty.ToString();
            this.BackgroundImage = Properties.Resources.untitled;
            corridor.Text = contCorridor.ToString();
            sDoor.Text = contSDoor + "%";
            lbTittle.Font = u.getFontLbTittleVecna();
            bttGen.Font = u.getFontBttMini();
            lbCorrior.Font = u.getFontLbText();
            lbDificulty.Font = u.getFontLbText();
            lbEnemy.Font = u.getFontLbText();
            lbFurniture.Font = u.getFontLbText();
            lbObject.Font = u.getFontLbText();
            lbRooms.Font = u.getFontLbText();
            lbSecretDoor.Font = u.getFontLbText();
            difficulty.Font = u.getFontLbText();
            corridor.Font = u.getFontLbText();
            sDoor.Font = u.getFontLbText();
            Methods.OcultarButton(bttContentFurniture);
            Methods.OcultarButton(bttContentObjects);
            Methods.OcultarButton(bttContentRooms);
            Methods.OcultarButton(bttContentEnemies);
        }

        private void bttUpDif_MouseEnter(object sender, EventArgs e)
        {
            bttUpDif.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttDownDif_MouseEnter(object sender, EventArgs e)
        {
            bttDownDif.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private async void bttUpDif_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.incrementando = true;
            await Task.Run(() => Methods.IncrementarContador(difficulty, ref contDifficulty));
        }

        private async void bttDownDif_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.decrementando = true;
            await Task.Run(() => Methods.DecrementarContador(difficulty, ref contDifficulty));
        }


        private void bttDownDif_MouseUp(object sender, MouseEventArgs e)
        {
            Methods.decrementando = false;
        }

        private void bttUpDif_MouseUp(object sender, MouseEventArgs e)
        {
            Methods.incrementando = false;
        }
        private void bttAddEnemy_MouseEnter(object sender, EventArgs e)
        {
            bttAddEnemy.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttAddEnemy_Click(object sender, EventArgs e)
        {
            ContentEnemy contEnemy = new ContentEnemy(this, bttContentEnemies);
            contEnemy.ShowDialog();
        }

        private void bttAddRoom_Click(object sender, EventArgs e)
        {
            ContentRoom contRoom = new ContentRoom(this, bttContentRooms);
            contRoom.ShowDialog();
        }

        private void bttAddFurniture_Click(object sender, EventArgs e)
        {
            ContentFurniture contFurn = new ContentFurniture(this, bttContentFurniture);
            contFurn.ShowDialog();
        }

        private void bttAddObject_Click(object sender, EventArgs e)
        {
            ContentObject contObj = new ContentObject(this, bttContentObjects);
            contObj.ShowDialog();
        }

        private void bttAddRoom_MouseEnter(object sender, EventArgs e)
        {
            bttAddRoom.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttAddFurniture_MouseEnter(object sender, EventArgs e)
        {
            bttAddFurniture.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttAddObject_MouseEnter(object sender, EventArgs e)
        {
            bttAddObject.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttContentEnemies_MouseEnter(object sender, EventArgs e)
        {
            bttContentEnemies.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttContentObjects_Click(object sender, EventArgs e)
        {
            InfoContentObject inf = new InfoContentObject(this, bttContentObjects);
            inf.ShowDialog();
        }

        private void bttContentEnemies_Click(object sender, EventArgs e)
        {
            InfoContEnemy inf = new InfoContEnemy(this,bttContentEnemies);
            inf.ShowDialog();
        }

        private void bttContentFurniture_Click(object sender, EventArgs e)
        {
            InfoContentFurniture inf = new InfoContentFurniture(this, bttContentFurniture);
            inf.ShowDialog();
        }

        private void bttContentRooms_Click(object sender, EventArgs e)
        {
            InfoContentRoom inf = new InfoContentRoom(this, bttContentRooms);
            inf.ShowDialog();
        }

        private void bttContentRooms_MouseEnter(object sender, EventArgs e)
        {
            bttContentRooms.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttContentFurniture_MouseEnter(object sender, EventArgs e)
        {
            bttContentFurniture.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttContentObjects_MouseEnter(object sender, EventArgs e)
        {
            bttContentObjects.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttUpCorr_MouseEnter(object sender, EventArgs e)
        {
            bttUpCorr.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttDownCorr_MouseEnter(object sender, EventArgs e)
        {
            bttDownCorr.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttUpSDoor_MouseEnter(object sender, EventArgs e)
        {
            bttUpSDoor.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttDownSDoor_MouseEnter(object sender, EventArgs e)
        {
            bttDownSDoor.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private async void bttUpCorr_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.incrementando = true;
            await Task.Run(() => Methods.IncrementarContador(corridor, ref contCorridor));
        }

        private void bttUpCorr_MouseUp(object sender, MouseEventArgs e)
        {
            Methods.incrementando = false;
        }

        private async void bttDownCorr_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.decrementando = true;
            await Task.Run(() => Methods.DecrementarContador(corridor, ref contCorridor));
        }

        private void bttDownCorr_MouseUp(object sender, MouseEventArgs e)
        {
            Methods.decrementando = false;
        }

        private async void bttUpSDoor_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.incrementando = true;
            await Task.Run(() => Methods.IncrementarContador(sDoor, ref contSDoor));
        }

        private void bttUpSDoor_MouseUp(object sender, MouseEventArgs e)
        {
            Methods.incrementando = false;
        }

        private async void bttDownSDoor_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.decrementando = true;
            await Task.Run(() => Methods.DecrementarContador(sDoor, ref contSDoor));
        }

        private void bttDownSDoor_MouseUp(object sender, MouseEventArgs e)
        {
            Methods.decrementando = false;
        }
    }
}
