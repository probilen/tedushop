using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập tên Menu")]
        public String Name { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập URL")]
        public String URL { get; set; }
        public int DisplayOrder { get; set; }
        [Required]
        public int GroupID { get; set; }
        //Cách set Khóa ngoại
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }
        public String Target { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
