using System.ComponentModel.DataAnnotations;

namespace URLShortenerProject.Model
{
    public class UrlMapping
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string ShortUrl { get; set; } = string.Empty;

        [Required]
        public string LongUrl { get; set; } = string.Empty ;
    }
}
