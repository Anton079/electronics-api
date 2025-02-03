using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace electronics_api.Electronics.Models
{
    [Table("electronic")]
    public class Electronic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("type")]
        public string Type { get; set; }

        [Required]
        [Column("model")]
        public string Model { get; set; }

        [Required]
        [Column("price")]
        public int price { get; set; }
    }
}
