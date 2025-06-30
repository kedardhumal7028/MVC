using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeMgt.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage = "Please Enter Your ID")]
        [Display(Name = "Id")]
        public string Id { get; set; }



        [Required(ErrorMessage = "Please Enter Your Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }




        [Required(ErrorMessage = "Please Enter Your Surname")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }



        [Required(ErrorMessage = "Please Enter Your Username")]
        [Display(Name = "Username")]        
        public string Username { get; set; }



        [Required(ErrorMessage = "Please Enter Your Strong Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }



        [Display(Name = "Token")]
        public string Token { get; set; }
    }
}