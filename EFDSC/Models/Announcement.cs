using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDSC.Models
{
    public class Announcement
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }

        public Announcement(string title, string content, DateTime date)
        {
            this.Title = title;
            this.Content = content;
            this.Date = date.ToShortDateString();
        }
    }
}