using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PersonalSite.UI.MVC.Models
{
    public class ContactViewModel
    {

        //We need Name, Subject, Message, Email.
        [Required(ErrorMessage = "* Name is required.")]
        public string Name { get; set; }

        public string Subject { get; set; }//don't need a required for this.

        [Required(ErrorMessage = "* Message is required.")]
        [UIHint("MultiLineText")]
        public string Message { get; set; }

        
        [EmailAddress(ErrorMessage = "* Email is requried")]
        [Required(ErrorMessage = "* Please make sure your email is in proper formatting.")]
        [Display(Name ="Your Email")]
        public string EmailAddress { get; set; }


    }
}