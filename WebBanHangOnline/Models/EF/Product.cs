using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanHangOnline.Models.EF
{
    [Table("tb_Product")]
    public class Product :CommonAbstract
    {
        public Product() {
            this.ProductImage = new HashSet<ProuctImage>();
            this.OrderDetails = new HashSet<OrderDetail>();
            this.Reviews = new HashSet<ReviewProduct>();
            this.Size_Colors = new HashSet<Size_Color>();

        }
        [Key]  //Khóa chính
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự sinh Id
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        [StringLength(250)]

        public string Alilas { get; set; }

        [StringLength(50)]
        public String ProductCode {  get; set; }

        public string Description { get; set; }

        [AllowHtml]
        public string Detail { get; set; }
        [StringLength(250)]

        public string Image { get; set; }

        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceSale { get; set; }
        public int Quantity { get; set; }
        public int ViewCount { get; set; }
        public bool IsHome { get; set; }


        public bool IsFeature { get; set; }
        public bool IsHot { get; set; }
        public bool IsActive { get; set; }

        public bool IsSale { get; set; }

        public int ProductCategoryId { get; set; }
        [StringLength(250)]

        public string SeoTitle { get; set; }
        [StringLength(500)]

        public string SeoDescription { get; set; }
        public string SeoKeywords { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<ProuctImage> ProductImage { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ReviewProduct> Reviews { get; set; }
        public virtual ICollection<Size_Color> Size_Colors { get; set; }


    }
}