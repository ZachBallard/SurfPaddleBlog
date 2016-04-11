using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfPaddleBlog.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AuthorPictureUrl { get; set; }
        public DateTime PostTime { get; set; }
        public string Body1 { get; set; }
        public string BigMiddleText { get; set; }
        public string Body2 { get; set; }
        public string AdPictureUrl { get; set; }
        public string SideBarTitle { get; set; }
        public string SideBarBody { get; set; }
    }
}