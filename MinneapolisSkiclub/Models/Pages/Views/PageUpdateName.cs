using System;
using System.ComponentModel.DataAnnotations;

namespace MinneapolisSkiclub.Models.Pages.Views
{
    [NonSerialized]
    public class PageUpdateName : Shared.SecureModel
    {
        [Required(ErrorMessage="Page ID required")]
        [Display(Name="Page ID")]
        public long page_id { get; set; }
        [Required(ErrorMessage="Page Name required")]
        [Display(Name="Page Name")]
        [[DataType(DataType.Text)]]
        public string page_name { get; set; }
    }
}