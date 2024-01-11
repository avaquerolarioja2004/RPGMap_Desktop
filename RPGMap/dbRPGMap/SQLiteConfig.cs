using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.SQLite.EF6;
using System.Data.SQLite;

namespace RPGMap.dbRPGMap
{
    public class SQLiteConfig : DbConfiguration
    {
        public SQLiteConfig()
        {
            SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
            SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
            SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
        }
    }
}
