using RPGMap.dbRPGMap.entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.IO;

namespace RPGMap.dbRPGMap
{
    public class ContextDB : DbContext
    {
        public ContextDB() : base("name=ContextDB")
        {
            Database.SetInitializer<ContextDB>(null); // Desactivar inicializador de migraciones
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            string connectionString = Database.Connection.ConnectionString;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    // Define aquí el SQL para crear tu tabla solo si no existe
                    string createRoomTableSql = @"
                        CREATE TABLE IF NOT EXISTS room_table (
                            X INTEGER NOT NULL,
                            Y INTEGER NOT NULL,
                            PRIMARY KEY(X, Y)
                        );";

                    command.CommandText = createRoomTableSql;
                    command.ExecuteNonQuery();

                    // SQL para crear la tabla enemy_table
                    string createEnemyTableSql = @"
                        CREATE TABLE IF NOT EXISTS enemy_table (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            name TEXT NOT NULL,
                            difficulty INTEGER NOT NULL,
                            image_data BLOB
                        );";

                    command.CommandText = createEnemyTableSql;
                    command.ExecuteNonQuery();

                    // SQL para crear la tabla object_table
                    string createObjectTableSql = @"
                        CREATE TABLE IF NOT EXISTS object_table (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            name TEXT NOT NULL,
                            image_info BLOB
                        );";

                    command.CommandText = createObjectTableSql;
                    command.ExecuteNonQuery();

                    // SQL para crear la tabla furniture_table
                    string createFurnitureTableSql = @"
                        CREATE TABLE IF NOT EXISTS furniture_table (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            name TEXT NOT NULL,
                            x INTEGER NOT NULL,
                            y INTEGER NOT NULL,
                            image_info BLOB,
                            covers_visibility BOOLEAN NOT NULL
                        );";

                    command.CommandText = createFurnitureTableSql;
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public string GetDatabasePath()
        {
            string databaseRelativePath = string.Empty;

            try
            {
                // Asegurarse de que la conexión esté abierta
                Database.Connection.Open();
                databaseRelativePath = Database.Connection.Database;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la ruta de la base de datos: {ex.Message}");
            }
            finally
            // Cerrar la conexión después de obtener la ruta
            {
                Database.Connection.Close();
            }

            // Obtener la ruta absoluta incluyendo el nombre del archivo de la base de datos
            string databaseAbsolutePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dbRPGMap.db"));

            return databaseAbsolutePath;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomTable>().HasKey(rt => new { rt.X, rt.Y });
            modelBuilder.Entity<RoomTable>().ToTable("room_table");
            modelBuilder.Entity<EnemyTable>().ToTable("enemy_table");
            modelBuilder.Entity<ObjectTable>().ToTable("object_table");
            modelBuilder.Entity<FurnitureTable>().ToTable("furniture_table");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<RoomTable> roomsTable { get; set; }
        public DbSet<EnemyTable> enemiesTable { get; set; }
        public DbSet<ObjectTable> objectsTable { get; set; }
        public DbSet<FurnitureTable> furnitureTable { get; set; }
    }
}
