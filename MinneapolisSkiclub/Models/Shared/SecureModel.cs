using System;
using System.ComponentModel.DataAnnotations;

namespace MinneapolisSkiclub.Models.Shared
{
    public class SecureModel
    {
        [Required(ErrorMessage="Password required")]
        [Display(Name="Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}