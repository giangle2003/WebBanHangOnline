using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    [Table("tb_Adv")]    ///Ánh xạ sang bảng tb_Adv
    public class Adv : CommonAbstract
    {
        [Key]  //Khóa chính
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự sinh Id
        public int Id { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        [StringLength(500)]

        public string Image { get; set; }
        [StringLength(500)]
        public string Link { get; set; }
        public int Type { get; set; }
    }
}