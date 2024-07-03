using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    [Table("Color")]

    public class Color
    {
        public Color()
        {
            Size_Colors = new HashSet<Size_Color>();
        }

        [Key]
        public int color_id { get; set; }

        [Column("color")]
        [StringLength(50)]
        public string color { get; set; }

        public virtual ICollection<Size_Color> Size_Colors { get; set; }

    }
}