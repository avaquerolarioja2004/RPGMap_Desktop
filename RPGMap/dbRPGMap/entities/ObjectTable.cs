using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPGMap.dbRPGMap.entities
{
    [Table("object_table")]
    public class ObjectTable
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Column("image_info")]
        public byte[] ImageInfo { get; set; }

        public ObjectTable(string name, byte[] imageInfo)
        {
            Name = name;
            ImageInfo = imageInfo;
        }

        public ObjectTable()
        {
        }
    }
}
