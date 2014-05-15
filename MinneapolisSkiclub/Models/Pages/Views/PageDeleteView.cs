using System;

namespace MinneapolisSkiclub.Models.Pages.Views
{
    [NonSerialized]
    public class PageDeleteView : Shared.SecureModel
    {
        public string page_id { get; set; }
        public string page_name { get; set; }
    }
}