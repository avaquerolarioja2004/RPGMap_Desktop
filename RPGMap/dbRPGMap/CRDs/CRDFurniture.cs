using RPGMap.dbRPGMap.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGMap.dbRPGMap
{
    public class CRDFurniture
    {
        public static bool InsertFurniture(FurnitureTable furnitureTable)
        {
            try
            {
                using (var dbContext = new ContextDB())
                {
                    // Verificar si el mueble ya existe en la base de datos
                    bool furnitureExists = dbContext.furnitureTable.Any(f => f.Name == furnitureTable.Name
                                                                        && f.X == furnitureTable.X
                                                                        && f.Y == furnitureTable.Y
                                                                        && f.CoversVisibility == furnitureTable.CoversVisibility);

                    if (!furnitureExists)
                    {
                        // Si no existe, entonces agregar y guardar cambios
                        dbContext.furnitureTable.Add(furnitureTable);
                        dbContext.SaveChanges();

                        Console.WriteLine("Mueble creado con éxito.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Mueble ya existe en la base de datos.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el mueble: {ex.Message}");
                return false;
            }
        }

        public static List<FurnitureTable> GetAllFurniture()
        {
            using (var dbContext = new ContextDB())
            {
                return dbContext.furnitureTable.ToList();
            }
        }

        public static FurnitureTable GetFurnitureById(int id)
        {
            using (var dbContext = new ContextDB())
            {
                return dbContext.furnitureTable.Find(id);
            }
        }

        public static bool DeleteFurniture(int id)
        {
            try
            {
                using (var dbContext = new ContextDB())
                {
                    var existingFurniture = dbContext.furnitureTable.Find(id);

                    if (existingFurniture != null)
                    {
                        dbContext.furnitureTable.Remove(existingFurniture);
                        dbContext.SaveChanges();
                        Console.WriteLine("Mueble eliminado con éxito.");
                        return true; // Eliminación exitosa
                    }

                    Console.WriteLine("Mueble no encontrado en la base de datos.");
                    return false; // El mueble no fue encontrado
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el mueble: {ex.Message}");
                return false; // La eliminación falló
            }
        }
    }
}
