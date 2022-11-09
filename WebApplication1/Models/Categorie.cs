
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Categorie
    {
        [Key]
        public int categorie_id { get; set; }
        [Required]
        public string categorie_name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; }= DateTime.Now;
    }
}
