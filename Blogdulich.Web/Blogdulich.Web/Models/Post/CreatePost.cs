using System;
using System.Collections.Generic;
using System.Text;

namespace Blogdulich.Web.Models.Post
{
  public  class CreatePost
    {
        //public int PostId { get; set; }
        public string Title { get; set; }
        public string FullContent { get; set; }
        public string Image { get; set; }

        public string Published { get; set; }

    }
}
