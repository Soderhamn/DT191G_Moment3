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
        public int? NrTracks { get; set; }
        [Required]
        public int? ReleaseYear { get; set; }

        [Required]
        public int ArtistId { get; set; }

        public Artist? Artist { get; set;}
    }
}
