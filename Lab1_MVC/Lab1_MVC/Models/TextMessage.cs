using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab1_MVC.Models
{
    public class TextMessage
    {

        //destination mobile phone number (10 digits) and content (max 140 characters).

        public int id { get; set; }

        [Required(ErrorMessage = "Number must not be blank!")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Number must be 10 digits long")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Number must be 10 digits long")]
        [DisplayName("To")]
        public String PhoneNumber { get; set; }


        [Required(ErrorMessage = "Message must not be blank!")]
        [StringLength(140, ErrorMessage = "Message must be no more than 140 characters long")]
        [DisplayName("Message")]
        public String Content { get; set; }


    }
}