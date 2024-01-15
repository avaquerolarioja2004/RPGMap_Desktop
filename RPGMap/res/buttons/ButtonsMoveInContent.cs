using RPGMap.dbRPGMap;
using RPGMap.dbRPGMap.entities;
using RPGMap.res.contenedor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RPGMap.res.buttons
{
    class ButtonsMoveInContent : Panel
    {
        private Button rooms, enemies, furniture, objects;
        private Fonts u;
        private List<RoomTable> listaRoom;
        private List<ObjectTable> listaObject;
        private List<FurnitureTable> listaFurniture;
        private List<EnemyTable> listaEnemy;
        ContDB<ObjectTable> container4;
        ContDB<FurnitureTable> container3;
        ContDB<EnemyTable> container2;
        ContDB<RoomTable> container1;
        private Content content;

        public ButtonsMoveInContent(Label label, Content content, Button bttInfo, Button bttAdd)
        {
            this.content = content;
            u = new Fonts();
            listaEnemy = CRDEnemy.GetAllEnemies();
            listaRoom = CRDRoom.GetAll();
            listaObject = CRDObject.GetAllObjects();
            listaFurniture = CRDFurniture.GetAllFurniture();
            container4 = new ContDB<ObjectTable>(listaObject);
            container3 = new ContDB<FurnitureTable>(listaFurniture);
            container2 = new ContDB<EnemyTable>(listaEnemy);
            container1 = new ContDB<RoomTable>(listaRoom);
            content.Controls.Add(container3);
            content.Controls.Add(container2);
            content.Controls.Add(container1);
            content.Controls.Add(container4);
            container4.Visible = false;
            container3.Visible = false;
            container2.Visible = false;
            container1.Visible = true;
            label.Text = "Salas";
            label.Location = new Point(500, 9);
            label.Font = u.getFontLbTittleVecna();
            this.BackColor = Color.Transparent;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Padding = new Padding(3);
            this.Size = new Size(80, 250);

            rooms = new Button();
            ConfigureButton(rooms, Properties.Resources.icono_salas, 'R', label, bttInfo, bttAdd);
            rooms.Location = new Point(10, 10);

            enemies = new Button();
            ConfigureButton(enemies, Properties.Resources.icono_calavera, 'E', label, bttInfo, bttAdd);
            enemies.Location = new Point(10, rooms.Bottom + 10);

            furniture = new Button();
            ConfigureButton(furniture, Properties.Resources.icono_muebles, 'F', label, bttInfo, bttAdd);
            furniture.Location = new Point(10, enemies.Bottom + 10);

            objects = new Button();
            ConfigureButton(objects, Properties.Resources.icono_objetos, 'O', label, bttInfo, bttAdd);
            objects.Location = new Point(10, furniture.Bottom + 10);

            Controls.Add(rooms);
            Controls.Add(enemies);
            Controls.Add(furniture);
            Controls.Add(objects);
        }

        private void ConfigureButton(Button button, Image buttonImage, char identifier, Label label, Button bttInfo, Button bttAdd)
        {
            button.BackColor = Color.Transparent;
            button.Size = new Size(50, 50);
            button.Image = buttonImage;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            // Agrega un evento de clic común a todos los botones
            button.Click += (sender, e) => Button_Click(sender, identifier, label, bttInfo, bttAdd);
        }

        private void Button_Click(object sender, char identifier, Label label, Button bttInfo, Button add)
        {
            // Lógica para manejar el clic en cualquier botón
            switch (identifier)
            {
                case 'R':
                    content.Controls.Remove(container1);
                    label.Text = "Salas";
                    label.Location = new Point(500, 9);
                    listaRoom = CRDRoom.GetAll();
                    container1 = new ContDB<RoomTable>(listaRoom);
                    content.Controls.Add(container1);
                    container1.Visible = true;
                    container4.Visible = false;
                    container3.Visible = false;
                    container2.Visible = false;
                    break;

                case 'E':
                    content.Controls.Remove(container2);
                    label.Text = "Enemigos";
                    label.Location = new Point(490, 9);
                    listaEnemy = CRDEnemy.GetAllEnemies();
                    container2 = new ContDB<EnemyTable>(listaEnemy);
                    content.Controls.Add(container2);
                    container2.Visible = true;
                    container4.Visible = false;
                    container3.Visible = false;
                    container1.Visible = false;
                    break;

                case 'F':
                    content.Controls.Remove(container3);
                    label.Text = "Muebles";
                    label.Location = new Point(490, 9);
                    listaFurniture = CRDFurniture.GetAllFurniture();
                    container3 = new ContDB<FurnitureTable>(listaFurniture);
                    content.Controls.Add(container3);
                    container2.Visible = false;
                    container4.Visible = false;
                    container3.Visible = true;
                    container1.Visible = false;
                    break;

                case 'O':
                    content.Controls.Remove(container4);
                    label.Text = "Objetos";
                    label.Location = new Point(490, 9);
                    listaObject = CRDObject.GetAllObjects();
                    container4 = new ContDB<ObjectTable>(listaObject);
                    content.Controls.Add(container4);
                    container2.Visible = false;
                    container4.Visible = true;
                    container3.Visible = false;
                    container1.Visible = false;
                    break;

                default:
                    // Acción predeterminada o manejo de otros identificadores
                    break;
            }
        }
    }
}
