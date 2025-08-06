using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppSamsar.Models
{
    public class AppUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Input Invalid")]
        [MinLength(3)]
        [MaxLength(30)]
        public string Username { get; set; }
        
        [Required]
        [MinLength(6)]
        [MaxLength(30)]
        public string Password { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string NickName { get; set; }


        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public DateTime CDate { get; set; } = DateTime.Now;
        [NotMapped]
        public virtual ICollection<Article>? Articles{ get; set; }



    }
}
