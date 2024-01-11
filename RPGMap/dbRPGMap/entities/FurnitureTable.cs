using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPGMap.dbRPGMap.entities
{
    [Table("furniture_table")]
    public class FurnitureTable
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Column("x")]
        public int X { get; set; }

        [Column("y")]
        public int Y { get; set; }

        [Column("image_info")]
        public byte[] ImageInfo { get; set; }

        [Column("covers_visibility")]
        public bool CoversVisibility { get; set; }

        public FurnitureTable(string name, int x, int y, byte[] imageInfo, bool coversVisibility)
        {
            Name = name;
            X = x;
            Y = y;
            ImageInfo = imageInfo;
            CoversVisibility = coversVisibility;
        }

        public FurnitureTable()
        {
        }
    }
}

