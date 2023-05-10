using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace swaggerapi.Models
{
    [Table("Train")]
    public class Train
    {
        public int trainId { get; set; }
        [Required]
        public string? trainName { get; set; }
        [Required]
        public string? from { get; set; }
        [Required]
        public string? to { get; set; }

    }
}
