using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppSamsar.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        [MinLength(10)]
        public string Title { get; set; }
        [MaxLength(3000)]
        [MinLength(50)]
        public string Content { get; set; }

        public DateTime Cdate { get; set; }

        public bool IsPublish { get; set; } = false;

        public int Views { get; set; }
        public string AuthorName { get; set; }
        public string Image { get; set; }
        [ForeignKey("AppUser")]
        public string AppUserUsername { get; set; }
        public virtual AppUser AppUser { get; set; }

    }
}
