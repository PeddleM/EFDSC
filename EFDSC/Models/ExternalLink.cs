using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDSC.Models
{
    public class ExternalLink
    {
        public string LinkText { get; set; }
        public string URL { get; set; }

        public ExternalLink(string linkText, string url)
        {
            this.LinkText = linkText;
            this.URL = url;
        }
    }
}