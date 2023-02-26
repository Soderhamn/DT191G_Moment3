using System.ComponentModel.DataAnnotations;

namespace CdSamling.Models 
{
    public class Cd 
    {
        //Properties
        public int Id { get; set; }

        [Required]
        public string? CdName { get; set; }
        [Required]
        public string? ArtistName { get; set; }
        [Required]
        public int? NrTracks { get; set; }
        [Required]
        public int? ReleaseYear { get; set; }
    }
}
