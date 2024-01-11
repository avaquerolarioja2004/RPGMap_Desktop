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
        private RPGMap mainForm;
        private Utilities u = new Utilities();
        private int contDificulty=0;
        private int contSDoor = 0;
        private int contCorridor = 0;
        private bool incrementando = false;
        private bool decrementando = false;

        public Generar()
        {
            InitializeComponent();
        }

        public Generar(RPGMap mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            difficulty.Text = contDificulty.ToString();
            this.BackgroundImage = Properties.Resources.untitled;
            corridor.Text = contCorridor.ToString();
            sDoor.Text = contSDoor + "%";
        }

        private void Generar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainForm.Close();
        }

        private void bttRigth_Click(object sender, EventArgs e)
        {
            Map m = new Map(this);
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
        }

        private void bttUpDif_MouseEnter(object sender, EventArgs e)
        {
            bttUpDif.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttDownDif_MouseEnter(object sender, EventArgs e)
        {
            bttDownDif.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ThreadPool.QueueUserWorkItem(IncrementarContador);
        }

        private void IncrementarContador(object state)
        {
            int tiempoEspera = 185;
            while (incrementando && contDificulty < 100)
            {
                Thread.Sleep(tiempoEspera);
                contDificulty++;
                tiempoEspera = Math.Max(70, tiempoEspera - 8);
                ActualizarContador();
            }
        }

        private void OcultarButton()
        {
            if (bttGen.InvokeRequired)
            {
                // Si no estamos en el hilo de la interfaz de usuario, invocamos la operación en ese hilo
                bttGen.Invoke(new MethodInvoker(() => bttGen.Visible = false));
            }
            else
            {
                // Estamos en el hilo de la interfaz de usuario, simplemente realizamos la operación
                bttGen.Visible = false;
            }
        }

        private void DecrementarContador(object state)
        {
            int tiempoEspera = 185;
            while (decrementando && contDificulty > 0)
            {
                Thread.Sleep(tiempoEspera);
                contDificulty--;
                tiempoEspera = Math.Max(70, tiempoEspera - 8);
                ActualizarContador();
            }
        }

        private void ActualizarContador()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(ActualizarContador));
            }
            else
            {
                difficulty.Text = contDificulty.ToString();
            }
        }

        private void bttUpDif_MouseDown(object sender, MouseEventArgs e)
        {
            incrementando = true;
            ThreadPool.QueueUserWorkItem(IncrementarContador);
        }

        private void bttUpDif_MouseUp(object sender, MouseEventArgs e)
        {
            incrementando = false;
        }

        private void bttDownDif_MouseDown(object sender, MouseEventArgs e)
        {
            decrementando = true;
            ThreadPool.QueueUserWorkItem(DecrementarContador);
        }

        private void bttDownDif_MouseUp(object sender, MouseEventArgs e)
        {
            decrementando = false;
        }

        private void bttAddEnemy_MouseEnter(object sender, EventArgs e)
        {
            bttAddEnemy.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void bttAddEnemy_Click(object sender, EventArgs e)
        {

        }

        private void bttAddRoom_Click(object sender, EventArgs e)
        {

        }

        private void bttAddFurniture_Click(object sender, EventArgs e)
        {

        }

        private void bttAddObject_Click(object sender, EventArgs e)
        {

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
    }
}
