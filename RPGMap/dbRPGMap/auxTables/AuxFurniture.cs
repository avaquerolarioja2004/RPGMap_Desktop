using RPGMap.dbRPGMap.entities;

namespace RPGMap.dbRPGMap.auxTables
{
    public class AuxFurniture
    {
        public FurnitureTable Furniture { get; set; }
        public int SomeIntProperty { get; set; }

        public AuxFurniture(FurnitureTable furniture, int someIntProperty)
        {
            Furniture = furniture;
            SomeIntProperty = someIntProperty;
        }
    }
}
