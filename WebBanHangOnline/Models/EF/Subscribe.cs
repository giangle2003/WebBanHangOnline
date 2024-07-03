using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    [Table("tb_Subsribe")]
    public class Subscribe : CommonAbstract
    {
        [Key]  //Khóa chính
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự sinh Id
        public int Id { get; set; }

        [EmailAddress]
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
    }
}