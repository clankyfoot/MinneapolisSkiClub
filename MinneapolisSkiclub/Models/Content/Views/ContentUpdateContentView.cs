using System;
using System.ComponentModel.DataAnnotations;

namespace MinneapolisSkiclub.Models.Content.Views
{
    [NonSerialized]
    public class ContentUpdateContentView : Shared.SecureModel
    {
        public long conent_id { get; set; }
        [Required(ErrorMessage = "Content required")]
        [Display(Name = "Content")]
        [DataType(DataType.Text)]
        public string content { get; set; }
    }
}