using System;

namespace MinneapolisSkiclub.Models.Pages
{
    [Serializable]
    public class Pages
    {
        public long page_id { get; set; }
        public string page_name { get; set; }
        public long order { get; set; }
    }
}