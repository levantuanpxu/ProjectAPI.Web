using System;
using System.Collections.Generic;
using System.Text;

namespace Blogdulich.Web.Models.Users
{
  public  class UpdateUser
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Gmail { get; set; }
        public string Password { get; set; }
    }
}
