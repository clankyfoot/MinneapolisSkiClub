using System;

namespace MinneapolisSkiclub.Models.Content.Views
{
    [Serializable]
    public class ContentView
    {
        public long content_id { get; set; }
        public string subtitle { get; set; }
        public string content { get; set; }
    }
}