using System.ComponentModel.DataAnnotations;

namespace MyWebAPP.Models
{
    public class Category
    {
        [Key]
        public int Category_ID { get; set; }
       
        [Required]
        public string Category_Name { get; set; }

        public string Display_Order { get; set; }
    }
}
