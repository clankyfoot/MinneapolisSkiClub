using System;

namespace MinneapolisSkiclub.Models.Content
{
    [Serializable]
    public class Content
    {
        public long content_id { get; set; }
        public long page_id { get; set; }
        public string subtitle { get; set; }
        public string content { get; set; }
        public long order { get; set; }
    }
}