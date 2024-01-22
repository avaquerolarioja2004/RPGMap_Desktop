using RPGMap.dbRPGMap;
using RPGMap.res.contenedor;
using System;
using System.Windows.Forms;

namespace RPGMap
{
    public partial class PopUpAdd : Form
    {
        private Content content;
        private Fonts f;
        public int X, Y, difficulty;
        public String name;
        public bool covers;
        public Func<byte[]> ImageProvider;
        public Func<(int, int)> DimProvider;
       
        public PopUpAdd(Content content)
        {
            InitializeComponent();
            this.content = content;
            f = new Fonts();
        }

        private void PopUpAdd_Load(object sender, EventArgs e)
        {
            this.bttClose.Font = f.getFontBttContent();
            this.bttAdd.Font = f.getFontBttContent();
            this.tittleAdd.Font = f.getFontLbTittleVecna();

            switch (content.tipe)
            {
                case 'R':
                    Controls.Add(new ContentAddDB('R', this));
                    break;
                case 'F':
                    Controls.Add(new ContentAddDB('F', this));
                    break;
                case 'O':
                    Controls.Add(new ContentAddDB('O', this));
                    break;
                case 'E':
                    Controls.Add(new ContentAddDB('E', this));
                    break;
            }
        }

        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            switch (content.tipe)
            {
                case 'R':
                    var dim = DimProvider();
                    if (dim.Item1 != 0 && dim.Item2 != 0)
                    {
                        if (CRDRoom.CrearSala(dim.Item1, dim.Item2))
                        {
                            MessageBox.Show("Sala añadida", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Error: La sala ya existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: X e Y deben ser valores diferentes de cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 'F':
                    if (!string.IsNullOrEmpty(name) && X != 0 && Y != 0 && ImageProvider != null)
                    {
                        if (CRDFurniture.InsertFurniture(new dbRPGMap.entities.FurnitureTable(name, X, Y, ImageProvider(), covers)))
                        {
                            MessageBox.Show("Mueble añadido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Error: El mueble ya existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Asegúrate de proporcionar un nombre, X, Y y una imagen válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 'O':
                    if (!string.IsNullOrEmpty(name) && ImageProvider != null)
                    {
                        if (CRDObject.InsertObject(new dbRPGMap.entities.ObjectTable(name, ImageProvider())))
                        {
                            MessageBox.Show("Objeto añadido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Error: El objeto ya existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Asegúrate de proporcionar un nombre y una imagen válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 'E':
                    if (!string.IsNullOrEmpty(name) && ImageProvider != null)
                    {
                        if (CRDEnemy.InsertEnemy(new dbRPGMap.entities.EnemyTable(name, difficulty, ImageProvider())))
                        {
                            MessageBox.Show("Enemigo añadido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Error: El enemigo ya existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Asegúrate de proporcionar un nombre, dificultad y una imagen válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }


    }

}

