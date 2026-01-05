using System.ComponentModel.DataAnnotations;

namespace MyWebAPP.Models
{
    public class Category
    {
        [Key]
        public int Category_ID { get; set; }
       
        [Required]
        [MaxLength(20)]
        public string Category_Name { get; set; }
        [Range(1,50)]
        public int Display_Order { get; set; }
    }
}
