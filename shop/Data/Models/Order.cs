using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Models
{
    public class Order
    {[BindNever]
        public int Id { get; set; }
        [Display(Name = "Enter your name")]
        [StringLength(10)]
        [Required(ErrorMessage = "Your name length have to longer than 10 laters")]
        public string name { get; set; }
        [Display(Name = "Surname")]
        [StringLength(10)]
        [Required(ErrorMessage = "Your surname length have to longer than 10 laters")]
        public string surname { get; set; }
        [Display(Name = "Adress")]
        [StringLength(20)]
        [Required(ErrorMessage = "Your adress length have to longer than 10 laters")]
        public string adress { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "Your phone length have to longer than 10 laters")]
        public string phone { get; set; }
        
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Your email length have to longer than 25 laters")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails{ get; set; }
    }
}
