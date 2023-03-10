using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(0,100,ErrorMessage = "Illegal Number")]
        public int DisplayOrder { get; set; }
        public DateTime CurrentDateTime { get; set; } = DateTime.Now;
    }
}
