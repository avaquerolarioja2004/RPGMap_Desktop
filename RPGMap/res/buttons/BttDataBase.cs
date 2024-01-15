using RPGMap.dbRPGMap;
using RPGMap.dbRPGMap.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMap.res.buttons
{
    public class BttDataBase: Button
    {
        public BttDataBase(Object tabla, Panel layoutButtons)
        {
            switch (tabla)
            {
                case EnemyTable _:
                    {
                        EnemyTable e = (EnemyTable)tabla;
                        Text = $"{e.Name}: {e.Difficulty}";

                        Click += (sender, args) =>
                        {
                            PopUpBorrado popUp = new PopUpBorrado(e);
                            popUp.ShowDialog();
                            if (popUp.borrado)
                            {
                                CRDEnemy.DeleteEnemy(e.Id);
                                layoutButtons.Controls.Remove(this);
                            }
                        };
                        break;
                    }

                case RoomTable _:
                    {
                        RoomTable e = (RoomTable)tabla;
                        Text = $"{e.X}-{e.Y}";

                        Click += (sender, args) =>
                        {
                            PopUpBorrado popUp = new PopUpBorrado(e);
                            popUp.ShowDialog();
                            if (popUp.borrado)
                            {
                                CRDRoom.Delete(e);
                                layoutButtons.Controls.Remove(this);
                            }
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
                            PopUpBorrado popUp = new PopUpBorrado(e);
                            popUp.ShowDialog();
                            if (popUp.borrado)
                            {
                                CRDFurniture.DeleteFurniture(e.Id);
                                layoutButtons.Controls.Remove(this);
                            }
                        };
                        break;
                    }

                case ObjectTable _:
                    {
                        ObjectTable e = (ObjectTable)tabla;
                        Text = $"{e.Name}";

                        Click += (sender, args) =>
                        {
                            PopUpBorrado popUp = new PopUpBorrado(e);
                            popUp.ShowDialog();
                            if (popUp.borrado)
                            {
                                CRDObject.DeleteObject(e.Id);
                                layoutButtons.Controls.Remove(this);
                            }
                        };
                        break;
                    }
            }
        }
    }
}
