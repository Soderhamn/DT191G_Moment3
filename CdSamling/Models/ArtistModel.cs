using System.ComponentModel.DataAnnotations;

namespace CdSamling.Models {
    public class Artist 
    {
        public int Id { get; set; }

        [Required]
        public string? Name {get; set; }
    }
} 