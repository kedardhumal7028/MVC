using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomeValidationSample.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }

        [KedsValidation]
        //[KedsValidation (ErrorMessage = "Kedar is required")]
        public string Message { get; set; }

    }
}