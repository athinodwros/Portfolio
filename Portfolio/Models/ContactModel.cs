using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Models
{
    public class ContactModel
    {
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone", Prompt = "Phone:")]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email", Prompt = "Email:")]
        public string Email { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Time", Prompt = "Time:")]
        public string Time { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Text", Prompt = "Text:")]
        public string Text { get; set; }
    }
}
