using RPGMap.dbRPGMap.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGMap.dbRPGMap
{
    public class CRDEnemy
    {
        public static bool InsertEnemy(EnemyTable enemyTable)
        {
            try
            {
                using (var dbContext = new ContextDB())
                {
                    // Verificar si el enemigo ya existe en la base de datos
                    bool enemyExists = dbContext.enemiesTable.Any(e => e.Name == enemyTable.Name && e.Difficulty == enemyTable.Difficulty);

                    if (!enemyExists)
                    {
                        // Si no existe, entonces agregar y guardar cambios
                        dbContext.enemiesTable.Add(enemyTable);
                        dbContext.SaveChanges();

                        Console.WriteLine("Enemigo creado con éxito.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Enemigo ya existe en la base de datos.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el enemigo: {ex.Message}");
                return false;
            }
        }

        public static List<EnemyTable> GetAllEnemies()
        {
            using (var dbContext = new ContextDB())
            {
                return dbContext.enemiesTable.ToList();
            }
        }

        public static EnemyTable GetEnemyById(int id)
        {
            using (var dbContext = new ContextDB())
            {
                return dbContext.enemiesTable.Find(id);
            }
        }

        public static bool DeleteEnemy(int id)
        {
            try
            {
                using (var dbContext = new ContextDB())
                {
                    var existingEnemy = dbContext.enemiesTable.Find(id);

                    if (existingEnemy != null)
                    {
                        dbContext.enemiesTable.Remove(existingEnemy);
                        dbContext.SaveChanges();
                        Console.WriteLine("Enemigo eliminado con éxito.");
                        return true; // Eliminación exitosa
                    }

                    Console.WriteLine("Enemigo no encontrado en la base de datos.");
                    return false; // El enemigo no fue encontrado
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el enemigo: {ex.Message}");
                return false; // La eliminación falló
            }
        }
    }
}
