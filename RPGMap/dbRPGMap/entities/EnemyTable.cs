using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMap.dbRPGMap.entities
{
    [Table("enemy_table")]
    public class EnemyTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("difficulty")]
        public int Difficulty { get; set; }

        [Column("image_data")]
        public byte[] ImageData { get; set; }

        public EnemyTable(string nombre, int difficulty, byte[] imageData)
        {
            Name = nombre;
            Difficulty = difficulty;
            ImageData = imageData;
        }

        public EnemyTable()
        {
        }
    }
}

