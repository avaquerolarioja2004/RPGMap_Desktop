using RPGMap.dbRPGMap.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMap.dbRPGMap
{
    public class CRDRoom
    {
        public static bool CrearSala(int x, int y)
        {
            try
            {
                using (var dbContext = new ContextDB())
                {
                    // Verificar si la sala ya existe en la base de datos
                    bool salaExistente = dbContext.roomsTable.Any(sala => sala.X == x && sala.Y == y || sala.X == y && sala.Y == x);

                    if (!salaExistente)
                    {
                        // Si no existe, entonces agregar y guardar cambios
                        RoomTable nuevaSala = new RoomTable(x, y);
                        dbContext.roomsTable.Add(nuevaSala);
                        dbContext.SaveChanges();

                        Console.WriteLine("Sala creada con éxito.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Sala ya existe en la base de datos.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la sala: {ex.Message}");
                return false;
            }
        }



        public static List<RoomTable> GetAll()
        {
            using (var dbContext = new ContextDB())
            {
                return dbContext.roomsTable.ToList();
            }
        }

        public static bool Delete(RoomTable roomTable)
        {
            try
            {
                using (var dbContext = new ContextDB())
                {
                    var existingRoom = dbContext.roomsTable.Find(roomTable.X, roomTable.Y);

                    if (existingRoom != null)
                    {
                        dbContext.roomsTable.Remove(existingRoom);
                        dbContext.SaveChanges();
                        return true; // Eliminación exitosa
                    }

                    return false; // La sala no fue encontrada
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la sala: {ex.Message}");
                return false; // La eliminación falló
            }
        }

    }
}
