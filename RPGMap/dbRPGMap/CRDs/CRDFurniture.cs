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
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
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
                        return true; // Eliminación exitosa
                    }
                    return false; // El mueble no fue encontrado
                }
            }
            catch (Exception ex)
            {
                return false; // La eliminación falló
            }
        }
    }
}
