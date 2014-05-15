using System;
using System.ComponentModel.DataAnnotations;

namespace MinneapolisSkiclub.Models.Content.Views
{
    [NonSerialized]
    public class ContentUpdateSubtitleView : Shared.SecureModel
    {
        public long conent_id { get; set; }
        [Required(ErrorMessage = "Subtitle required")]
        [Display(Name = "Subtitle")]
        [DataType(DataType.Text)]
        public string subtitle { get; set; }
    }
}