using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Footers")]// Thuộc tính Table chỉ tra tên bảng
    public class Footer
    {
        [Key]// Thuộc tính khóa chính
        [MaxLength(50)]
        public String ID { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Content")]
        public String Content { get; set; }
    }
}