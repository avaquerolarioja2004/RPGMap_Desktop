using System;
using System.Drawing;
using System.Windows.Forms;
using RPGMap.dbRPGMap.entities;

namespace RPGMap.res
{
    public class ButtonAddCont : Button
    {

        // Constructor para inicializar la información del enemigo
        public ButtonAddCont(Object tabla, Generar generar, Panel layoutButtons)
        {
            switch (tabla)
            {
                case EnemyTable _:
                    {
                        EnemyTable e = (EnemyTable)tabla;
                        Text = $"{e.Name}: {e.Difficulty}";

                        Click += (sender, args) =>
                        {
                            // Accede al objeto EnemyTable a través de los argumentos y agrégalo a la lista
                            generar.ListaEnemy.Add(e);
                            layoutButtons.Controls.Remove(this);
                        };
                        break;
                    }

                case RoomTable _:
                    {
                        RoomTable e = (RoomTable)tabla;
                        Text = $"{e.X}-{e.Y}";

                        Click += (sender, args) =>
                        {
                            // Accede al objeto EnemyTable a través de los argumentos y agrégalo a la lista
                            generar.ListaRoom.Add(e);
                            layoutButtons.Controls.Remove(this);
                        };
                        break;
                    }

                case FurnitureTable _:
                    {
                        FurnitureTable e = (FurnitureTable)tabla;
                        if (e.CoversVisibility)
                        {
                            Text = $"{e.Name}:\n{e.X}-{e.Y}-Cubre";
                        }
                        else
                        {
                            Text = $"{e.Name}:\n{e.X}-{e.Y}";
                        }


                        Click += (sender, args) =>
                        {
                            // Accede al objeto EnemyTable a través de los argumentos y agrégalo a la lista
                            generar.ListaFurniture.Add(e);
                            layoutButtons.Controls.Remove(this);
                        };
                        break;
                    }

                case ObjectTable _:
                    {
                        ObjectTable e = (ObjectTable)tabla;
                        Text = $"{e.Name}";

                        Click += (sender, args) =>
                        {
                            // Accede al objeto EnemyTable a través de los argumentos y agrégalo a la lista
                            generar.ListaObject.Add(e);
                            layoutButtons.Controls.Remove(this);
                        };
                        break;
                    }
                    
            }

        }
    }
}