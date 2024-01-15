using RPGMap.dbRPGMap.entities;
using RPGMap.res.buttons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMap.res.contenedor
{
    class ContDB<T> : Panel
    {
        private Fonts u=new Fonts();

        public ContDB(List<T> list)
        {
            this.AutoScroll = true;
            this.Size = new Size(841, 608);
            this.Location = new Point(191, 122);
            this.BackColor = Color.Transparent;
            int buttonsPerRow = 4;
            int separation = 65;
            int currentX = 40;
            int currentY = 0;
            foreach (var obj in list)
            {
                BttDataBase objButton = new BttDataBase(obj, this);
                objButton.FlatStyle = FlatStyle.Flat;
                objButton.Font = u.getFontBttContent();
                objButton.Size = new Size(135, 62);
                objButton.BackgroundImage = Properties.Resources.rectangle_mini_mini;

                // Verifica si agregar el botón en la fila actual superará el ancho del panel
                if (currentX + objButton.Width + separation > this.Width)
                {
                    // Si supera el ancho del panel, pasa a la siguiente fila
                    currentX = 40;
                    currentY += objButton.Height + separation;
                }

                // Establece la posición del botón y agrégalo al contenedor
                objButton.Location = new Point(currentX, currentY);
                this.Controls.Add(objButton);

                // Actualiza la posición X para el próximo botón
                currentX += objButton.Width + separation;

                // Verifica si se llegó al máximo de botones por fila
                if ((currentX + separation) / (objButton.Width + separation) == buttonsPerRow)
                {
                    currentX = 40;
                    currentY += objButton.Height + separation;
                }
            }
        }
    }
}
