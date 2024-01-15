using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMap.dbRPGMap.entities
{
    [Table("room_table")]
    public class RoomTable
    {
        [Key]
        [Range(0, 10)]
        public int X { get; set; }

        [Key]
        [Range(0, 10)]
        public int Y { get; set; }

        public RoomTable(int x, int y)
        {
            X = x;
            Y = y;
        }

        public RoomTable()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is RoomTable table &&
                   X == table.X &&
                   Y == table.Y;
        }
    }
}
