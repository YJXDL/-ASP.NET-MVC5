using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2创建一个简单的数据录入程序.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email Address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please Enter A Vaild Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email Address")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email Address")]
        public bool? WillAttend { get; set; }
    }
}