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
        public string Body { get; set; }
        public string Author { get; set; }
        public string BigMiddleText { get; set; }
        public string AuthorPictureUrl { get; set; }
        public string AdPictureUrl { get; set; }
        public string SideBarTitle { get; set; }
        public string SideBarBody { get; set; }
    }
}