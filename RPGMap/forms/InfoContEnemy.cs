using RPGMap.dbRPGMap.entities;
using RPGMap.res;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RPGMap
{
    public partial class InfoContEnemy : Form
    {
        private Generar generar;
        private List<EnemyTable> listaEnemy;
        private Fonts u = new Fonts();
        private Button bttAddEnemy;

        public InfoContEnemy()
        {
            InitializeComponent();
        }

        public InfoContEnemy(Generar generar, Button bttAddEnemy)
        {
            InitializeComponent();
            this.bttAddEnemy = bttAddEnemy;
            this.generar = generar;
            listaEnemy = generar.ListaEnemy;
        }

        private void bttGen_Click(object sender, EventArgs e)
        {
            if (generar.ListaEnemy.Count < 1)
            {
                Methods.OcultarButton(bttAddEnemy);
            }
            this.Close();
        }

        private void InfoContEnemy_Load(object sender, EventArgs e)
        {
            bttCloseEdit.Font = u.getFontBttMini();
            tittleEditEnemies.Font = u.getFontLbTittleVecna();
            int buttonsPerRow = 2;
            int separation = 65;
            int currentX = 80;
            int currentY = 0;

            foreach (var enemy in listaEnemy)
            {
                // Crea un botón con la clase InfoContEnemy
                ButtonConfigContent enemyButton = new ButtonConfigContent(enemy, generar, layoutButtonsEdit);
                enemyButton.Size = new Size(135, 62);

                // Verifica si agregar el botón en la fila actual superará el ancho del panel
                if (currentX + enemyButton.Width + separation > layoutButtonsEdit.Width)
                {
                    // Si supera el ancho del panel, pasa a la siguiente fila
                    currentX = 80;
                    currentY += enemyButton.Height + separation;
                }

                // Establece la posición del botón y agrégalo al contenedor
                enemyButton.Location = new Point(currentX, currentY);
                enemyButton.Font = u.getFontBttContent();
                enemyButton.FlatStyle = FlatStyle.Flat;
                enemyButton.BackgroundImage = Properties.Resources.rectangle_mini_mini;
                layoutButtonsEdit.Controls.Add(enemyButton);

                // Actualiza la posición X para el próximo botón
                currentX += enemyButton.Width + separation;

                // Verifica si se llegó al máximo de botones por fila
                if ((currentX + separation) / (enemyButton.Width + separation) == buttonsPerRow)
                {
                    currentX = 80;
                    currentY += enemyButton.Height + separation;
                }
            }
        }
    }
}

