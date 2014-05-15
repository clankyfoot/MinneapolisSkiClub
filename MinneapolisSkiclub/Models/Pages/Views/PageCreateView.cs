using System;

namespace MinneapolisSkiclub.Models.Pages.Views
{
    [NonSerialized]
    public class PageCreateView : Shared.SecureModel
    {
        public string subtitle { get; set; }
    }
}