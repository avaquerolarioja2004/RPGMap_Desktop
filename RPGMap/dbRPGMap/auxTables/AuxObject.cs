using RPGMap.dbRPGMap.entities;

namespace RPGMap.dbRPGMap.auxTables
{
    public class AuxObject
    {
        public ObjectTable ObjectAux { get; set; }
        public int SomeIntProperty { get; set; }

        public AuxObject(ObjectTable obj, int someIntProperty)
        {
            ObjectAux = obj;
            SomeIntProperty = someIntProperty;
        }
    }
}
