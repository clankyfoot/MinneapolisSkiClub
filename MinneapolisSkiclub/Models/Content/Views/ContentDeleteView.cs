using System;
using System.ComponentModel.DataAnnotations;

namespace MinneapolisSkiclub.Models.Content.Views
{
    [NonSerialized]
    public class ContentDeleteView : Shared.SecureModel
    {
        public long content_id { get; set; }
        [Required(ErrorMessage = "Subtitle required")]
        [Display(Name = "Subtitle")]
        [DataType(DataType.Text)]
        public string subtitle { get; set; }
        [Required(ErrorMessage = "Content required")]
        [Display(Name = "Content")]
        [DataType(DataType.Html)]
        public string content { get; set; }
    }
}