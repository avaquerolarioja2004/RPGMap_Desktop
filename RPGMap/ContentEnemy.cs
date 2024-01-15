using RPGMap.dbRPGMap;
using RPGMap.dbRPGMap.entities;
using RPGMap.res;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RPGMap
{
    public partial class ContentEnemy : Form
    {
        private Generar generar;
        private List<EnemyTable> listaEnemy;
        private Fonts u = new Fonts();
        private Button bttAddEnemy;

        public ContentEnemy()
        {
            InitializeComponent();
        }

        public ContentEnemy(Generar generar, Button bttAddEnemy)
        {
            InitializeComponent();
            this.bttAddEnemy = bttAddEnemy;
            this.generar = generar;
            listaEnemy = CRDEnemy.GetAllEnemies().Where(enemy => !generar.ListaEnemy.Contains(enemy)).ToList();
        }

        private void bttGen_Click(object sender, EventArgs e)
        {
            if (generar.ListaEnemy.Count > 0)
            {
                Methods.MostrarButton(bttAddEnemy);
            }
            this.Close();
        }

        private void ContentEnemy_Loader(object sender, EventArgs e)
        {
            bttClose.Font= u.getFontBttMini();
            tittleSelectEnemies.Font = u.getFontLbTittleVecna();
            int buttonsPerRow = 2;
            int separation = 65;
            int currentX = 70;
            int currentY = 0;

            foreach (var enemy in listaEnemy)
            {
                //Caben bien nombres de 9 caracteres con formato nombre: dificultad
                ButtonAddCont enemyButton = new ButtonAddCont(enemy, generar, layoutButtons);
                enemyButton.FlatStyle = FlatStyle.Flat;
                enemyButton.Font = u.getFontBttContent();
                enemyButton.Size = new Size(135, 62);
                enemyButton.BackgroundImage = Properties.Resources.rectangle_mini_mini;

                // Verifica si agregar el botón en la fila actual superará el ancho del panel
                if (currentX + enemyButton.Width + separation > layoutButtons.Width)
                {
                    // Si supera el ancho del panel, pasa a la siguiente fila
                    currentX = 0;
                    currentY += enemyButton.Height + separation;
                }

                // Establece la posición del botón y agrégalo al contenedor
                enemyButton.Location = new Point(currentX, currentY);
                layoutButtons.Controls.Add(enemyButton);

                // Actualiza la posición X para el próximo botón
                currentX += enemyButton.Width + separation;

                // Verifica si se llegó al máximo de botones por fila
                if ((currentX + separation) / (enemyButton.Width + separation) == buttonsPerRow)
                {
                    currentX = 70;
                    currentY += enemyButton.Height + separation;
                }
            }
        }


    }
}
