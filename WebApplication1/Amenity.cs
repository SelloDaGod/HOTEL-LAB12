using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class Amenity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
