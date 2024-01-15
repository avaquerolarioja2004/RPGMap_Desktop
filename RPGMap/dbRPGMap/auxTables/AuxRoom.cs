using RPGMap.dbRPGMap.entities;

namespace RPGMap.dbRPGMap.auxTables
{
    public class AuxRoom
    {
        public RoomTable Room { get; set; }
        public int SomeIntProperty { get; set; }

        public AuxRoom(RoomTable room, int someIntProperty)
        {
            Room = room;
            SomeIntProperty = someIntProperty;
        }
    }
}
