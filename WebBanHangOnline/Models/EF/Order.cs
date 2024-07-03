using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    [Table("tb_Order")]
    public class Order :CommonAbstract
    {
        public Order() 
        { 
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]  //Khóa chính
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự sinh Id
        public int Id { get; set; }
        [Required]
        public String Code { get; set; }
        [Required(ErrorMessage ="Tên khách hàng không để trống")]
        public String CustomerName { get; set; }
        [Required(ErrorMessage = "Số điện thoại không để trống")]
        public String Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ không để trống")]
        public String Address { get; set; }
        public String Email { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal ShippingFee { get; set; }
        public int Quantity { get; set; }
        public int TypePayment { get; set; }

        public string CustomerId { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}