using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialContentWebSite.Models
{
    public class StatisticsModel
    {
        public int CategoryCount { get; set; }
        public int Heading { get; set; }
        public int Writer { get; set; }
        public string HeadingMax { get; set; }
        public int StatusDifference { get; set; }
    }
}