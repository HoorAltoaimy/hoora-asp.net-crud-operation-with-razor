using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LicenseExpiratiomTracker3.Models
{
    public class License
    {
        [Key]
        public int id { get; set; }
        [DisplayName("License title")]
        [Required]
        public string title { get; set; }
        [DisplayName("Started At")]
        public DateTime startedAt { get; set; }
        [DisplayName("Ending At")]
        public DateTime endingAt { get; set; }
    }
}
