using RPGMap.dbRPGMap.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGMap.dbRPGMap
{
    public class CRDObject
    {
        public static bool InsertObject(ObjectTable objectTable)
        {
            try
            {
                using (var dbContext = new ContextDB())
                {
                    // Verificar si el objeto ya existe en la base de datos
                    bool objectExists = dbContext.objectsTable.Any(o => o.Name == objectTable.Name);

                    if (!objectExists)
                    {
                        // Si no existe, entonces agregar y guardar cambios
                        dbContext.objectsTable.Add(objectTable);
                        dbContext.SaveChanges();

                        Console.WriteLine("Objeto creado con éxito.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Objeto ya existe en la base de datos.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el objeto: {ex.Message}");
                return false;
            }
        }

        public static List<ObjectTable> GetAllObjects()
        {
            using (var dbContext = new ContextDB())
            {
                return dbContext.objectsTable.ToList();
            }
        }

        public static ObjectTable GetObjectById(int id)
        {
            using (var dbContext = new ContextDB())
            {
                return dbContext.objectsTable.Find(id);
            }
        }

        public static bool DeleteObject(int id)
        {
            try
            {
                using (var dbContext = new ContextDB())
                {
                    var existingObject = dbContext.objectsTable.Find(id);

                    if (existingObject != null)
                    {
                        dbContext.objectsTable.Remove(existingObject);
                        dbContext.SaveChanges();
                        Console.WriteLine("Objeto eliminado con éxito.");
                        return true; // Eliminación exitosa
                    }

                    Console.WriteLine("Objeto no encontrado en la base de datos.");
                    return false; // El objeto no fue encontrado
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el objeto: {ex.Message}");
                return false; // La eliminación falló
            }
        }
    }
}

