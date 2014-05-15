using System;

namespace MinneapolisSkiclub.Models.Pages.Views
{
    /// <summary>
    /// View for displaying the page data
    /// </summary>
    [NonSerialized]    
    public class PageView
    {
        public long page_id { get; set; }
        public string page_name { get; set; }
    }
}